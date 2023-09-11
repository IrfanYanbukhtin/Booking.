// Fill currencies map with data
var currenciesMap = new Map()
  .set("AZN", "Azerbaijan, New Manats")
  .set("USD", "U.S. dollar")
  .set("EUR", "Euro")
  .set("UAH", "Ukraine Hryvnia")
  .set("ARS", "Argentine peso")
  .set("AUD", "Australian dollar")
  .set("BHD", "Bahrain dinar")
  .set("BRL", "Brazilian real")
  .set("BGN", "Bulgarian lev")
  .set("CAD", "Canadian dollar")
  .set("XOF", "CFA Franc BCEAO")
  .set("CLP", "Chilean peso")
  .set("CNY", "Chinese yuan")
  .set("COP", "Colombian peso")
  .set("CZK", "Czech koruna")
  .set("DKK", "Danish krone")
  .set("EGP", "Egyptian pound")
  .set("AED", "U.A.E. dirham");

var currenciesModal = document.getElementById("currencyModal");
var value_sign = document.getElementById("val");

for (var currency of currenciesMap) {
  var buttonItem = document.createElement("button");
  buttonItem.classList.add(
    "btn-sm",
    "btn-dark",
    "text-start",
    "col-lg-3",
    "my-2",
  );
  currenciesModal.appendChild(buttonItem);

  var paragraphItem = document.createElement("p");
  paragraphItem.classList.add(
    "text-center",
  );
  paragraphItem.innerHTML = `${currency[1]}<br>${currency[0]}`;
  buttonItem.appendChild(paragraphItem);
};



//increse decrese number of Adults
document.getElementById("decreaseAdult").addEventListener("click",decreaseAdultValue)
document.getElementById("increaseAdult").addEventListener("click",increaseAdultValue)
let AdultStrength = document.getElementById('Adultnumber')
document.getElementById("adult").innerText = AdultStrength.value
function increaseAdultValue() {
  var value = parseInt(document.getElementById('Adultnumber').value, 10);
  value = isNaN(value) ? 0 : value;
  value++;
  document.getElementById('Adultnumber').value = value;
  document.getElementById("adult").innerText = value
}

function decreaseAdultValue() {
  var value = parseInt(document.getElementById('Adultnumber').value, 10);
  value = isNaN(value) ? 0 : value;
  value < 1 ? value = 1 : '';
  value--;
  document.getElementById('Adultnumber').value = value;
  document.getElementById("adult").innerText = value
}

//increse decrese number of child;

document.getElementById("decreaseChild").addEventListener("click",decreaseChildValue);
document.getElementById("increaseChild").addEventListener("click",increaseChildValue);

let ChildValue = document.getElementById("Childnumber")

document.getElementById("child").innerText = ChildValue.value;

function increaseChildValue(){
  var value = parseInt(ChildValue.value,10);
  value = isNaN(value)? 0 : value;
  value++;
  ChildValue.value = value;
  document.getElementById("child").innerText = value
}

function decreaseChildValue(){
   var value = parseInt(ChildValue.value,10);
   value = isNaN(value) ? 0 : value;
   value < 1 ? value = 1 : '';
   value--;
   ChildValue.value = value;
  document.getElementById("child").innerText = value
}

//increse decrese number of Rooms

document.getElementById("decreaseRoom").addEventListener("click",decreaseRoomValue)
document.getElementById("increaseRoom").addEventListener("click",increaseRoomValue)
let RoomValue = document.getElementById('Roomnumber')
document.getElementById("room").innerText = RoomValue.value
function increaseRoomValue() {
  var value = parseInt(document.getElementById('Roomnumber').value, 10);
  value = isNaN(value) ? 0 : value;
  value++;
  document.getElementById('Roomnumber').value = value;
  document.getElementById("rooms").innerText = value
}

function decreaseRoomValue() {
  var value = parseInt(document.getElementById('Roomnumber').value, 10);
  value = isNaN(value) ? 0 : value;
  value < 1 ? value = 1 : '';
  value--;
  document.getElementById('Roomnumber').value = value;
  document.getElementById("room").innerText = value
}

//popup of number of persons
let popup = document.getElementById("skPersonDiv")
document.getElementById("skPerson").addEventListener("click",openpopup)

