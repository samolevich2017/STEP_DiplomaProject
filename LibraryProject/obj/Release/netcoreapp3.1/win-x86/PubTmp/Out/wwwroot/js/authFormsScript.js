'use strict'; // строгий режим

// форма для входа
const formLogIn = `<div class="title_form">
                    <h1>Авторизация</h1>
                </div>
                <hr/>
                <div class="form" >
                    <form class="formLogIn" asp-controller method="post">
                        <div class="fields">
                            <div class="field_Email fieldsInp">
                                <span>&#128231;</span>
                                <input type="email" name="email" placeholder="E-mail" />
                            </div>
                            <div class="field_Password fieldsInp">
                                <span>&#128273;</span>
                                <input type="password" name="password" placeholder="Пароль" />
                            </div>
                            <div class="checkbox_remember">
                                <label id="lbRememberCheckBox" for="remember_Checkbox">Запомнить</label>
                                <input id="remember_Checkbox" type="checkbox">
                            </div>
                            <div class="btnLogIn">
                               <button class="btnLog"><a asp-controller="Cabinet" asp-action="Cabinet" style="text-decoration: none; color: #fff;">Войти</a></button>
                            </div>
                        </div>
                        <span class="orSpan" style="display: flex; justify-content: center; font-size: 13px">или</span>
                        <div class="blockAuthorizationMethods">
                            <ul class="authMethodsList">
                                <li class="authMethodListItem">
                                    <button name="btnLogInWithGoogle">
                                        <img src="~/img/authorization/google.png" alt="">
                                    </button>
                                </li>
                                <li class="authMethodListItem">
                                    <button name="btnLogInWithVK">
                                        <img src="~/img/authorization/vk.png" alt="">
                                    </button>
                                </li>
                            </ul>
                        </div>
                        <button type="button" class="btnSignUp" id="btnSwapToSignUp">Регистрация</button>
                    </form>
                </div>`;

// форма для регистрации
const formSignUp = `<div class="title_form">
                    <h1>Регистрация</h1>
                </div>
                <hr/>
                <div class="form">
                    <form class="formSignUp" asp-controller="Cabinet" asp-action="Register" method="post">
                        <div class="fields">
                            <div class="field_Login fieldsInp">
                                <span>&#9997;</span>
                                <input type="text" name="surnameNP" placeholder="ФИО">
                            </div>
                            <div class="field_Login fieldsInp">
                                <span>&#128100;</span>
                                <input type="text" name="login" placeholder="Логин">
                            </div>
                            <div class="field_Email fieldsInp">
                                <span>&#128231;</span>
                                <input type="email" name="email" placeholder="E-mail" />
                            </div>
                            <div class="field_Password fieldsInp">
                                <span>&#128273;</span>
                                <input type="password" name="password" placeholder="Пароль" />
                            </div>
                            <div class="field_Password fieldsInp">
                                <span>&#128273;</span>
                                <input type="password" name="password" placeholder="Подтверждение пароля" />
                            </div>
                            <div class="checkbox_notRobot fieldsInp" style="margin-left: 0px;">
                                <label id="lbNotRobot_Checkbox" for="notRobot_Checkbox">Я не робот</label>
                                <input id="notRobot_Checkbox" type="checkbox">
                            </div>
                        </div>
                        <div class="btnSignUpSubmitDiv">
                            <button class="btnSignUpSubmit" type="submit">Зарегистрироваться</button>
                        </div>
                        <div class="btnSwapToLogInForm">
                            <button id="btnSwapToLogIn" type="button">вход</button>
                        </div>
                    </form>
                </div>`;

// оболочка для формы
let formAuth = document.getElementById('block__form__Log');

// добавляем для кнопки перехода на регистрацию
// слушателя события клика
addELForBtnSwapToSignUp();

// функция добавления слушателя события клика
// для кнопки перехода на форму регистрации
function addELForBtnSwapToSignUp() {

    // кнопка для перехода на форму регистрации
    let btnSwapToSignUp = document.getElementById('btnSwapToSignUp');
    btnSwapToSignUp.addEventListener("click", function () {
        // анимация перехода из формы в форму
        formAuth.animate([{ opacity: "0" }, { opacity: "1" }], { duration: 1400, easing: 'ease-in-out' });
        formAuth.innerHTML = formSignUp;
        formAuth.style.height = '510px';
        // добавляем слушателя для кнопки перехода на форму входа
        addELForBtnSwapToLogIn();
    });

} // addELForBtnSwapToSignUp


// функция добавления слушателя события клика
// для кнопки перехода на форму входа
function addELForBtnSwapToLogIn() {

    // кнопка для перехода на форму входа
    let btnSwapToLogIn = document.getElementById('btnSwapToLogIn');
    btnSwapToLogIn.addEventListener("click", function () {
        formAuth.animate([{ opacity: "0" }, { opacity: "1" }], { duration: 1400, easing: 'ease-in-out' });
        formAuth.innerHTML = formLogIn;
        formAuth.style.height = '400px';
        // добавляем слушателя для кнопки перехода на форму регистрации
        addELForBtnSwapToSignUp();
    });

} // addELForBtnSwapToLogIn