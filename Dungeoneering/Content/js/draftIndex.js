/*global jQuery, bootbox*/
var chronicle = chronicle || {};
chronicle.drafting = chronicle.drafting || {};
chronicle.drafting.index = (function ($) {
    "use strict";

    var addMatch = function () {
        var form = $(this);
        form.closest('.modal').modal('toggle');
        $.post(form.attr('action'), form.serialize())
            .success(function (result) {
                alert("Saved");
                //TODO: Add match & rewards to table row
            }).fail(function (xhr) {
                alert("Failed");
            });
        return false;
    }

    var init = function () {
        $('#add-match form').submit(addMatch);
        $('#add-match').on('show.bs.modal', function (event) {
            var button = $(event.relatedTarget)
            var draftId = button.data('draftId')
            if (draftId) {
                $(this).find('input[name="draftId"]').val(draftId);
            }
        })
    };

    init();
}(jQuery));