/*global jQuery, bootbox*/
var chronicle = chronicle || {};
chronicle.drafting = chronicle.drafting || {};
chronicle.drafting.index = (function ($) {
    "use strict";

    var submitModal = function () {
        var form = $(this);
        form.closest('.modal').modal('toggle');
        $.ajax(form.data('action'), {
            method: form.attr('method'),
            data: form.serialize()
        }).success(function (result) {
            window.location.reload();
        }).fail(function (xhr) {
            alert("Failed");
        });
        return false;
    };

    var substituteActionValues = function (event) {
        var button = $(event.relatedTarget);
        var form = $(this).find('form');
        var action = form.attr('action');
        var replacements = button.data('replacements');
        for (var key in replacements) {
            if (replacements.hasOwnProperty(key)) {
                action = action.replace(key, replacements[key]);
            }
        }
        form.data('action', action);
    };

    var init = function () {
        $('#add-match').on('show.bs.modal', function (event) {
            $(this).find('select[name="OpponentArchetype"]').val("");
            $(this).find('input[name="First"]').prop('checked', false);
            $(this).find('input[name="Win"]').prop('checked', false);
            $(this).find('.match-rewards').collapse('hide');
            $(this).find('input[name="Rewards.Copper"]').val("0");
            $(this).find('input[name="Rewards.Shards"]').val("0");
            $(this).find('input[name="Rewards.Packs"]').val("0");
        });
        $('#edit-match').on('show.bs.modal', function (event) {
            var row = $(event.relatedTarget).closest('tr');
            $(this).find('select[name="OpponentArchetype"]').val(row.find('td').eq(1).data('value'));
            $(this).find('input[name="First"]').prop('checked', row.data('first') === "True");
            var win = row.find('td').eq(3).html() === "True";
            $(this).find('input[name="Win"]').prop('checked', win);
            $(this).find('.match-rewards').collapse(win ? 'show' : 'hide');
            $(this).find('input[name="Rewards.Copper"]').val(parseInt(row.find('.reward-copper').eq(0).html(), 10));
            $(this).find('input[name="Rewards.Shards"]').val(parseInt(row.find('.reward-shards').eq(0).html(), 10));
            $(this).find('input[name="Rewards.Packs"]').val(parseInt(row.find('.reward-packs').eq(0).html(), 10));
        });

        $('form.submitModal').submit(submitModal);
        $('.action-sub').on('show.bs.modal', substituteActionValues);
    };

    init();
}(jQuery));