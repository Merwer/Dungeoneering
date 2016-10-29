function createTable(ele, cards) {
    var rarities = {
        saphire: Array.apply(null, Array(11)).map(function () { return []; }),
        emerald: Array.apply(null, Array(11)).map(function () { return []; }),
        ruby: Array.apply(null, Array(11)).map(function () { return []; }),
        diamond: Array.apply(null, Array(11)).map(function () { return []; })
    };
    var maxLength = 0;
    for (var index in cards) {
        var card = cards[index];
        var categoryIndex;
        if (card.score === -1) {
            categoryIndex = 0;
        } else {
            categoryIndex = Math.floor(card.score / 10);
        }
        var arr = rarities[card.rarity][categoryIndex];
        arr.push(card);
        if (arr.length > maxLength) {
            maxLength = arr.length;
        }
    }
    
    for (var rarityIndex in rarities) {
        var content = $('.' + rarityIndex + "-content", ele);
        var categories = rarities[rarityIndex];
        for (var categoryIndex = categories.length - 1; categoryIndex >= 0; categoryIndex--) {
            var listEle = $('ol.tier-' + (categories.length - categoryIndex), content);
            var cardList = categories[categoryIndex];
            for (var cardIndex = 0; cardIndex < maxLength; cardIndex++) {
                var cardItem = $('<li>').addClass("tiered-card");
                var cardDescription = $('<dl>')
                        .addClass('empty')
                        .addClass("card")
                        .append($('<dt>').addClass('card-name'))
                        .append($('<dd>').addClass('card-score'));
                if(cardList.length > cardIndex) {
                    var card = cardList[cardIndex];
                    cardDescription.removeClass('empty')
                        .addClass(card.parent.archetype || 'common')
                        .addClass(card.rarity)
                        .addClass(card.type);
                    cardDescription.find('dt').text(card.name);
                    cardDescription.find('dd').text(card.score);
                }
                cardItem.append(cardDescription);
                listEle.append(cardItem);
            }
        }
    }
}

$('.archetype-tab[data-toggle="tab"]').on('show.bs.tab', function (e) {
    var archetype = $(e.target).data('archetype');
    var targetElement = $($(e.target).attr('href'));
    $.get('/Cards/' + archetype, function (cards) {
        createTable(targetElement, cards);
    });
})