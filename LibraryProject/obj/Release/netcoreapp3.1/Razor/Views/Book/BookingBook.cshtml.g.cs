#pragma checksum "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Book\BookingBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "713185517b65c1ba04def4d3c8e96b4d163820c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_BookingBook), @"mvc.1.0.view", @"/Views/Book/BookingBook.cshtml")]
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
#line 7 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Book\BookingBook.cshtml"
using LibraryProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"713185517b65c1ba04def4d3c8e96b4d163820c8", @"/Views/Book/BookingBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be8390cc30a4c1d6bc6e1591c9d5beccf26439b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_BookingBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryProject.Models.Books>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.5.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/popup.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/toast.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    .toast {
        margin-top: 37%;
        max-width: 350px;
        overflow: hidden;
        font-size: 0.875rem;
        background-color: rgba(255, 255, 255, 0.5);
        background-clip: padding-box;
        border: 1px solid rgba(0, 0, 0, 0.1);
        border-radius: 0.25rem;
        box-shadow: 0 0.25rem 0.75rem rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(10px);
        display: none;
        position: relative;
        padding: 0.75rem 2rem 0.75rem 0.75rem;
        overflow-wrap: break-word;
        word-break: break-word;
    }

        .toast:not(:last-child) {
            margin-bottom: 0.75rem;
        }

    .toast_show {
        display: block;
    }

    .toast__close {
        position: absolute;
        top: 0;
        right: 10px;
        padding: 0;
        background-color: transparent;
        border: 0;
        cursor: pointer;
        float: right;
        font-size: 1.5rem;
        font-weight: 700;
        line-height: 1;
      ");
            WriteLiteral(@"  color: #000;
        text-shadow: 0 1px 0 #fff;
        opacity: 0.6;
        appearance: button;
        margin: 0;
        font-family: inherit;
        border-radius: 0;
    }

    input:not([type=""checkbox""]) {
        display: block;
        font-size: 1rem;
        margin-bottom: .5rem;
    }

</style>
<div class=""block_bookingBookContent"">
    <h1>Подтверждение бронирования</h1>
    <p>Пожалуйста, подтвердите Ваше действие нажав кнопку ниже.</p>
    <div class=""block_bookInfo"">
        <div");
            BeginWriteAttribute("id", " id=\"", 1750, "\"", 1764, 1);
#nullable restore
#line 67 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Book\BookingBook.cshtml"
WriteAttributeValue("", 1755, Model.Id, 1755, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"bookCard bookInfo\">\r\n            <!-- Обложка -->\r\n            <div class=\"bookCover\" style=\"position: absolute; width: 100%;height: 100%;\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1935, "\"", 1995, 1);
#nullable restore
#line 70 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Book\BookingBook.cshtml"
WriteAttributeValue("", 1941, BooksViewModel.CreateScrAttrForImg(Model.CoverImgUrl), 1941, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"cover\">\r\n                <p class=\"bookTitle\"");
            BeginWriteAttribute("style", " style=\"", 2047, "\"", 2055, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 71 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Book\BookingBook.cshtml"
                                         Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"block_btnConfirm\">\r\n        <button class=\"btnConfirm\">Подтвердить</button>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "713185517b65c1ba04def4d3c8e96b4d163820c87611", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "713185517b65c1ba04def4d3c8e96b4d163820c88650", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "713185517b65c1ba04def4d3c8e96b4d163820c89689", async() => {
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
            WriteLiteral("\r\n<script>\r\n    let popupBooking = document.getElementById(\"popup_BookingBook\");\r\n\r\n    $(document).ready(function () {\r\n        $(\'.btnConfirm\').on(\"click\", function () {\r\n            var formData = new FormData();\r\n            formData.append(\"bookId\", ");
#nullable restore
#line 88 "C:\Программирование\Diploma\LibraryProject\LibraryProject\Views\Book\BookingBook.cshtml"
                                 Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@");
            $.ajax({
                url: ""/Book/BookingBookForReader"",
                dataType: 'script',
                cache: false,
                contentType: false,
                processData: false,
                data: formData,
                type: 'post'
            });
            
            popupClose(popupBooking);
            Toast.add({
                text: 'Успешно забронировано',
                color: '#28a745',
                autohide: true,
                delay: 5000
            });
            
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryProject.Models.Books> Html { get; private set; }
    }
}
#pragma warning restore 1591
