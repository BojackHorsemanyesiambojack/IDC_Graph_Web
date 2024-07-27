const navBar = document.getElementById('p-nav');
const mainPage = document.getElementById('pageWrite');

async function getGenProducts(){
    fetch('https://localhost:7183/Dashboard/Catalogue').then(
        response => response.text()
    ).then(data => writeProductOnMainPage(JSON.parse(data)))
}

function writeProductOnMainPage(data){
    mainPage.innerHTML = '';
    data.forEach(row => {
        const file = document.createElement('div');
        file.innerHTML = `<h1>${row['product_name']}</h1>
        <h2>Precio:${row['product_price']}</h2>
        <h3>Material: ${row['product_material']}<h3/>
        <h4>Tipo : ${row['product_type']}</h4>
        <h5>Existencias : ${row['product_stack']}</h5>`;
        mainPage.appendChild(file);
    })
}

function writeBuyHistorialOnMainPage(){

}

function searchProduct(){
    
}