function createTable(ele, cards) {
    var rarities = {
        saphire: Array.apply(null, Array(8)).map(function () { return []; }),
        emerald: Array.apply(null, Array(8)).map(function () { return []; }),
        ruby: Array.apply(null, Array(8)).map(function () { return []; }),
        diamond: Array.apply(null, Array(8)).map(function () { return []; })
    };
    var maxLength = 0;
    for (var index in cards) {
        var card = cards[index];
        var categoryIndex = getCategoryForScore(card.score);
        var arr = rarities[card.rarity][categoryIndex];
        arr.push(card);
        // This could be done at the end, which would be quicker, but would involve another double-loop
        arr.sort(function (c1, c2) { return c2.score - c1.score; });
        if (arr.length > maxLength) {
            maxLength = arr.length;
        }
    }
    
    for (var rarityIndex in rarities) {
        var content = $('.' + rarityIndex + "-content", ele);
        var categories = rarities[rarityIndex];
        for (var categoryIndex = 0; categoryIndex < categories.length; categoryIndex++) {
            var listEle = $('ol.tier-' + categoryIndex, content);
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
                    cardDescription.attr("data-toggle", "tooltip")
                    cardDescription.find('dt').text(card.name);
                    cardDescription.find('dd').text(card.score);
                    cardDescription.tooltip({
                        animated: 'fade',
                        placement: 'bottom',
                        title: "<img class='card-tooltip' src='" + card.image + "'/>",
                        html: true
                    });
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