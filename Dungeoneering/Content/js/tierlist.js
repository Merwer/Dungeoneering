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
        var section = $('<section>');
        for (var categoryIndex in rarities[rarityIndex]) {
            var list = rarities[rarityIndex][categoryIndex];
            if (list.length != 0) {
                var subsection = $('<div>').addClass('panel').addClass('panel-default');
                var head = $('<div>').addClass('panel-heading');
                if (categoryIndex == 0) {
                    head.append($('<h3>').addClass('panel-title').text('Undecided'));
                } else {
                    var low = (categoryIndex * 10);
                    head.append($('<h3>').addClass('panel-title').text(low + "-" + (low + 9)));
                }
                subsection.append(head);

                var body = $('<div>').addClass('panel-body');
                var htmlList = $('<ul>').addClass("list-inline");
                for (var cardIndex in list) {
                    var card = list[cardIndex];
                    htmlList.append($('<li>').addClass('card').text(card.name));
                }
                body.append(htmlList);
                subsection.append(body);
                section.append(subsection);
            }
        }
        var content = $('.' + rarityIndex + "-content", ele);
        content.html('').append(section);
    }
}

$('.archetype-tab[data-toggle="tab"]').on('show.bs.tab', function (e) {
    var archetype = $(e.target).data('archetype');
    var targetElement = $($(e.target).attr('href'));
    $.get('/Cards/' + archetype, function (cards) {
        createTable(targetElement, cards);
    });
})