function openpopup(){
  popup.classList.add("open_popup")
}
document.querySelector("#cross").addEventListener("click",closepopup)

function closepopup(){
  popup.classList.remove("open_popup")
}
//popup sreach results;
let searchQuery = document.getElementById("query")
let searchValuebak = document.getElementById("SearchOptionBaku").value;
let searchValueQab = document.getElementById("SearchOptionQabala").value;
let searchValueQuba = document.getElementById("SearchOptionQuba").value;
let searchValueSheki = document.getElementById("SearchOptionShek").value;
let searchpopup = document.getElementById("searchpopupdiv")
document.getElementById("searchCity").addEventListener("click",opensearchpopup);

function opensearchpopup(){
  searchpopup.classList.add("openSearch_popup")
}
document.querySelector(".sgnCityBak").onclick = () => {
  searchQuery.value = searchValuebak
  console.log(searchValuebak)
  searchpopup.classList.remove("openSearch_popup")
}
document.querySelector(".sgnCityDivQab").onclick = () => {
  searchQuery.value = searchValueQab
  console.log(searchValueQab)
  searchpopup.classList.remove("openSearch_popup")
}
document.querySelector(".sgnCityDivQuba").onclick = () => {
  searchQuery.value = searchValueQuba
  console.log(searchValueQuba)
  searchpopup.classList.remove("openSearch_popup")
}
document.querySelector(".sgnCityDivShek").onclick = () => {
  searchQuery.value = searchValueShek
  console.log(searchValueShek)
  searchpopup.classList.remove("openSearch_popup")
}

//search query to local storage


document.getElementById("searchBtn").addEventListener("click",()=>{
  searchResult()
})

const searchResult = () => {
  let query = document.getElementById("query").value;
  let chekin = document.getElementById("skCheckin").value;
  let chekout = document.getElementById("skCheckout").value;
  let adult = document.getElementById("adult").innerText;
  let child = document.getElementById("child").innerText;
  let room = document.getElementById("room").innerText;
  let searchObj = {
    query,
    chekin,
    chekout,
    adult,
    child,
  }
  localStorage.setItem("query",JSON.stringify(searchObj));
  console.log(query)

  if(query == "Baku"){
    console.log("b");
    window.location.href = "index.html"
  }else if(query == "Quba"){
    console.log("q");
    window.location.href = "index.html"
  }else if(query == "Sheki"){
    console.log("s");
    window.location.href = "index.html"
  }else if(query == "Qabala"){
    console.log("qa");
    window.location.href = "index.html"
  }else{
    alert("Sorry, No results found")
  }

  document.getElementById("query").value = null;
  document.getElementById("skCheckin").value = null;
  document.getElementById("skCheckout").value = null;
  document.getElementById("adult").innerText = null;
  document.getElementById("child").innerText = null;
  document.getElementById("room").innerText = null;
}

//////////////////////////////Explore carousel//////////////////////////////////////////

let count1 = 0;
document.querySelector("#ltexarrow").onclick = () => {
  console.log("clicked");

  if (count1 == 0) {
    return;
  }
  count1--;
  let val = count1 * 60;
  document.querySelector("#explore_container").style.transform = `translateX(-${val}px)`;
};

document.querySelector("#rtexarrow").onclick = () => {
  if (count1 > 4) {
    return;
  }
  count1++;
  let val = count1 * 68;
  document.querySelector("#explore_container").style.transform = `translateX(-${val}px)`;
};

////////////////////////////////////////Browse by property type//////////////////////////////////////////////////

let count2 = 0;
document.querySelector("#ltbrarrow").onclick = () => {
  console.log("clicked");

  if (count2 == 0) {
    return;
  }
  count2--;
  let val = count2 * 370;
  document.querySelector("#browse_container").style.transform = `translateX(-${val}px)`;
};

document.querySelector("#rtbrarrow").onclick = () => {
  if (count2 > 4) {
    return;
  }
  count2++;
  let val = count2 * 395;
  document.querySelector("#browse_container").style.transform = `translateX(-${val}px)`;
};

///////////////////////////////////////////////Quick trip////////////////////////////////////////////////////

let e1 = document.getElementById("city");
let e2 = document.getElementById("romance");
let e3 = document.getElementById("beach");
let e4 = document.getElementById("outdoors");
let e5 = document.getElementById("relax");

