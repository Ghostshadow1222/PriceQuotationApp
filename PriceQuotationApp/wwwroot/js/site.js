// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Theme Toggle Functionality
document.addEventListener('DOMContentLoaded', function() {
    const themeToggle = document.getElementById('theme-toggle');
    const themeIcon = document.getElementById('theme-icon');
    const body = document.body;
    
    // Check for saved theme preference or default to light mode
    const savedTheme = localStorage.getItem('theme') || 'light';
    setTheme(savedTheme);
    
    // Theme toggle event listener
    themeToggle.addEventListener('click', function() {
        const currentTheme = body.getAttribute('data-theme');
        const newTheme = currentTheme === 'dark' ? 'light' : 'dark';
        setTheme(newTheme);
        localStorage.setItem('theme', newTheme);
    });
    
    function setTheme(theme) {
        if (theme === 'dark') {
            body.setAttribute('data-theme', 'dark');
            body.classList.remove('light-mode');
            body.classList.add('dark-mode');
            themeIcon.textContent = '☀️';
            themeToggle.setAttribute('title', 'Switch to light mode');
        } else {
            body.setAttribute('data-theme', 'light');
            body.classList.remove('dark-mode');
            body.classList.add('light-mode');
            themeIcon.textContent = '🌙';
            themeToggle.setAttribute('title', 'Switch to dark mode');
        }
    }
});

// Add smooth scroll behavior for better UX
document.documentElement.style.scrollBehavior = 'smooth';
