#pragma checksum "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminBookingBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0bd8f4dc8b37efceb1bab13874e0691343cb877"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminBookingBooks), @"mvc.1.0.view", @"/Views/Admin/AdminBookingBooks.cshtml")]
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
#line 5 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminBookingBooks.cshtml"
using LibraryProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0bd8f4dc8b37efceb1bab13874e0691343cb877", @"/Views/Admin/AdminBookingBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be8390cc30a4c1d6bc6e1591c9d5beccf26439b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminBookingBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationContext>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styleAdminCatalog.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/toast.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.5.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/toast.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminBookingBooks.cshtml"
  
    Layout = "~/Views/Shared/_LayoutAdminPanel.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0bd8f4dc8b37efceb1bab13874e0691343cb8775765", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <title>Бронь книг</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a0bd8f4dc8b37efceb1bab13874e0691343cb8776092", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a0bd8f4dc8b37efceb1bab13874e0691343cb8777270", async() => {
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
                WriteLiteral(@"
    <style>
        .btnLend {
            cursor: pointer;
            position: absolute;
            top: 0;
            right: 0;
            height: 100%;
            width: 100%;
            font-size: 14px;
            text-transform: uppercase;
            font-weight: bold;
            border: none;
            color: #dcce84;
            background-color: rgba(34, 34, 34, 0.88);
        }

        button:disabled{
            cursor: not-allowed;
            background-color: #333c;
        }
    </style>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0bd8f4dc8b37efceb1bab13874e0691343cb8779693", async() => {
                WriteLiteral("\r\n    <div class=\"titleTable\">\r\n        <h1 style=\"margin-left: 15px; color: #333;\">Бронь книг</h1>\r\n    </div>\r\n");
                WriteLiteral(@"
    <div class=""block_table"" style=""        justify-content: left;
        max-height: 500px;
        overflow: auto;
"">
        <table>
            <thead>
                <tr>
                    <th>Id</th>
                    <th style=""max-width: 150px;"">Читатель</th>
                    <th style=""max-width: 150px;"">Книга</th>
                    <th style=""max-width: 150px;"">Дата бронирования</th>
                    <th style=""max-width: 150px;"">Дата истечения брони</th>
                    <th>Действие</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 61 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminBookingBooks.cshtml"
                 foreach (var record in Model.BookingRecords.ToList()) {
                    // получим читателя записи, для формирования его фамилии и инициалов
                    Readers reader = Model.Readers.Select(o => o).Where(r => r.Id == record.IdReader).ToList()[0];
                    string readerSurnameNP = reader.SurnameReader + " " + reader.NameReader.Substring(0, 1) + ". " + reader.PatronymicReader.Substring(0, 1) + ".";



#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr");
                BeginWriteAttribute("id", " id=\"", 2361, "\"", 2376, 1);
#nullable restore
#line 67 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminBookingBooks.cshtml"
WriteAttributeValue("", 2366, record.Id, 2366, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <td>");
#nullable restore
#line 68 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminBookingBooks.cshtml"
                       Write(record.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 69 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminBookingBooks.cshtml"
                       Write(readerSurnameNP);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 70 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminBookingBooks.cshtml"
                       Write(Model.Books.Select(o => o).Where(b => b.Id == record.IdBook).ToList()[0].Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 71 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminBookingBooks.cshtml"
                       Write(record.BookingDate.Date.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 72 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminBookingBooks.cshtml"
                       Write(record.DateOfCompletion.Date.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td style=\"position: relative\">\r\n");
#nullable restore
#line 74 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminBookingBooks.cshtml"
                             if (Model.Books.Select(o => o).Where(b => b.Id == record.IdBook).ToList()[0].Copies.AmountFreeCopies > 0) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <button class=\"btnLend\"");
                BeginWriteAttribute("id", " id=\"", 3009, "\"", 3024, 1);
#nullable restore
#line 75 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminBookingBooks.cshtml"
WriteAttributeValue("", 3014, record.Id, 3014, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Выдать</button>\r\n");
#nullable restore
#line 76 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminBookingBooks.cshtml"
                            }
                            else {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <button class=\"btnLend\"");
                BeginWriteAttribute("id", " id=\"", 3165, "\"", 3180, 1);
#nullable restore
#line 78 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminBookingBooks.cshtml"
WriteAttributeValue("", 3170, record.Id, 3170, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled>Выдать</button>\r\n");
#nullable restore
#line 79 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminBookingBooks.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 82 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Admin\AdminBookingBooks.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n       \r\n    </div>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0bd8f4dc8b37efceb1bab13874e0691343cb87715629", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0bd8f4dc8b37efceb1bab13874e0691343cb87716729", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        $(document).ready(function () {

            $("".btnLend"").on(""click"", function (e) {

                let postData = new FormData();
                postData.append(""id"", e.target.id);

                $.ajax({
                    url: ""/Admin/AdminBookingBooks"",
                    dataType: 'script',
                    cache: false,
                    contentType: false,
                    processData: false,
                    data: postData,
                    type: 'post'
                })

                Toast.add({
                    text: 'Выдача прошла успешно!',
                    color: '#28a745',
                    autohide: true,
                    delay: 5000
                });
                
            });

        });
    </script>
");
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