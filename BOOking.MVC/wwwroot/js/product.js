

window.addEventListener("load", () => {
    render(product_data)
});


//-------Product Display function----------//
function render(data){
let add = document.querySelector(".product")
// add.innerHTML = "";

let new_arr = data.map((item)=>{

return `
    <div class="product-box">
        <div class="image">
            <img src=${item.avatar} alt="">
        </div>
        <div class="mid">
            <h3>${item.name}</h3>
            <p><span class="material-symbols-outlined">
                my_location
                </span>${item.distance} M from Center</p>
            <p>${item.details}</p>
        </div>
        <div class="right">
            <div class="review">
                <h3>${item.review}</h3>
                <div><h4>${item.rating}</h4></div>
            </div>
            <p>1 night, 2 adults</p>
            <h2>Rs.${item.price}</h2>
            <p>+Rs.${item.tax} taxes and charges</p>
            <button>See availablility</button>
        </div>
    </div>
`
})

//console.log(new_arr)

add.innerHTML = new_arr.join(" ")
} ;

//-------Sort function------------//

document.querySelector(".sort-box").addEventListener("change",sort)

function sort(){
    let print = document.querySelector(".sort-box").value;
    //console.log(print)
    if(print=="P_LTH"){
        product_data.sort((a,b)=>a.price-b.price);
    }else if(print=="P_HTL"){
        product_data.sort((a,b)=>b.price-a.price);
    }else if(print=="R_LTH"){
        product_data.sort((a,b)=>a.rating-b.rating);
    }else if(print=="R_HTL"){
        product_data.sort((a,b)=>b.rating-a.rating);
    }else if(print=="D_LTH"){
        product_data.sort((a,b)=>a.distance-b.distance);
    }
    render(product_data)

}

//------------Product Filter function----------//

let boxs = document.querySelectorAll(".box")