let opt1 = document.getElementById("des_opt1")
let opt2 = document.getElementById("des_opt2")
let opt3 = document.getElementById("des_opt3")
let opt4 = document.getElementById("des_opt4")
let opt5 = document.getElementById("des_opt5")


opt1.addEventListener("click", function(){
  console.log("clicked1");
  e1.style.display = "inline-flex";
  e2.style.display = "none";
  e3.style.display = "none";
  e4.style.display = "none";
  e5.style.display = "none";

  opt1.style.color = "#0071c2";
  opt1.style.background = "#ecf4f8";
  opt1.style.border = "1px solid #0071c2";

  opt2.style.color = "#262626";
  opt2.style.background = "none";
  opt2.style.border = "none";

  opt3.style.color = "#262626";
  opt3.style.background = "none";
  opt3.style.border = "none";

  opt4.style.color = "#262626";
  opt4.style.background = "none";
  opt4.style.border = "none";

  opt5.style.color = "#262626";
  opt5.style.background = "none";
  opt5.style.border = "none";
})
opt2.addEventListener("click", function(){
  console.log("clicked2");
  e1.style.display = "none";
  e3.style.display = "none";
  e2.style.display = "inline-flex"
  e4.style.display = "none"
  e5.style.display = "none";
  
  opt2.style.color = "#0071c2";
  opt2.style.background = "#ecf4f8";
  opt2.style.border = "1px solid #0071c2";

  opt1.style.color = "#262626";
  opt1.style.background = "none";
  opt1.style.border = "none";

  opt3.style.color = "#262626";
  opt3.style.background = "none";
  opt3.style.border = "none";

  opt4.style.color = "#262626";
  opt4.style.background = "none";
  opt4.style.border = "none";

  opt5.style.color = "#262626";
  opt5.style.background = "none";
  opt5.style.border = "none";
})
opt3.addEventListener("click", function(){
  console.log("clicked3");
  e1.style.display = "none";
  e3.style.display = "inline-flex";
  e2.style.display = "none";
  e4.style.display = "none";
  e5.style.display = "none";

  opt3.style.color = "#0071c2";
  opt3.style.background = "#ecf4f8";
  opt3.style.border = "1px solid #0071c2";

  opt1.style.color = "#262626";
  opt1.style.background = "none";
  opt1.style.border = "none";

  opt2.style.color = "#262626";
  opt2.style.background = "none";
  opt2.style.border = "none";

  opt4.style.color = "#262626";
  opt4.style.background = "none";
  opt4.style.border = "none";

  opt5.style.color = "#262626";
  opt5.style.background = "none";
  opt5.style.border = "none";
})
opt4.addEventListener("click", function(){
  console.log("clicked4");
  e1.style.display = "none";
  e3.style.display = "none";
  e2.style.display = "none";
  e4.style.display = "inline-flex";
  e5.style.display = "none";

  opt4.style.color = "#0071c2";
  opt4.style.background = "#ecf4f8";
  opt4.style.border = "1px solid #0071c2";

  opt1.style.color = "#262626";
  opt1.style.background = "none";
  opt1.style.border = "none";

  opt2.style.color = "#262626";
  opt2.style.background = "none";
  opt2.style.border = "none";

  opt3.style.color = "#262626";
  opt3.style.background = "none";
  opt3.style.border = "none";

  opt5.style.color = "#262626";
  opt5.style.background = "none";
  opt5.style.border = "none";
})
opt5.addEventListener("click", function(){
  console.log("clicked5");
  e1.style.display = "none";
  e3.style.display = "none";
  e2.style.display = "none";
  e4.style.display = "none";
  e5.style.display = "inline-flex";

  opt5.style.color = "#0071c2";
  opt5.style.background = "#ecf4f8";
  opt5.style.border = "1px solid #0071c2";

  opt1.style.color = "#262626";
  opt1.style.background = "none";
  opt1.style.border = "none";

  opt2.style.color = "#262626";
  opt2.style.background = "none";
  opt2.style.border = "none";

  opt3.style.color = "#262626";
  opt3.style.background = "none";
  opt3.style.border = "none";

  opt4.style.color = "#262626";
  opt4.style.background = "none";
  opt4.style.border = "none";
})

