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
chronicle.dungeoneering = chronicle.dungeoneering || {};
chronicle.dungeoneering.draft = chronicle.dungeoneering.draft || {};
chronicle.dungeoneering.draft.read = (function ($) {
    'use strict';

    var cardList;
    var deck;
    var draftState;
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

    var addCard = function (cardId) {
        var card = cardList.getCard(cardId);
        deck.addCard(card);
        addCardRewards(card);
        refreshDeck();
    };

    var clearChoices = function () {
        selectionSlots.addClass('empty').removeClass('selected');
        selectionSlots.children('img').attr('src', '/Content/img/card_back.png');
        selectionSlots.children('.card-score').html('');
        selectionSlots.data('cardId', null);
    };

    var getRound = function () {
        return window.parseInt(roundCounter.find('.current').val(), 10);
    }

    var showRoundFromHash = function () {
        var roundId = window.location.hash.substr(1);
        showRound(roundId);
    }

    var setRoundHash = function (roundId) {
        window.history.pushState(null, null, "#" + roundId);
        showRound(roundId);
    }

    var showRound = function (roundId) {
        if (0 < roundId && roundId <= 15) {
            clearChoices();
            roundCounter.find('.current').val(roundId);
            if (draftState.rounds.length >= roundId) {
                var round = draftState.rounds[roundId - 1];
                var index;
                for (index = 0; index < round.options.length; index++) {
                    var slot = cardSelected(cardList.getCard(round.options[index]));
                    if ($.inArray(round.options[index], round.selected) > -1) {
                        cardPicked.apply(slot);
                    }
                }
            }
        }
    };

    var findNextEmptySlot = function () {
        var unfilledSlots = selectionSlots.filter('.empty');
        return unfilledSlots.length === 0 ? null : $(unfilledSlots[0]);
    };

    var cardSelected = function (selectedCard) {
        var img;
        var score;
        var nextSlot = findNextEmptySlot();
        if (!nextSlot) {
            return null;
        }

        var tier = getCategoryForScore(selectedCard.score);
        nextSlot.removeClass("tier-0 tier-1 tier-2 tier-3 tier-4 tier-5 tier-6 tier-7")
            .addClass("tier-" + tier);
        img = $(nextSlot.children('img').eq(0));
        img.attr('src', selectedCard.image);
        score = $(nextSlot.children('.card-score').eq(0));
        score.html(selectedCard.score);
        nextSlot.removeClass('empty');
        nextSlot.data('cardId', selectedCard.id);
        return nextSlot;
    };

    var cardPicked = function () {
        var choice = $(this).closest('.card-choice');
        if (choice.hasClass('selected')) {
            choice.removeClass('selected');
        } else if (choice.hasClass('empty')) {
            return;
        } else {
            var selectedCount = selectionSlots.filter('.selected').length;
            if (selectedCount < 2) {
                choice.addClass('selected');
            }
        }
    };

    var incrementRound = function () {
        setRoundHash(getRound() + 1);
    };

    var decrementRound = function () {
        setRoundHash(getRound() - 1);
    };

    var refreshWithState = function (state, callback) {
        draftState = state;
        deck = new chronicle.Deck();
        cardList = new chronicle.CardList(draftState.archetype, function () {
            init();
            if ($.isFunction(callback)) {
                callback();
            }
        });
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

        if (window.location.hash) {
            showRoundFromHash();
        } else {
            setRoundHash((draftState.rounds.length % 15) + 1);
        }
        refreshUI();

        roundCounter.find('.prev').click(decrementRound);
        roundCounter.find('.current').change(function () {
            setRoundHash($(this).val());
        });
        roundCounter.find('.next').click(incrementRound);
        window.addEventListener("hashchange", showRoundFromHash, false);
    };

    return {
        setState: refreshWithState,
        displayRound: setRoundHash,
        markSelected: cardPicked,
        showCard: cardSelected,
        getCardList: function () { return cardList; },
        getDraftState: function () { return draftState },
        addCard,
        setRoundHash,
        getRound
    };
}(jQuery));