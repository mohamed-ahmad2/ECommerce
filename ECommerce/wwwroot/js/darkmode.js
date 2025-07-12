$(document).ready(function () {
    const isDark = localStorage.getItem("dark-mode") === "true";
    if (isDark) {
        $("html").attr("data-bs-theme", "dark");
    }

    $("#toggleDark").click(function () {
        const currentlyDark = $("html").attr("data-bs-theme") === "dark";
        $("html").attr("data-bs-theme", currentlyDark ? "light" : "dark");
        localStorage.setItem("dark-mode", !currentlyDark);
    });
});
