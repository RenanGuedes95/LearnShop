/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        './**/*.razor',
        './**/*.html',
        './**/*.cshtml',
        './wwwroot/**/*.html'
    ],
    theme: {
        extend: {
            colors: {
                primary: '#151773',
                secondary: '#4f52d9',
                highlight: "#76be11"
            }
        },
    },
    plugins: [],
}
