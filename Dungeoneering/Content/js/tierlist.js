function createTable(ele, cards) {
    ele.html('');
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
        var section = $('<section>');
        section.append($('<h3>').text(rarityIndex));
        for (var categoryIndex in rarities[rarityIndex]) {
            var list = rarities[rarityIndex][categoryIndex];
            if (list.length != 0) {
                var subsection = $('<div>');
                if (categoryIndex == 0) {
                    subsection.append($('<h3>').text('Undecided'));
                } else {
                    var low = (categoryIndex * 10);
                    subsection.append($('<h3>').text(low + "-" + (low + 9)));
                }
                var htmlList = $('<ul>');
                for (var cardIndex in list) {
                    var card = list[cardIndex];
                    htmlList.append($('<li>').addClass('card').text(card.name));
                }
                subsection.append(htmlList);
                section.append(subsection);
            }
        }
        ele.append(section);
    }
}

$('.archetype-tab[data-toggle="tab"]').on('show.bs.tab', function (e) {
    var archetype = $(e.target).data('archetype');
    var targetElement = $($(e.target).attr('href'));
    $.get('/Cards/' + archetype, function (cards) {
        createTable(targetElement, cards);
    });
})