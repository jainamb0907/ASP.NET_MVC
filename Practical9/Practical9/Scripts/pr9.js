document.getElementById("SimpleText").onclick = function () {
    document.getElementById("output").style.display = 'block';
}

document.getElementById("BoldText").onclick = function () {
    document.getElementById("output").style.fontWeight = "900";
    document.getElementById("output").style.display = 'block';
}

document.getElementById("ItalicText").onclick = function () {
    document.getElementById("output").style.fontStyle = "Italic";
    document.getElementById("output").style.display = 'block';
}

document.getElementById("UnderlineText").onclick = function () {
    document.getElementById("output").style.textDecoration = "underline";
    document.getElementById("output").style.display = 'block';
}

document.getElementById("DefaultText").onclick = function () {
    document.getElementById("output").style.all = "initial";
    document.getElementById("output").style.display = 'block';
}