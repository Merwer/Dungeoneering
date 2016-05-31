﻿/*global jQuery, bootbox*/
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

    var editMatch = function () {
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

    var deleteMatch = function () {
        var form = $(this);
        form.closest('.modal').modal('toggle');
        $.ajax(form.attr('action'), {
            method: form.attr('method')
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
        $.ajax(form.attr('action'), {
            method: form.attr('method')
        }).success(function (result) {
            window.location.reload();
            //TODO: Remove deck from table row
        }).fail(function (xhr) {
            alert("Failed");
        });
        return false;
    };

    var init = function () {
        $('#add-match form input[name="Win"]').on('change', function () {
            $('#add-match form .match-rewards').hide($(this).prop('checked'));
        });
        $('#add-match form').submit(addMatch);
        $('#add-match').on('show.bs.modal', function (event) {
            var button = $(event.relatedTarget);
            var draftId = button.data('draftid');
            var action = $(this).find('form').attr('action');
            $(this).find('input[name="draftId"]').val(draftId);
            $(this).find('select[name="OpponentArchetype"]').val("");
            $(this).find('input[name="First"]').prop('checked', false);
            $(this).find('input[name="Win"]').prop('checked', false);
            $(this).find('input[name="Rewards.Copper"]').val("0");
            $(this).find('input[name="Rewards.Shards"]').val("0");
            $(this).find('input[name="Rewards.Packs"]').val("0");
        });
        $('#edit-match form input[name="Win"]').on('change', function () {
            $('#edit-match form .match-rewards').hide($(this).prop('checked'));
        });
        $('#edit-match form').submit(editMatch);
        $('#edit-match').on('show.bs.modal', function (event) {
            var button = $(event.relatedTarget);
            var row = button.closest('tr');
            var draftId = button.data('draftid');
            var matchId = button.data('matchid');
            var action = $(this).find('form').attr('action');
            $(this).find('input[name="draftId"]').val(draftId);
            $(this).find('input[name="matchId"]').val(matchId);
            $(this).find('select[name="OpponentArchetype"]').val(row.find('td').eq(0).data('value'));

            //var selectbox = $(this).find('select[name="OpponentArchetype"]');
            //selectbox.find('option[text="' + row.find('td').eq(0).html() + '"]').prop('selected', 'selected');

            $(this).find('input[name="First"]').prop('checked', row.data('first') === "True");
            $(this).find('input[name="Win"]').prop('checked', row.find('td').eq(2).html() === "True");
            $(this).find('input[name="Rewards.Copper"]').val(parseInt(row.find('.reward-copper').eq(0).html(), 10));
            $(this).find('input[name="Rewards.Shards"]').val(parseInt(row.find('.reward-shards').eq(0).html(), 10));
            $(this).find('input[name="Rewards.Packs"]').val(parseInt(row.find('.reward-packs').eq(0).html(), 10));
            $(this).find('form').attr('action', action + "/" + draftId + "/" + matchId);
        });
        $('#delete-match form').submit(deleteMatch);
        $('#delete-match').on('show.bs.modal', function (event) {
            var button = $(event.relatedTarget);
            var draftId = button.data('draftid');
            var matchId = button.data('matchid');
            var action = $(this).find('form').attr('action');
            $(this).find('form').attr('action', action + "/" + draftId + "/" + matchId);
        });
        $('#delete-draft form').submit(deleteDeck);
        $('#delete-draft').on('show.bs.modal', function (event) {
            var button = $(event.relatedTarget);
            var draftId = button.data('draftid');
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