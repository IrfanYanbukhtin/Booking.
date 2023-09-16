let registration = document.querySelector('.registr')
let signin = document.querySelector('.signIn')
let closesignin = document.querySelector('#close_signin')

registration.onclick = function() {
    login.classList.add('d-none')
    signin.classList.remove('d-none')
    body.style.backgroundColor = "rgba(0, 0, 0, 0.5)";
  }
  
  closesignin.onclick = function() {
    signin.classList.add('d-none')
    body.style.backgroundColor = "yellow";
  }

  //login
let user = document.querySelector('#user')
let login = document.querySelector('.login')
let close = document.querySelector('#close_login')
const body = document.body;


user.onclick = function() {
  login.classList.remove('d-none')
  body.style.backgroundColor = "rgba(0, 0, 0, 0.5)";
}

close.onclick = function() {
  login.classList.add('d-none')
  body.style.backgroundColor = "#yellow";
}


close.onclick = function() {
  login.classList.add('d-none')
  body.style.backgroundColor = "#yellow";
}

//forget
let resetpassword = document.querySelector('.forgetpassword')
let forgot = document.querySelector('#forget')
let closeforget = document.querySelector('#close_forget')


forgot.onclick = function() {
  resetpassword.classList.remove('d-none')
  login.classList.add('d-none')
  body.style.backgroundColor = "rgba(0, 0, 0, 0.5)";
}

closeforget.onclick = function() {
  resetpassword.classList.add('d-none')
  body.style.backgroundColor = "#yellow";
}