/*global jQuery*/
var chronicle = chronicle || {};
chronicle.CardList = function (archetype, callback) {
    "use strict";

    var cards;
    var that = this;
    var lookup = [];

    this.allCards = function () {
        return cards;
    };

    this.getCard = function (id) {
        return lookup[id];
    };

    this.ready = false;

    var init = function (cardList) {
        cards = cardList;
        jQuery.each(cardList, function (index, card) {
            lookup[card.id] = card;
        });
        that.ready = true;
        if (callback && jQuery.isFunction(callback)) {
            callback();
        }
    };

    jQuery.getJSON('/Drafts/cardList?archetype=' + archetype, function (data) {
        init(data);
    });

    return this;
};