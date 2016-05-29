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
                window.location.reload();
                //TODO: Add match & rewards to table row instead of refreshing the page
            }).fail(function (xhr) {
                alert("Failed");
            });
        return false;
    }

    var deleteDeck = function () {
        var form = $(this);
        form.closest('.modal').modal('toggle');
        $.ajax(form.attr('action'), {
            method: form.attr('method')
        }).success(function (result) {
            //TODO: Remove deck from table row
        }).fail(function (xhr) {
            alert("Failed");
        });
        return false;
    };

    var init = function () {
        $('#add-match form').submit(addMatch);
        $('#add-match').on('show.bs.modal', function (event) {
            var button = $(event.relatedTarget)
            var draftId = button.data('draftid')
            if (draftId) {
                $(this).find('input[name="draftId"]').val(draftId);
            }
        });
        $('#confirm-delete form').submit(deleteDeck);
        $('#confirm-delete').on('show.bs.modal', function (event) {
            var button = $(event.relatedTarget)
            var draftId = button.data('draftid')
            var action = $(this).find('form').attr('action');
            $(this).find('form').attr('action', action + "/" + draftId);
        });
        $(".toggle-icon-eye").on("click", function () {
            $(this).children("span").toggleClass("fa-eye fa-eye-slash");
            $(this).closest("tr").toggleClass("info");
        });
    };

    init();
}(jQuery));