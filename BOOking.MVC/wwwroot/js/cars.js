let slidesContainerA = document.getElementById("slides-containerA");
let slideA = document.querySelector(".slideA");
let prevButtonA = document.getElementById("slide-arrow-prevA");
let nextButtonA = document.getElementById("slide-arrow-nextA");

nextButtonA.addEventListener("click", () => {
  let slideWidth = slideA.clientWidth;
  slidesContainerA.scrollLeft += slideWidth;
});

prevButtonA.addEventListener("click", () => {
  let slideWidth = slideA.clientWidth;
  slidesContainerA.scrollLeft -= slideWidth;
});