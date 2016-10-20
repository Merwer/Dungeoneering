function createTable(ele, cards) {
    var rarities = {
        saphire: Array.apply(null, Array(11)).map(function () { return []; }),
        emerald: Array.apply(null, Array(11)).map(function () { return []; }),
        ruby: Array.apply(null, Array(11)).map(function () { return []; }),
        diamond: Array.apply(null, Array(11)).map(function () { return []; })
    };
    for (var index in cards) {
        var card = cards[index];
        var categoryIndex;
        if (card.score === -1) {
            categoryIndex = 0;
        } else {
            categoryIndex = Math.floor(card.score / 10);
        }
        rarities[card.rarity][categoryIndex].push(card);
    }
    
    for (var rarityIndex in rarities) {
        var content = $('.' + rarityIndex + "-content", ele);
        var table = $('table tbody', content);
        table.html('');
        var categories = rarities[rarityIndex];
        var maxLength = Math.max.apply(null, (categories.map(function (cardList) {
            return cardList.length;
        })));

        for (var categoryIndex = categories.length - 1; categoryIndex >= 0; categoryIndex--) {
            var cardList = categories[categoryIndex];
            var row = $('<tr>');
            for (var fillerIndex = 0; fillerIndex < maxLength; fillerIndex++) {
                var cell = $('<td>');
                if (fillerIndex < cardList.length) {
                    var card = cardList[fillerIndex];
                    var cardDetail = $('<div>')
                        .append($('<span>').text(card.name + ' '))
                        .append($('<span>').addClass('badge').text(card.score));
                    cell.append(cardDetail);
                }
                row.append(cell);
            }
            table.append(row);
        }

        table.each(function () {
            var $this = $(this);
            var newrows = [];
            $this.find("tr").each(function () {
                var i = 0;
                $(this).find("td").each(function () {
                    i++;
                    if (newrows[i] === undefined) {
                        newrows[i] = $("<tr></tr>");
                    }
                    newrows[i].append($(this));
                });
            });
            $this.find("tr").remove();
            $.each(newrows, function () {
                $this.append(this);
            });
        });
    }
}

$('.archetype-tab[data-toggle="tab"]').on('show.bs.tab', function (e) {
    var archetype = $(e.target).data('archetype');
    var targetElement = $($(e.target).attr('href'));
    $.get('/Cards/' + archetype, function (cards) {
        createTable(targetElement, cards);
    });
})