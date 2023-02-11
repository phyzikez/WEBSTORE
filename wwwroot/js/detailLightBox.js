var slideIndex = 1;
showSlides(slideIndex);

function openModal() {
    document.getElementById("myModal").style.display = "block";
}

function closeModal() {
    document.getElementById("myModal").style.display = "none";
}

function plusSlides(n) {
    showSlides(slideIndex += n);
}

function currentSlide(n) {
    showSlides(slideIndex = n);
}

function showSlides(n) {
    var k;
    var slides = document.getElementsByClassName("mySlides");
    var dots = document.getElementsByClassName("demo");
    var captionText = document.getElementById("caption");
    if (n > slides.length) { slideIndex = 1 }
    if (n < 1) { slideIndex = slides.length }
    for (k = 0; k < slides.length; k++) {
        slides[k].style.display = "none";
    }
    for (k = 0; k < dots.length; k++) {
        dots[k].className = dots[k].className.replace(" active", "");
    }
    slides[slideIndex - 1].style.display = "block";
    dots[slideIndex - 1].className += " active";
    captionText.innerHTML = dots[slideIndex - 1].alt;

    var pf;
    var previewPhotos = document.getElementsByClassName("tcolumn");
    for (pf = 0; pf < previewPhotos.length; pf++) {
        previewPhotos[pf].style.width = ((100.0 / previewPhotos.length) + "%")
    }
}