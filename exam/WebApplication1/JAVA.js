var Main = 0;
function Sum(price) {
    Main = parseInt(localStorage.getItem('Main') || 0);
    Main += price;
    localStorage.setItem('Main',Main);
}

var Tatle;
function show() {
    Tatle = document.getElementById("tn");
    Tatle.innerHTML = table;
}

function upDataTotle() {
    var total = parseInt(localStorage.getItem('Main')||0);
    document.getElementById("pm").innerHTML = total + "元";
}
window.addEventListener("load", show);
window.addEventListener("load", upDataTotle);

function resetAndClose() {
    localStorage.setItem('Main', 0);
    window.close();
}