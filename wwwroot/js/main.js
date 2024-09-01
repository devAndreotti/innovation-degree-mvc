// Descer suave
$("#navbar a, .btn").on("click", function (event) {
    if (this.hash !== "") {
        event.preventDefault();
        const anchor = this.hash;
        $("html, body").animate(
            {
                scrollTop: $(anchor).offset().top - 200
            },
            300
        );
    }
});

// Opacidade
window.addEventListener("scroll", function () {
    if (window.scrollY > 150) {
        document.querySelector("#navbar").style.opacity = 0.9;
    } else {
        document.querySelector("#navbar").style.opacity = 1;
    }
});