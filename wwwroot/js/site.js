function initializeSwipeEvents() {
    document.addEventListener('swiped-left', function () {
        const nextTab = document.querySelector('.mud-tab.mud-tab-active').nextElementSibling;
        if (nextTab) {
            nextTab.click();
        }
    });

    document.addEventListener('swiped-right', function () {
        const prevTab = document.querySelector('.mud-tab.mud-tab-active').previousElementSibling;
        if (prevTab) {
            prevTab.click();
        }
    });
}

function initializeSwipeEvents() {
    // Initialize swipe events if necessary
}

function navigateWithAnimation(url) {
    const pageElement = document.querySelector('.page');
    pageElement.classList.add('slide-out-right');

    setTimeout(() => {
        pageElement.classList.remove('slide-out-right');
        window.Blazor.navigateTo(url);
        pageElement.classList.add('slide-in-right');
        setTimeout(() => {
            pageElement.classList.remove('slide-in-right');
        }, 500); // Match this duration with the CSS animation duration
    }, 500); // Match this duration with the CSS animation duration
}

    