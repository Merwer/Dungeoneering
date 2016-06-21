/*global jQuery,Bloodhound,chronicle*/
if (!chronicle || !chronicle.constants) {
    throw new Error("Missing required reference: chronicle-base.js");
}
if (!chronicle.CardList) {
    throw new Error("Missing required reference: cardList.js");
}
if (!chronicle.Deck) {
    throw new Error("Missing required reference: deck.js");
}
chronicle.dungeoneering = chronicle.dungoneering || {};
chronicle.dungeoneering.draft = (function ($) {
    'use strict';

    var cardList;
    var deck;
    var draftState;
    var saveEnabled = true;
    var selectionSlots = $('.card-choices .card-choice');
    var roundCounter = $('.round-counter');

    var addToHtml = function (element, amount) {
        element.html(window.parseInt(element.html(), 10) + amount);
    };

    var addCardRewards = function (card) {
        addToHtml($('.rewards .attack'), card.rewards.attack);
        addToHtml($('.rewards .armour'), card.rewards.armour);
        addToHtml($('.rewards .gold'), card.rewards.coins);
        addToHtml($('.rewards .health'), card.rewards.health);
        addToHtml($('.rewards .weapon'), card.rewards.weapon ? 1 : 0);
    };

    var addCardToSupport = function (card, count) {
        var item = $('<li>');
        item.append($('<span>').addClass('icon').addClass('gold').addClass('value').html(card.cost));
        item.append($('<span>').addClass('name').html(card.name));
        item.append($('<span>').addClass('count').html(count));
        item.attr("data-toggle", "tooltip");
        item.tooltip({
            animated: 'fade',
            placement: 'left',
            title: "<img class='card-tooltip' src='" + card.image + "'/>",
            html: true
        });
        $('.support-selections').append(item);
    };

    var addCardToAttack = function (card, count) {
        var item = $('<li>');
        item.append($('<span>').addClass('icon').addClass('health').addClass('value').html(card.health));
        item.append($('<span>').addClass('name').html(card.name));
        item.append($('<span>').addClass('count').html(count));
        item.attr("data-toggle", "tooltip");
        item.tooltip({
            animated: 'fade',
            placement: 'left',
            title: "<img class='card-tooltip' src='" + card.image + "'/>",
            html: true
        });
        $('.fight-selections').append(item);
    };

    var refreshRewards = function () {
        $('.rewards li').html('0');

        $.each(deck.allCards(), function (num, ele) {
            var index;
            for (index = 0; index < ele.count; index += 1) {
                addCardRewards(ele.card);
            }
        });
    };

    var sortCards = function (param) {
        return function (a, b) {
            return a.card[param] - b.card[param];
        };
    };

    var refreshDeck = function () {
        $('.support-selections li').remove();
        $('.support-selections .heading .count').html('0');
        var supportList = deck.supportCards().sort(sortCards('cost'));
        var supportListSum = 0;
        $.each(supportList, function (index, element) {
            addCardToSupport(element.card, element.count);
            supportListSum += element.count;
        });
        $('.support-selections .heading .count').html(supportListSum);

        $('.fight-selections li').remove();
        $('.fight-selections .heading .count').html('0');
        var fightList = deck.fightCards().sort(sortCards('health'));
        var fightListSum = 0;
        $.each(fightList, function (index, element) {
            addCardToAttack(element.card, element.count);
            fightListSum += element.count;
        });
        $('.fight-selections .heading .count').html(fightListSum);
    };

    var refreshUI = function () {
        refreshRewards();
        refreshDeck();
    };

    var addCard = function (card) {
        deck.addCard(card);
        addCardRewards(card);
        refreshDeck();
    };

    var clearChoices = function () {
        selectionSlots.addClass('hidden').removeClass('selected');
        selectionSlots.children('img').attr('src', '');
        selectionSlots.data('cardId', null);
    };

    var getRound = function () {
        return window.parseInt(roundCounter.find('.current').val(), 10);
    }

    var constructRound = function () {
        var round = {
            draftId: draftState.id,
            roundId: getRound(),
            options: [],
            selected: []
        };
        $.each(selectionSlots, function (index, element) {
            var ele = $(element);
            var cardId = ele.data('cardId');
            round.options.push(cardId);
            if (ele.hasClass('selected')) {
                round.selected.push(cardId);
            }
        });
        return round;
    };

    var setRoundHash = function (roundId) {
        roundId = roundId || window.location.hash.substr(1);
        if (0 < roundId && roundId <= 15) {
            window.history.pushState(null, null, "#" + roundId);
            showRound(roundId);
        }
    }

    var showRound = function (roundId) {
        if (0 < roundId && roundId <= 15) {
            saveEnabled = false;
            clearChoices();
            roundCounter.find('.current').val(roundId);
            if (draftState.rounds.length >= roundId) {
                var round = draftState.rounds[roundId - 1];
                var index;
                for (index = 0; index < round.options.length; index++) {
                    var slot = cardSelected(null, cardList.getCard(round.options[index]));
                    if($.inArray(round.options[index], round.selected)) {
                        cardPicked.apply(slot);
                    }
                }
            }
            saveEnabled = true;
        }
    };

    var performSave = function () {
        var data = constructRound();
        $.ajax({
            type: 'POST',
            url: '/Drafts/Round',
            data: data,
            dataType: "json"
        }).done(function (response) {
            if (response && response.redirect) {
                window.location.href = response.redirect;
            } else {
                draftState.rounds.push(data);
                addCard(cardList.getCard(data.selected[0]));
                addCard(cardList.getCard(data.selected[1]));
                setRoundHash(draftState.rounds.length + 1);
            }
        }).fail(function () {
            window.alert('Save failed');
        });
    };

    var saveCheck = function () {
        if (!saveEnabled) {
            return false;
        }
        var selectedCount = selectionSlots.filter('.selected').length;
        var unfilledCount = selectionSlots.filter('.hidden').length;
        if (selectedCount === 2 && unfilledCount === 0) {
            performSave();
            return true;
        }
        return false;
    };

    var findNextEmptySlot = function () {
        var unfilledSlots = selectionSlots.filter('.hidden');
        return unfilledSlots.length === 0 ? null : $(unfilledSlots[0]);
    };

    var clearText = function () {
        $('.typeahead').typeahead('val', '');
    };

    var cardSelected = function (ev, selectedCard) {
        var img;
        var nextSlot = findNextEmptySlot();
        if (!nextSlot) {
            return null;
        }

        window.console.log('Selection: ', selectedCard);
        img = $(nextSlot.children('img').eq(0));
        img.attr('src', selectedCard.image);
        nextSlot.removeClass('hidden');
        nextSlot.data('cardId', selectedCard.id);
        clearText();
        saveCheck();
        return nextSlot;
    };

    var cardCloseClicked = function (evt) {
        var choiceSlot = $(this).closest('.card-choice');
        choiceSlot.addClass('hidden').removeClass('selected');
        choiceSlot.data('cardId', null);
    };

    var cardPicked = function () {
        var choice = $(this).closest('.card-choice');
        if (choice.hasClass('selected')) {
            choice.removeClass('selected');
        } else {
            var selectedCount = selectionSlots.filter('.selected').length;
            if (selectedCount < 2) {
                choice.addClass('selected');
            }
        }
        saveCheck();
    };

    var incrementRound = function () {
        setRoundHash(getRound() + 1);
    };

    var decrementRound = function () {
        setRoundHash(getRound() - 1);
    };

    var refreshWithState = function (state) {
        draftState = state;
        deck = new chronicle.Deck();
        cardList = new chronicle.CardList(draftState.archetype, init);
    };

    var init = function () {
        var roundId = 0;
        var round;
        var cardId;
        var cardIndex;
        for (roundId = 0; roundId < draftState.rounds.length; roundId += 1) {
            round = draftState.rounds[roundId];
            for (cardIndex = 0; cardIndex < round.selected.length; cardIndex += 1) {
                cardId = round.selected[cardIndex];
                var card = cardList.getCard(cardId);
                deck.addCard(card);
            }
        }

        setRoundHash((draftState.rounds.length % 15) + 1);
        refreshUI();

        selectionSlots.find('.close').click(cardCloseClicked);
        selectionSlots.find('img').click(cardPicked);
        roundCounter.find('.prev').click(decrementRound);
        roundCounter.find('.current').change(function () {
            setRoundHash($(this).val());
        });
        roundCounter.find('.next').click(incrementRound);
        window.addEventListener("hashchange", setRoundHash, false);

        var cardData = new Bloodhound({
            datumTokenizer: Bloodhound.tokenizers.obj.whitespace('name'),
            queryTokenizer: Bloodhound.tokenizers.whitespace,
            local: cardList.allCards()
        });
        cardData.initialize();

        $('.typeahead').typeahead({
            hint: true,
            highlight: true,
            minLength: 1
        }, {
            name: 'cards_search',
            displayKey: 'name',
            source: cardData.ttAdapter()
        }).bind('typeahead:select', cardSelected);

        deck = new chronicle.Deck();
        if (window._tmpState) {
            refreshWithState(window._tmpState);
            delete window._tmpState;
        }
    };

    return {
        setState: refreshWithState,
        displayRound: setRoundHash
    };
}(jQuery));