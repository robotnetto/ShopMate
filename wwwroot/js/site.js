function navigateWithAnimation(url) {
    const pageElement = document.getElementById('mainContent');

    if (pageElement) {
        // Remove any previous slide-in class
        pageElement.classList.remove('slide-in-right');

        // Trigger reflow to restart the animation
        void pageElement.offsetWidth;

        // Add the slide-in animation class
        pageElement.classList.add('slide-in-right');

        // Wait for the animation to complete before navigating
        setTimeout(() => {
            window.Blazor.navigateTo(url);
        }, 500); // Match this duration with the CSS animation duration
    } else {
        // If the element is not found, navigate immediately
        window.Blazor.navigateTo(url);
    }
}
