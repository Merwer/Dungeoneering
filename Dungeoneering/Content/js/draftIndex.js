/*global jQuery, bootbox*/
var chronicle = chronicle || {};
chronicle.drafting = chronicle.drafting || {};
chronicle.drafting.index = (function ($) {
    "use strict";

    var confirmDelete = function () {
        bootbox.confirm("Are you sure you want to delete this deck?", function (response) {
            if (response) {
                // Trigger delete
            }
        });
    };

    var addMatch = function () {
        bootbox.
    };

    var init = function () {
        $('[data-modal="confirm-delete"]').click(confirmDelete);
        $('[data-modal="add-match"]').click(addMatch);
    };

    init();
}(jQuery));