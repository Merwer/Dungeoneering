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
if (!chronicle.dungeoneering.draft.read) {
    throw new Error("Missing requried reference: draft-read.js");
}
chronicle.dungeoneering = chronicle.dungeoneering || {};
chronicle.dungeoneering.draft = chronicle.dungeoneering.draft || {};
chronicle.dungeoneering.draft.write = (function ($) {
    'use strict';

    var selectionSlots = $('.card-choices .card-choice');

    var constructRound = function () {
        var round = {
            draftId: chronicle.dungeoneering.draft.read.getDraftState().id,
            roundId: chronicle.dungeoneering.draft.read.getRound(),
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

    var performSave = function () {
        var data = constructRound();
        $.ajax({
            type: 'POST',
            url: '/Drafts/' + data.draftId + '/Round',
            data: data,
            dataType: "json"
        }).done(function (response) {
            if (response && response.redirect) {
                window.location.href = response.redirect;
            } else {
                var draftState = chronicle.dungeoneering.draft.read.getDraftState();
                draftState.rounds.push(data);
                chronicle.dungeoneering.draft.read.addCard(data.selected[0]);
                chronicle.dungeoneering.draft.read.addCard(data.selected[1]);
                chronicle.dungeoneering.draft.read.setRoundHash(draftState.rounds.length + 1);
            }
        }).fail(function () {
            window.alert('Save failed');
        });
    };

    var saveCheck = function () {
        var selectedCount = selectionSlots.filter('.selected').length;
        var unfilledCount = selectionSlots.filter('.empty').length;
        if (selectedCount === 2 && unfilledCount === 0) {
            performSave();
            return true;
        }
        return false;
    };

    var clearText = function () {
        $('.typeahead').typeahead('val', '');
    };

    var cardSelected = function (ev, selectedCard) {
        chronicle.dungeoneering.draft.read.showCard(selectedCard);
        clearText();
        saveCheck();
    };

    var cardCloseClicked = function (evt) {
        var choiceSlot = $(this).closest('.card-choice');
        choiceSlot.addClass('empty').removeClass('selected');
        choiceSlot.children('img').attr('src', '/Content/img/card_back.png');
        choiceSlot.children('.card-score').html('');
        choiceSlot.data('cardId', null);
    };

    var cardPicked = function () {
        chronicle.dungeoneering.draft.read.markSelected.apply(this);
        saveCheck();
    };

    var refreshWithState = function (state) {
        chronicle.dungeoneering.draft.read.setState(state, init);
    };

    var init = function () {
        selectionSlots.find('.close').click(cardCloseClicked);
        selectionSlots.find('img').click(cardPicked);

        var cardData = new Bloodhound({
            datumTokenizer: Bloodhound.tokenizers.obj.whitespace('name'),
            queryTokenizer: Bloodhound.tokenizers.whitespace,
            local: chronicle.dungeoneering.draft.read.getCardList().activeCards()
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
    };

    return {
        setState: refreshWithState
    };
}(jQuery));