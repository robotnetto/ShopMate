//function initializeSwipeEvents() {
//    document.addEventListener('swiped-left', function () {
//        const nextTab = document.querySelector('.mud-tab.mud-tab-active').nextElementSibling;
//        if (nextTab) {
//            nextTab.click();
//        }
//    });

//    document.addEventListener('swiped-right', function () {
//        const prevTab = document.querySelector('.mud-tab.mud-tab-active').previousElementSibling;
//        if (prevTab) {
//            prevTab.click();
//        }
//    });
//}

//function initializeSwipeEvents() {
//    // Initialize swipe events if necessary
//}

//function closeDrawers() {
//    const drawers = document.querySelectorAll('.mud-drawer');
//    drawers.forEach(drawer => {
//        drawer.classList.remove('mud-drawer--open');
//    });
//}

//function navigateWithAnimation(url) {
//    closeDrawers();

//    // Wait for a short duration to ensure drawers are closed
//    setTimeout(() => {
//        // Perform navigation
//        window.Blazor.navigateTo(url);

//        // Wait for the navigation to complete and the new page content to be rendered
//        setTimeout(() => {
//            const pageElement = document.querySelector('.page');

//            // Remove any previous slide-in class
//            pageElement.classList.remove('slide-in-right');

//            // Trigger reflow to restart the animation
//            void pageElement.offsetWidth;

//            // Add the slide-in animation class
//            pageElement.classList.add('slide-in-right');
//        }, 50); // Short delay to allow Blazor to update the DOM
//    }, 200); // Allow some time for drawers to close
//}