for(let box of boxs){
    box.addEventListener("click",(e)=>{
        //console.log(e)
        let review_value = e.target.value;
        let good = e.path[1].children[5].checked;
        let vGood = e.path[1].children[8].checked;
        let excellent = e.path[1].children[11].checked;
        let wonder = e.path[1].children[14].checked;
        let a_7 = e.path[1].children[19].checked;
        let a_8 = e.path[1].children[22].checked;
        let a_9 = e.path[1].children[25].checked;
        let p_4000 = e.path[1].children[30].checked;
        let p_8000 = e.path[1].children[33].checked;
        let p_10000 = e.path[1].children[36].checked;
        let p_a_10 = e.path[1].children[39].checked;
        //console.log(e.path[1].children[5].checked)
        if(review_value=="Good" && good==true){
             Good = product_data.filter((item)=>{
                return item.review=="Good"
            })
            //console.log(Good)
            render(Good)

            //----filter sort function------//

            document.querySelector(".sort-box").addEventListener("change",sort)

            function sort(){
                let print = document.querySelector(".sort-box").value;
                //console.log(print)
                if(print=="P_LTH"){
                    Good.sort((a,b)=>a.price-b.price);
                }else if(print=="P_HTL"){
                    Good.sort((a,b)=>b.price-a.price);
                }else if(print=="R_LTH"){
                    Good.sort((a,b)=>a.rating-b.rating);
                }else if(print=="R_HTL"){
                    Good.sort((a,b)=>b.rating-a.rating);
                }else if(print=="D_LTH"){
                    Good.sort((a,b)=>a.distance-b.distance);
                }
                render(Good)

            }

        }else if(review_value=="Very Good" && vGood==true){
             veryGood = product_data.filter((item)=>{
                return item.review=="Very Good"
            })
            render(veryGood)

            //----filter sort function------//

            document.querySelector(".sort-box").addEventListener("change",sort)

            function sort(){
                let print = document.querySelector(".sort-box").value;
                //console.log(print)
                if(print=="P_LTH"){
                    veryGood.sort((a,b)=>a.price-b.price);
                }else if(print=="P_HTL"){
                    veryGood.sort((a,b)=>b.price-a.price);
                }else if(print=="R_LTH"){
                    veryGood.sort((a,b)=>a.rating-b.rating);
                }else if(print=="R_HTL"){
                    veryGood.sort((a,b)=>b.rating-a.rating);
                }else if(print=="D_LTH"){
                    veryGood.sort((a,b)=>a.distance-b.distance);
                }
                render(veryGood)

            }

        }else if(review_value=="Excellent" && excellent==true){
             Excellent = product_data.filter((item)=>{
                return item.review=="Excellent"
            })
            render(Excellent)

            //----filter sort function------//

            document.querySelector(".sort-box").addEventListener("change",sort)

            function sort(){
                let print = document.querySelector(".sort-box").value;
                //console.log(print)
                if(print=="P_LTH"){
                    Excellent.sort((a,b)=>a.price-b.price);
                }else if(print=="P_HTL"){
                    Excellent.sort((a,b)=>b.price-a.price);
                }else if(print=="R_LTH"){
                    Excellent.sort((a,b)=>a.rating-b.rating);
                }else if(print=="R_HTL"){
                    Excellent.sort((a,b)=>b.rating-a.rating);
                }else if(print=="D_LTH"){
                    Excellent.sort((a,b)=>a.distance-b.distance);
                }
                render(Excellent)

            }

        }else if(review_value=="Wonderful" && wonder==true){
             Wonderful = product_data.filter((item)=>{
                return item.review=="Wonderful"
            })
            render(Wonderful)

            //----filter sort function------//

            document.querySelector(".sort-box").addEventListener("change",sort)

            function sort(){
                let print = document.querySelector(".sort-box").value;
                //console.log(print)
                if(print=="P_LTH"){
                    Wonderful.sort((a,b)=>a.price-b.price);
                }else if(print=="P_HTL"){
                    Wonderful.sort((a,b)=>b.price-a.price);
                }else if(print=="R_LTH"){
                    Wonderful.sort((a,b)=>a.rating-b.rating);
                }else if(print=="R_HTL"){
                    Wonderful.sort((a,b)=>b.rating-a.rating);
                }else if(print=="D_LTH"){
                    Wonderful.sort((a,b)=>a.distance-b.distance);
                }
                render(Wonderful)

            }

        }else if(review_value==7 && a_7==true){
             above_7 = product_data.filter((item)=>{
                return item.rating>7
            })
            render(above_7)

            //----filter sort function------//

            document.querySelector(".sort-box").addEventListener("change",sort)

            function sort(){
                let print = document.querySelector(".sort-box").value;
                //console.log(print)
                if(print=="P_LTH"){
                    above_7.sort((a,b)=>a.price-b.price);
                }else if(print=="P_HTL"){
                    above_7.sort((a,b)=>b.price-a.price);
                }else if(print=="R_LTH"){
                    above_7.sort((a,b)=>a.rating-b.rating);
                }else if(print=="R_HTL"){
                    above_7.sort((a,b)=>b.rating-a.rating);
                }else if(print=="D_LTH"){
                    above_7.sort((a,b)=>a.distance-b.distance);
                }
                render(above_7)

            }

        }else if(review_value==8 && a_8==true){
             above_8 = product_data.filter((item)=>{
                return item.rating>8
            })
            render(above_8)

            //----filter sort function------//

            document.querySelector(".sort-box").addEventListener("change",sort)

            function sort(){
                let print = document.querySelector(".sort-box").value;
                //console.log(print)
                if(print=="P_LTH"){
                    above_8.sort((a,b)=>a.price-b.price);
                }else if(print=="P_HTL"){
                    above_8.sort((a,b)=>b.price-a.price);
                }else if(print=="R_LTH"){
                    above_8.sort((a,b)=>a.rating-b.rating);
                }else if(print=="R_HTL"){
                    above_8.sort((a,b)=>b.rating-a.rating);
                }else if(print=="D_LTH"){
                    above_8.sort((a,b)=>a.distance-b.distance);
                }
                render(above_8)

            }

        }else if(review_value==9 && a_9==true){
             above_9 = product_data.filter((item)=>{
                return item.rating>9
            })
            render(above_9)

            //----filter sort function------//

            document.querySelector(".sort-box").addEventListener("change",sort)

            function sort(){
                let print = document.querySelector(".sort-box").value;
                //console.log(print)
                if(print=="P_LTH"){
                    above_9.sort((a,b)=>a.price-b.price);
                }else if(print=="P_HTL"){
                    above_9.sort((a,b)=>b.price-a.price);
                }else if(print=="R_LTH"){
                    above_9.sort((a,b)=>a.rating-b.rating);
                }else if(print=="R_HTL"){
                    above_9.sort((a,b)=>b.rating-a.rating);
                }else if(print=="D_LTH"){
                    above_9.sort((a,b)=>a.distance-b.distance);
                }
                render(above_9)

            }

        }else if(review_value==4000 && p_4000==true){
            below_4000 = product_data.filter((item)=>{
                return item.price<4000
            })
            render(below_4000)

            //----filter sort function------//

            document.querySelector(".sort-box").addEventListener("change",sort)

            function sort(){
                let print = document.querySelector(".sort-box").value;
                //console.log(print)
                if(print=="P_LTH"){
                    below_4000.sort((a,b)=>a.price-b.price);
                }else if(print=="P_HTL"){
                    below_4000.sort((a,b)=>b.price-a.price);
                }else if(print=="R_LTH"){
                    below_4000.sort((a,b)=>a.rating-b.rating);
                }else if(print=="R_HTL"){
                    below_4000.sort((a,b)=>b.rating-a.rating);
                }else if(print=="D_LTH"){
                    below_4000.sort((a,b)=>a.distance-b.distance);
                }
                render(below_4000)

            }

        }else if(review_value==8000 && p_8000==true){
             below_8000 = product_data.filter((item)=>{
                return item.price>4000 && item.price<8000
            })
            render(below_8000)

            //----filter sort function------//

            document.querySelector(".sort-box").addEventListener("change",sort)

            function sort(){
                let print = document.querySelector(".sort-box").value;
                //console.log(print)
                if(print=="P_LTH"){
                    below_8000.sort((a,b)=>a.price-b.price);
                }else if(print=="P_HTL"){
                    below_8000.sort((a,b)=>b.price-a.price);
                }else if(print=="R_LTH"){
                    below_8000.sort((a,b)=>a.rating-b.rating);
                }else if(print=="R_HTL"){
                    below_8000.sort((a,b)=>b.rating-a.rating);
                }else if(print=="D_LTH"){
                    below_8000.sort((a,b)=>a.distance-b.distance);
                }
                render(below_8000)

            }

        }else if(review_value==8001 && p_10000==true){
             above_8000 = product_data.filter((item)=>{
                return item.price>8000 && item.price<10000
            })
            render(above_8000)

            //----filter sort function------//

            document.querySelector(".sort-box").addEventListener("change",sort)

            function sort(){
                let print = document.querySelector(".sort-box").value;
                //console.log(print)
                if(print=="P_LTH"){
                    above_8000.sort((a,b)=>a.price-b.price);
                }else if(print=="P_HTL"){
                    above_8000.sort((a,b)=>b.price-a.price);
                }else if(print=="R_LTH"){
                    above_8000.sort((a,b)=>a.rating-b.rating);
                }else if(print=="R_HTL"){
                    above_8000.sort((a,b)=>b.rating-a.rating);
                }else if(print=="D_LTH"){
                    above_8000.sort((a,b)=>a.distance-b.distance);
                }
                render(above_8000)

            }

        }else if(review_value==10000 && p_a_10==true){
             above_10 = product_data.filter((item)=>{
                return item.price>10000
            })
            render(above_10)

            //----filter sort function------//

            document.querySelector(".sort-box").addEventListener("change",sort)

            function sort(){
                let print = document.querySelector(".sort-box").value;
                //console.log(print)
                if(print=="P_LTH"){
                    above_10.sort((a,b)=>a.price-b.price);
                }else if(print=="P_HTL"){
                    above_10.sort((a,b)=>b.price-a.price);
                }else if(print=="R_LTH"){
                    above_10.sort((a,b)=>a.rating-b.rating);
                }else if(print=="R_HTL"){
                    above_10.sort((a,b)=>b.rating-a.rating);
                }else if(print=="D_LTH"){
                    above_10.sort((a,b)=>a.distance-b.distance);
                }
                render(above_10)

            }
        }
    })
}