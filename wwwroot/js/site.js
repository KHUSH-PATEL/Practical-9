function printText() {
    let label = document.getElementById("text");
    label.innerHTML = "Hello World";
}

function makeBold() {
    let label = document.getElementById("text");
    label.style.fontWeight = "bold";
}

function makeItalic() {
    let label = document.getElementById("text");
    label.style.fontStyle = "italic";
}

function makeUnderline() {
    let label = document.getElementById("text");
    label.style.textDecoration = "underline";
}

function reset() {
    let label = document.getElementById("text");
    label.innerHTML = "";
    label.style.fontWeight = "normal";
    label.style.fontStyle = "normal";
    label.style.textDecoration = "none";
}
