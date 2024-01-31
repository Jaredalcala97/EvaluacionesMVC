
const popupContainer = document.querySelector('.popup-container');
const popupBtn = document.querySelector('.popup-btn');

popupBtn.addEventListener('click', function () {
    popupContainer.classList.toggle('open');
});

