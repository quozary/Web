// Плавная анимация при прокрутке
document.addEventListener("DOMContentLoaded", () => {
    const scrollToTopBtn = document.querySelector("#scrollToTop");
    window.addEventListener("scroll", () => {
        if (window.scrollY > 200) {
            scrollToTopBtn.style.display = "block";
        } else {
            scrollToTopBtn.style.display = "none";
        }
    });

    scrollToTopBtn.addEventListener("click", () => {
        window.scrollTo({ top: 0, behavior: "smooth" });
    });
});

// Анимация элементов каталога при появлении
const catalogItems = document.querySelectorAll(".catalog-item");
catalogItems.forEach((item, index) => {
    setTimeout(() => {
        item.style.opacity = "1";
        item.style.transform = "translateY(0)";
    }, index * 100);
});
