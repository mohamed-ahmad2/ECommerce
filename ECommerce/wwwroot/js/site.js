// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    // Product image hover logic
    $(".product-card").each(function () {
        const primary = $(this).find(".primary-img");
        const secondary = $(this).find(".secondary-img");

        if (secondary.length === 0) {
            primary.hover(
                function () { $(this).css("transform", "scale(1.05)"); },
                function () { $(this).css("transform", "scale(1)"); }
            );
        }
    });
});
