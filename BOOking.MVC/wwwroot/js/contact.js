var coll = document.getElementsByClassName("collapsible");
var i;


let heightArray = [];
for (let i = 0; i < coll.length; i++) { // добавляем значения высоты каждого .content в массив по порядку
  heightArray.push(coll[i].nextElementSibling.scrollHeight);
}

for (let i = 0; i < coll.length; i++) {
  coll[i].addEventListener("click", function() {
    this.classList.toggle("active");

    if (!this.classList.contains('active')) { // при закрытии какой-либо кнопки закрывается также все внутренние кнопки и контент
      for (let x = i + 1; x < coll.length; x++) {
        coll[x].classList.remove("active");
        coll[x].nextElementSibling.style.maxHeight = null;
      }
    }

    var content = this.nextElementSibling;
    if (content.style.maxHeight) {
      content.style.maxHeight = null;
    } else {
      content.style.maxHeight = content.scrollHeight + "px";

      for (let prevContent = 0; prevContent < i; prevContent++) { // при открытии какой-либо кнопки нам необходимо также менять высоту всех предыдущих .content для корректного отображения аккордеона, высчитываем новую высоту путем сложения предыдущих значений высоты
        let sumHeight = 0;

        for (let prevContent = 0; prevContent <= i; prevContent++) {
          sumHeight = sumHeight + heightArray[prevContent];
        }

        coll[prevContent].nextElementSibling.style.maxHeight = sumHeight + 'px';
      }
    }
  });
}