////////////////////////////////////////////////Get inspiration for your next trip///////////////////////////////////////////////////

let count3 = 0;
document.querySelector("#ltinsarrow").onclick = () => {
  console.log("clicked");

  if (count3 == 0) {
    return;
  }
  count3--;
  let val = count3 * 130;
  document.querySelector("#inspiration_carousel_container").style.transform = `translateX(-${val}px)`;
};

document.querySelector("#rtinsarrow").onclick = () => {
  if (count3 > 4) {
    return;
  }
  count3++;
  let val = count3 * 165;
  document.querySelector("#inspiration_carousel_container").style.transform = `translateX(-${val}px)`;
};


///////////////////////////Stay at our top unique properties///////////////////////////////////////////////////////

let count4 = 0;
document.querySelector("#ltuparrow").onclick = () => {
  console.log("clicked");

  if (count4 == 0) {
    return;
  }
  count4--;
  let val = count4 * 550;
  document.querySelector("#unique_properties_container").style.transform = `translateX(-${val}px)`;
};

document.querySelector("#rtuparrow").onclick = () => {
  if (count4 > 4) {
    return;
  }
  count4++;
  let val = count4 * 730;
  document.querySelector("#unique_properties_container").style.transform = `translateX(-${val}px)`;
};

////////////////////////////////////////////Homes guests love///////////////////////////////////////////////////////

let count5 = 0;
document.querySelector("#lthgarrow").onclick = () => {
  console.log("clicked");

  if (count5 == 0) {
    return;
  }
  count5--;
  let val = count5 * 300;
  document.querySelector("#home_guests_container").style.transform = `translateX(-${val}px)`;
};

document.querySelector("#rthgarrow").onclick = () => {
  if (count5 > 4) {
    return;
  }
  count5++;
  let val = count5 * 390;
  document.querySelector("#home_guests_container").style.transform = `translateX(-${val}px)`;
};


///////////////////////////////////////////////Destinations we love////////////////////////////////////////////////////
let d1 = document.getElementById("destinations_categorie1");
let d2 = document.getElementById("destinations_categorie2");
let d3 = document.getElementById("destinations_categorie3");

let cate1 = document.getElementById("des_cate1")
let cate2 = document.getElementById("des_cate2")
let cate3 = document.getElementById("des_cate3")

cate1.addEventListener("click", function(){
  console.log("clicked1");
  d1.style.display = "inline-flex";
  d3.style.display = "none";
  d2.style.display = "none";

  cate1.style.color = "#0071c2";
  cate1.style.background = "#ecf4f8";
  cate1.style.border = "1px solid #0071c2";

  cate2.style.color = "#262626";
  cate2.style.background = "none";
  cate2.style.border = "none";

  cate3.style.color = "#262626";
  cate3.style.background = "none";
  cate3.style.border = "none";
})
cate2.addEventListener("click", function(){
  console.log("clicked2");
  d1.style.display = "none";
  d3.style.display = "none";
  d2.style.display = "inline-flex";
  
  cate2.style.color = "#0071c2";
  cate2.style.background = "#ecf4f8";
  cate2.style.border = "1px solid #0071c2";

  cate1.style.color = "#262626";
  cate1.style.background = "none";
  cate1.style.border = "none";

  cate3.style.color = "#262626";
  cate3.style.background = "none";
  cate3.style.border = "none";
})
cate3.addEventListener("click", function(){
  console.log("clicked3");
  d1.style.display = "none";
  d3.style.display = "inline-flex"
  d2.style.display = "none";

  cate3.style.color = "#0071c2";
  cate3.style.background = "#ecf4f8";
  cate3.style.border = "1px solid #0071c2";

  cate1.style.color = "#262626";
  cate1.style.background = "none";
  cate1.style.border = "none";

  cate2.style.color = "#262626";
  cate2.style.background = "none";
  cate2.style.border = "none";
});

// Change language
let langs = document.querySelectorAll('.nav-bar .lang a')

for(let lang of langs) {
    lang.onclick = function(e) {
        e.preventDefault()
        
        for(let lang of langs) {
            this.classList.add('d-none')
            lang.classList.remove('d-none')

            if(lang.innerHTML == 'RU') {
                this.classList.add('d-none')
            }
        }
    }
}




