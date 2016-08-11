/*global jQuery*/
var chronicle = chronicle || {};
chronicle.CardList = function (archetype, callback) {
    "use strict";

    var cards;
    var activeCards;
    var that = this;
    var lookup = [];

    this.allCards = function () {
        return cards;
    };

    this.activeCards = function () {
        return activeCards;
    };

    this.getCard = function (id) {
        return lookup[id];
    };

    this.ready = false;

    var init = function (cardList) {
        cards = cardList;
        lookup = [];
        activeCards = [];
        jQuery.each(cardList, function (index, card) {
            lookup[card.id] = card;
            if (card.active) {
                activeCards.push(card);
            }
        });
        that.ready = true;
        if (callback && jQuery.isFunction(callback)) {
            callback();
        }
    };

    jQuery.getJSON('/Cards/' + archetype, function (data) {
        init(data);
    });

    return this;
};