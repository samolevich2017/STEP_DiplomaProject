#pragma checksum "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Cabinet\CabinetDetailsBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "234c40c2d30d8970dc33b9e044b0135756caad3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cabinet_CabinetDetailsBook), @"mvc.1.0.view", @"/Views/Cabinet/CabinetDetailsBook.cshtml")]
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
#line 7 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Cabinet\CabinetDetailsBook.cshtml"
using LibraryProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"234c40c2d30d8970dc33b9e044b0135756caad3d", @"/Views/Cabinet/CabinetDetailsBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be8390cc30a4c1d6bc6e1591c9d5beccf26439b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Cabinet_CabinetDetailsBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryProject.ViewModels.BooksEditViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styleAdminCatalog.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/stylePopup.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "234c40c2d30d8970dc33b9e044b0135756caad3d5544", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "234c40c2d30d8970dc33b9e044b0135756caad3d6658", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"popup_title\"><span id=\"spanTitle\">");
#nullable restore
#line 11 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Cabinet\CabinetDetailsBook.cshtml"
                                         Write(Model.SelectedBook.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> | <span id=\"spanAuthor\"></span></div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "234c40c2d30d8970dc33b9e044b0135756caad3d8162", async() => {
                WriteLiteral("\r\n    <div class=\"block_coverImg\">\r\n        <img");
                BeginWriteAttribute("src", " src=\"", 553, "\"", 626, 1);
#nullable restore
#line 14 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Cabinet\CabinetDetailsBook.cshtml"
WriteAttributeValue("", 559, BooksViewModel.CreateScrAttrForImg(Model.SelectedBook.CoverImgUrl), 559, 67, false);

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
                BeginWriteAttribute("value", " value=\"", 1101, "\"", 1134, 1);
#nullable restore
#line 23 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Cabinet\CabinetDetailsBook.cshtml"
WriteAttributeValue("", 1109, Model.SelectedBook.Title, 1109, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled required></span></li>\r\n            <li>Автор<sub>...................................</sub><span><input type=\"text\" id=\"inputBookAuthor\" name=\"inputBookAuthor\"");
                BeginWriteAttribute("value", " value=\"", 1303, "\"", 1311, 0);
                EndWriteAttribute();
                WriteLiteral(" disabled required></span></li>\r\n            <li class=\"li_genres\">\r\n                Жанр<sub>....................................</sub>\r\n                <ul class=\"list_genresBook detailsGenres\">\r\n");
#nullable restore
#line 28 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Cabinet\CabinetDetailsBook.cshtml"
                     foreach (var genre in ViewBag.Genres) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li>");
#nullable restore
#line 29 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Cabinet\CabinetDetailsBook.cshtml"
                       Write(genre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 30 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Cabinet\CabinetDetailsBook.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </ul>\r\n            </li>\r\n            <li>\r\n                Год выпуска<sub>......................</sub><span>\r\n                    <select name=\"selectBookYear\" id=\"selectBookYear\" disabled>\r\n");
#nullable restore
#line 36 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Cabinet\CabinetDetailsBook.cshtml"
                         for (int i = 2005; i <= 2021; i++) {
                            int value;
                            int.TryParse(string.Join("", Model.SelectedBook.YearOfIssue.Where(c => char.IsDigit(c))), out value);
                            bool flag = i == value ? true : false;

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "234c40c2d30d8970dc33b9e044b0135756caad3d11928", async() => {
#nullable restore
#line 40 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Cabinet\CabinetDetailsBook.cshtml"
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
#line 40 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Cabinet\CabinetDetailsBook.cshtml"
AddHtmlAttributeValue("", 2189, i, 2189, 2, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Cabinet\CabinetDetailsBook.cshtml"
                                         WriteLiteral(i);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 40 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Cabinet\CabinetDetailsBook.cshtml"
AddHtmlAttributeValue("", 2214, flag, 2214, 5, false);

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
#line 41 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Cabinet\CabinetDetailsBook.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\r\n                </span>\r\n            </li>\r\n            <li>Код книги<sub>...........................</sub><span>");
#nullable restore
#line 45 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Cabinet\CabinetDetailsBook.cshtml"
                                                                Write(Model.SelectedBook.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></li>\r\n        </ul>\r\n        <div class=\"block_description\">\r\n            <h3>О книге</h3>\r\n            <textarea name=\"inputBookDescription\" id=\"inputBookDescription\" disabled>");
#nullable restore
#line 49 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Cabinet\CabinetDetailsBook.cshtml"
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"block_btnGroup\">\r\n    <button class=\"btnCancel\">Отмена</button>\r\n</div>");
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