#pragma checksum "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dd53638b024d1b23eafac5ee0071e67030991b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminDetailsBook), @"mvc.1.0.view", @"/Views/Admin/AdminDetailsBook.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\_ViewImports.cshtml"
using LibraryProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\_ViewImports.cshtml"
using LibraryProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
using LibraryProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dd53638b024d1b23eafac5ee0071e67030991b6", @"/Views/Admin/AdminDetailsBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be8390cc30a4c1d6bc6e1591c9d5beccf26439b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminDetailsBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryProject.ViewModels.BooksEditViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("genresEdit_Form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("genresEdit_Form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/popup.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/popupEditBookScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"popup_title\"><span id=\"spanTitle\">");
#nullable restore
#line 5 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
                                         Write(Model.SelectedBook.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> | <span id=\"spanAuthor\">");
#nullable restore
#line 5 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
                                                                                                  Write(Model.SelectedBook.Author.SurnameNp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dd53638b024d1b23eafac5ee0071e67030991b66980", async() => {
                WriteLiteral("\r\n    <div class=\"block_coverImg\">\r\n        <img");
                BeginWriteAttribute("src", " src=\"", 344, "\"", 417, 1);
#nullable restore
#line 8 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
WriteAttributeValue("", 350, BooksViewModel.CreateScrAttrForImg(Model.SelectedBook.CoverImgUrl), 350, 67, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" alt=""фото"">
        <input type=""file"" accept="".jpg, .jpeg, .png, .svg"" class=""inputFile"" id=""formImage"" name=""uploadFile"" disabled>
        <div class=""block_btnFile"">
            <button class=""btnFile"">Загрузить</button>
        </div>
    </div>


    <div class=""block_characteristics"">
        <h3>Свойства книги</h3>
        <ul>
            <li>Название<sub>............................</sub><span><input type=""text"" id=""inputBookTitle"" name=""inputBookTitle""");
                BeginWriteAttribute("value", " value=\"", 896, "\"", 929, 1);
#nullable restore
#line 19 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
WriteAttributeValue("", 904, Model.SelectedBook.Title, 904, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled required></span></li>\r\n            <li>Автор<sub>...................................</sub><span><input type=\"text\" id=\"inputBookAuthor\" name=\"inputBookAuthor\"");
                BeginWriteAttribute("value", " value=\"", 1098, "\"", 1142, 1);
#nullable restore
#line 20 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
WriteAttributeValue("", 1106, Model.SelectedBook.Author.SurnameNp, 1106, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled required></span></li>\r\n            <li class=\"li_genres\">\r\n                Жанр<sub>....................................</sub>\r\n                <ul class=\"list_genresBook detailsGenres\">\r\n");
#nullable restore
#line 24 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
                     foreach (var genre in ViewBag.Genres) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li>");
#nullable restore
#line 25 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
                       Write(genre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 26 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </ul>\r\n                <button class=\"btnEditGenres\" id=\"btnEditGenres\" type=\"button\"><img src=\"../images/edit.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 1598, "\"", 1604, 0);
                EndWriteAttribute();
                WriteLiteral("></button>\r\n            </li>\r\n            <li>\r\n                Год выпуска<sub>......................</sub><span>\r\n                    <select name=\"selectBookYear\" id=\"selectBookYear\" disabled>\r\n");
#nullable restore
#line 33 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
                         for (int i = 2005; i <= 2021; i++) {
                            int value;
                            int.TryParse(string.Join("", Model.SelectedBook.YearOfIssue.Where(c => char.IsDigit(c))), out value);
                            bool flag = i == value ? true : false;

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dd53638b024d1b23eafac5ee0071e67030991b611262", async() => {
#nullable restore
#line 37 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
                                                                     Write(i);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "name", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 37 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
AddHtmlAttributeValue("", 2147, i, 2147, 2, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
                                         WriteLiteral(i);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 37 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
AddHtmlAttributeValue("", 2172, flag, 2172, 5, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\r\n                </span>\r\n            </li>\r\n            <li>Код книги<sub>...........................</sub><span>");
#nullable restore
#line 42 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
                                                                Write(Model.SelectedBook.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></li>\r\n        </ul>\r\n        <div class=\"block_description\">\r\n            <h3>О книге</h3>\r\n            <textarea name=\"inputBookDescription\" id=\"inputBookDescription\" disabled>");
#nullable restore
#line 46 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
                                                                                Write(Model.SelectedBook.DescriptionBook);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n        </div>\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<p class=""tooltip_AboutFile""><em style=""color: red;"">*</em> Для загрузки обложки, наведите курсор на изображение</p>
<div class=""block_btnGroup"">
    <button class=""btnSaveChanges"" disabled>Сохранить</button>
    <button class=""btnEdit"">Изменить</button>
");
            WriteLiteral(@"    <button class=""btnCancel"">Отмена</button>
</div>
<div class=""block_genresEdit"">
    <div class=""block_genresEdit_body"">

    </div>
    <div class=""block_genresEdit_Content"">
        <div class=""genresEdit_title""><h3>Список жанров</h3></div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dd53638b024d1b23eafac5ee0071e67030991b617232", async() => {
                WriteLiteral("\r\n            <ul class=\"listCheckboxGenres\">\r\n");
#nullable restore
#line 66 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
                 foreach (var item in Model.context.Genres) {
                    // код определяющий к каким жанрам относится книга, чтобы отметить те жанры, которые у книги уже есть
                    bool flagChecked = false;
                    List<BooksGenres> bgs = Model.SelectedBook.BooksGenres.Select(o => o).ToList(); // получим записи об id книги и жанров
                    foreach (var bg in bgs) {
                        if (bg.GenreId == item.Id) {
                            flagChecked = true;
                        }
                    } // foreach

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li class=\"list-item\"><label><input type=\"checkbox\" name=\"selected_genres\"");
                BeginWriteAttribute("id", " id=\"", 4017, "\"", 4036, 2);
                WriteAttributeValue("", 4022, "genre_", 4022, 6, true);
#nullable restore
#line 75 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
WriteAttributeValue("", 4028, item.Id, 4028, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 4037, "\"", 4053, 1);
#nullable restore
#line 75 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
WriteAttributeValue("", 4045, item.Id, 4045, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("checked", " checked=\"", 4054, "\"", 4076, 1);
#nullable restore
#line 75 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
WriteAttributeValue("", 4064, flagChecked, 4064, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 75 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
                                                                                                                                                      Write(item.GenreName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></li>\r\n");
#nullable restore
#line 76 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </ul>
            <div class=""groupBtnEditForm block_btnGroup"">
                <button class=""btnApplyEditGenres"" type=""button"">Применить</button>
                <button class=""btnCancelEditGenres"" type=""button"">Отмена</button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dd53638b024d1b23eafac5ee0071e67030991b621760", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dd53638b024d1b23eafac5ee0071e67030991b622800", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>


    $(function () {

        // ----------------------- подготовка данных о жанрах для передачи на сервер

        let arrSelected_genres = """";

        // событие клика для кнопки *Применить* (жанры)
        $("".btnApplyEditGenres"").on(""click"", function () {

            if ($('#genresEdit_Form input:checkbox:checked').length == 0) {
                alert(""Ошибка! Книга не может не иметь жанра. Выберите жанр, либо нажмите кнопку 'Отмена'."");
                return;
            }

            arrSelected_genres = """"; // очистим массив

            $('#genresEdit_Form input:checkbox:checked').each(function () {
                arrSelected_genres += `${$(this).val()},`;
            });

            // удаляем последнюю запятую
            arrSelected_genres = arrSelected_genres.slice(0, -1);

            console.log(arrSelected_genres);

            $("".block_genresEdit"").removeClass(""isVisible"");
            $("".block_genresEdit_Content"").removeClass(""openListGenres"");");
            WriteLiteral(@"

        });

        // --------------------------------- Работа с загрузкой файла ----------------------------

        let formData_Fim = new FormData();
        let strFile = """";

        // получаем инпут file в переменную
        const formImage = document.getElementById('formImage');

        // слушаем изменения в инпуте file
        formImage.addEventListener(""change"", function () {
            uploadFile(formImage.files[0]);
        });

        function uploadFile(file) {
            // проверяем тип файла
            if (!['image/jpeg', 'image/png', 'image/svg'].includes(file.type)) {
                alert(""Разрешены только изображения."");
                formImage.value = '';
                return;
            } // if

            // проверим размер файла (<2 Мб)
            if (file.size > 2 * 1024 * 1024) {
                alert(""Файл должен быть менее 2 МБ."");
                return;
            } // if

            var reader = new FileReader();
            r");
            WriteLiteral(@"eader.onload = function (e) {
                $("".block_coverImg>img"").attr(""src"", e.target.result);
            };

            reader.onerror = function (e) {
                alert(""Ошибка"");
            };

            

            reader.readAsDataURL(file);
            getBase64(file);

            formData_Fim.append(""fileImage"", file);

        } // uploadFile

        function getBase64(file) {
            var reader = new FileReader();
            reader.readAsDataURL(file);
            reader.onload = function () {
                console.log(reader.result);
                strFile = reader.result;
            };
            reader.onerror = function (error) {
                console.log('Error: ', error);
            };
        }

        // var file = document.querySelector('#files > input[type=""file""]').files[0];

        // let strFile = getBase64(formData_Fim.get(""fileImage"")); // prints the base64 string

        // событие клика по кнопке - сохранить
       ");
            WriteLiteral(" $(\".btnSaveChanges\").click(function (e) {\r\n\r\n            var file_data = $(\"#formImage\").prop(\"files\")[0];\r\n            var form_data = new FormData();\r\n            \r\n            form_data.append(\"file\", strFile);\r\n            form_data.append(\"id\", ");
#nullable restore
#line 188 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
                              Write(Model.SelectedBook.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@");
            form_data.append(""inputBookTitle"", $(""#inputBookTitle"").val());
            form_data.append(""inputBookAuthor"", $(""#inputBookAuthor"").val());
            form_data.append(""selectBookYear"", $(""#selectBookYear"").val());
            form_data.append(""inputBookDescription"", $(""#inputBookDescription"").val());
            form_data.append(""selected_genres"", arrSelected_genres);

            $.ajax({
                url: ""/Admin/AdminDetailsBookEdit"",
                dataType: 'script',
                cache: false,
                contentType: false,
                processData: false,
                data: form_data,
                type: 'post'
            })

            $(""#spanTitle"").text($(""#inputBookTitle"").val());

            $(""input[type='text'], #selectBookYear, textarea"").attr(""disabled"", true);
            $("".tooltip_AboutFile"").removeClass(""tooltip_aboutFileVisible"");
            $(""input[type='file']"").attr(""disabled"", true);
            $("".btnSaveChanges"").at");
            WriteLiteral(@"tr(""disabled"", true);
            $(""#btnEditGenres"").hide();
        });

        // событие клика по кнопке - удалить
        $("".btnDelete"").on(""click"", function () {

            if (!confirm(""Вы действительно хотите удалить данную книгу из каталога?"")) {
                return;
            } else {

                var formData = new FormData();
                formData.append(""id"", ");
#nullable restore
#line 222 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminDetailsBook.cshtml"
                                 Write(Model.SelectedBook.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@");
                $.ajax({
                    url: ""/Admin/AdminRemoveBook"",
                    dataType: 'script',
                    cache: false,
                    contentType: false,
                    processData: false,
                    data: formData,
                    type: 'post'
                });

                popupClose(popupEdit);
            }

        });

    });
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryProject.ViewModels.BooksEditViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
