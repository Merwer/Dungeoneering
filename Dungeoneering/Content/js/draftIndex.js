/*global jQuery, bootbox*/
var chronicle = chronicle || {};
chronicle.drafting = chronicle.drafting || {};
chronicle.drafting.index = (function ($) {
    "use strict";

    var addMatch = function () {
        var form = $(this);
        form.closest('.modal').modal('toggle');
        $.ajax(form.data('action'), {
            method: form.attr('method'),
            data: form.serialize()
        }).success(function (result) {
            window.location.reload();
            //TODO: Add match & rewards to table row instead of refreshing the page
        }).fail(function (xhr) {
            alert("Failed");
        });
        return false;
    }

    var editMatch = function () {
        var form = $(this);
        form.closest('.modal').modal('toggle');
        $.ajax(form.data('action'), {
            method: form.attr('method'),
            data: form.serialize()
        }).success(function (result) {
            window.location.reload();
            //TODO: Add match & rewards to table row instead of refreshing the page
        }).fail(function (xhr) {
            alert("Failed");
        });
        return false;
    }

    var deleteMatch = function () {
        var form = $(this);
        form.closest('.modal').modal('toggle');
        $.ajax(form.data('action'), {
            method: form.attr('method'),
            data: form.serialize()
        }).success(function (result) {
            window.location.reload();
            //TODO: Remove deck from table row
        }).fail(function (xhr) {
            alert("Failed");
        });
        return false;
    };

    var deleteDeck = function () {
        var form = $(this);
        form.closest('.modal').modal('toggle');
        $.ajax(form.data('action'), {
            method: form.attr('method'),
            data: form.serialize()
        }).success(function (result) {
            window.location.reload();
            //TODO: Remove deck from table row
        }).fail(function (xhr) {
            alert("Failed");
        });
        return false;
    };

    var abandonDeck = function () {
        var form = $(this);
        form.closest('.modal').modal('toggle');
        $.ajax(form.data('action'), {
            method: form.attr('method'),
            data: form.serialize()
        }).success(function (result) {
            window.location.reload();
            //TODO: Remove deck from table row
        }).fail(function (xhr) {
            alert("Failed");
        });
        return false;
    };

    var restoreDeck = function () {
        var form = $(this);
        form.closest('.modal').modal('toggle');
        $.ajax(form.data('action'), {
            method: form.attr('method'),
            data: form.serialize()
        }).success(function (result) {
            window.location.reload();
            //TODO: Remove deck from table row
        }).fail(function (xhr) {
            alert("Failed");
        });
        return false;
    };

    var init = function () {
        $('#add-match form').submit(addMatch);
        $('#add-match').on('show.bs.modal', function (event) {
            var button = $(event.relatedTarget);
            var draftId = button.data('draftid');
            var action = $(this).find('form').attr('action').replace('-1', draftId);
            $(this).find('select[name="OpponentArchetype"]').val("");
            $(this).find('input[name="First"]').prop('checked', false);
            $(this).find('input[name="Win"]').prop('checked', false);
            $(this).find('.match-rewards').collapse('hide');
            $(this).find('input[name="Rewards.Copper"]').val("0");
            $(this).find('input[name="Rewards.Shards"]').val("0");
            $(this).find('input[name="Rewards.Packs"]').val("0");
            $(this).find('form').data('action', action);
        });
        $('#edit-match form').submit(editMatch);
        $('#edit-match').on('show.bs.modal', function (event) {
            var button = $(event.relatedTarget);
            var row = button.closest('tr');
            var draftId = button.data('draftid');
            var matchId = button.data('matchid');
            var action = $(this).find('form').attr('action').replace('-1', draftId).replace('-2', matchId);
            $(this).find('select[name="OpponentArchetype"]').val(row.find('td').eq(1).data('value'));
            $(this).find('input[name="First"]').prop('checked', row.data('first') === "True");
            var win = row.find('td').eq(3).html() === "True";
            $(this).find('input[name="Win"]').prop('checked', win);
            $(this).find('.match-rewards').collapse(win ? 'show' : 'hide');
            $(this).find('input[name="Rewards.Copper"]').val(parseInt(row.find('.reward-copper').eq(0).html(), 10));
            $(this).find('input[name="Rewards.Shards"]').val(parseInt(row.find('.reward-shards').eq(0).html(), 10));
            $(this).find('input[name="Rewards.Packs"]').val(parseInt(row.find('.reward-packs').eq(0).html(), 10));
            $(this).find('form').data('action', action);
        });
        $('#delete-match form').submit(deleteMatch);
        $('#delete-match').on('show.bs.modal', function (event) {
            var button = $(event.relatedTarget);
            var draftId = button.data('draftid');
            var matchId = button.data('matchid');
            var action = $(this).find('form').attr('action').replace('-1', draftId).replace('-2', matchId);
            $(this).find('form').data('action', action);
        });
        $('#delete-draft form').submit(deleteDeck);
        $('#delete-draft').on('show.bs.modal', function (event) {
            var button = $(event.relatedTarget);
            var draftId = button.data('draftid');
            var action = $(this).find('form').attr('action');
            $(this).find('form').data('action', action + "/" + draftId);
        });
        $('#abandon-draft form').submit(abandonDeck);
        $('#abandon-draft').on('show.bs.modal', function (event) {
            var button = $(event.relatedTarget);
            var draftId = button.data('draftid');
            var action = $(this).find('form').attr('action');
            $(this).find('form').data('action', action + "/" + draftId);
        });
        $('#restore-draft form').submit(restoreDeck);
        $('#restore-draft').on('show.bs.modal', function (event) {
            var button = $(event.relatedTarget);
            var draftId = button.data('draftid');
            var action = $(this).find('form').attr('action');
            $(this).find('form').data('action', action + "/" + draftId);
        });
        $(".toggle-icon-eye").on("click", function () {
            $(this).toggleClass("fa-eye fa-eye-slash");
            $(this).closest("tr").toggleClass("info");
        });
    };

    init();
}(jQuery));