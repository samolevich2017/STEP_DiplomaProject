#pragma checksum "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminReaders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f327f6aa7f3417b37cb8c1cd03804d05c959b04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminReaders), @"mvc.1.0.view", @"/Views/Admin/AdminReaders.cshtml")]
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
#line 5 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminReaders.cshtml"
using LibraryProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f327f6aa7f3417b37cb8c1cd03804d05c959b04", @"/Views/Admin/AdminReaders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be8390cc30a4c1d6bc6e1591c9d5beccf26439b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminReaders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationContext>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styleAdminCatalog.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.5.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminReaders.cshtml"
  
    Layout = "~/Views/Shared/_LayoutAdminPanel.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f327f6aa7f3417b37cb8c1cd03804d05c959b045025", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <title>Читатели</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8f327f6aa7f3417b37cb8c1cd03804d05c959b045350", async() => {
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
                WriteLiteral("\r\n    <style>\r\n        td {\r\n            max-width: 112px;\r\n            text-overflow: ellipsis;\r\n            color: #333333;\r\n            white-space: nowrap;\r\n        }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f327f6aa7f3417b37cb8c1cd03804d05c959b047432", async() => {
                WriteLiteral("\r\n    <div class=\"titleTable\">\r\n        <h1 style=\"margin-left: 15px; color: #333;\">Читатели</h1>\r\n    </div>\r\n");
                WriteLiteral(@"
    <div class=""block_table"" style="" max-height: 500px; overflow: auto;"">
        <table style=""table-layout: fixed"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th style=""max-width: 150px;"">Фамилия</th>
                    <th style=""max-width: 150px;"">Имя</th>
                    <th style=""max-width: 150px;"">Отчество</th>
                    <th style=""max-width: 150px;"">Логин</th>
                    <th style=""max-width: 150px;"">Почта</th>
                    <th style=""max-width: 150px;"">Пароль</th>
                    <th style=""max-width: 150px;"">Адрес</th>
                    <th style=""max-width: 150px;"">Номер тел.</th>
                    <th style=""max-width: 80px;"">Аватар</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 48 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminReaders.cshtml"
                 foreach (var reader in Model.Readers) {


#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr");
                BeginWriteAttribute("id", " id=\"", 1784, "\"", 1799, 1);
#nullable restore
#line 50 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminReaders.cshtml"
WriteAttributeValue("", 1789, reader.Id, 1789, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <td>");
#nullable restore
#line 51 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminReaders.cshtml"
                       Write(reader.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 52 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminReaders.cshtml"
                       Write(reader.SurnameReader);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 53 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminReaders.cshtml"
                       Write(reader.NameReader);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 54 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminReaders.cshtml"
                       Write(reader.PatronymicReader);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 55 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminReaders.cshtml"
                       Write(reader.LoginReader);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 56 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminReaders.cshtml"
                       Write(reader.EmailReader);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 57 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminReaders.cshtml"
                       Write(reader.PasswordReader);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td style=\"overflow:hidden;\">");
#nullable restore
#line 58 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminReaders.cshtml"
                                                Write(reader.AdressReader);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 59 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminReaders.cshtml"
                       Write(reader.PhoneNumberReader);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td><img");
                BeginWriteAttribute("src", " src=\"", 2353, "\"", 2381, 1);
#nullable restore
#line 60 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminReaders.cshtml"
WriteAttributeValue("", 2359, reader.PhotoReaderUrl, 2359, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"avatar\"/> </td>\r\n                    </tr>\r\n");
#nullable restore
#line 62 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminReaders.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n    </div>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f327f6aa7f3417b37cb8c1cd03804d05c959b0412850", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationContext> Html { get; private set; }
    }
}
#pragma warning restore 1591