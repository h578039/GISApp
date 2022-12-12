// Variabler
let imgBergen = document.getElementById("imgBergen");
let bilderamme = document.getElementById("bilderamme");
let i = 0;
let tabellImgs = ["/images/kartBergen.png", "/images/kartBergen2.png", "/images/kartBergen3.png", "/images/kartBergen4.png"];

function changePic() { //Bytter bildet
    i++;
    let logoPic = document.querySelector(".logo");
    logoPic.src = tabellImgs[i % tabellImgs.length]
}

imgBergen.onmousemove = function (evt) { //Setter negativ marg avhengig av hvor markøren er
    imgBergen.style.width = "1900px"; //Zoomer inn
    imgBergen.style.marginLeft = 2.46 * (-evt.clientX + bilderamme.offsetLeft) + "px";
    imgBergen.style.marginTop = 2.46 * (-evt.clientY + bilderamme.offsetTop) + "px";
};
imgBergen.onmouseout = function () { //Funksjonen zoomer ut
    imgBergen.style.width = "550px"; //Zoomer ut
    imgBergen.style.marginLeft = 0; //Setter margen tilbake til 0
    imgBergen.style.marginTop = 0; //Setter margen tilbake til 0. Når det ikke lenger skal zoomes
};
