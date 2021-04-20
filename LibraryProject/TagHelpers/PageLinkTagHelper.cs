using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject.ViewModels;

namespace LibraryProject.TagHelpers {
    public class PageLinkTagHelper:TagHelper {
        
        private IUrlHelperFactory urlHelperFactory;
        public PageLinkTagHelper(IUrlHelperFactory helperFactory) {
            urlHelperFactory = helperFactory;
        }
        
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public PageViewModel PageModel { get; set; }
        public string PageAction { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output) {
            
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            output.TagName = "div";
            

            // набор ссылок будет представлять список ul
            TagBuilder tag = new TagBuilder("ul");
            tag.AddCssClass("pagination");

            // формируем три ссылки - на текущую, предыдущую и следующую
            TagBuilder currentItem = CreateTag(PageModel.PageNumber, urlHelper);

            // создаем ссылку на предыдущую страницу, если она есть
            if (PageModel.HasPreviousPage) {
                // создаем ссылку - в начало
                TagBuilder startItem = CreateTag(1, urlHelper, "В начало", true);
                tag.InnerHtml.AppendHtml(startItem);

                TagBuilder prevItem = CreateTag(PageModel.PageNumber - 1, urlHelper);
                tag.InnerHtml.AppendHtml(prevItem);
            }

            tag.InnerHtml.AppendHtml(currentItem);
            // создаем ссылку на следующую страницу, если она есть
            if (PageModel.HasNextPage) {
                TagBuilder nextItem = CreateTag(PageModel.PageNumber + 1, urlHelper);
                tag.InnerHtml.AppendHtml(nextItem);

                // создаем ссылку - в конец
                TagBuilder endItem = CreateTag(PageModel.TotalPages, urlHelper, "В конец", true);
                tag.InnerHtml.AppendHtml(endItem);
            }

            output.Attributes.Add("class", "block_pagination");
            output.Content.AppendHtml(tag);
        }

        TagBuilder CreateTag(int pageNumber, IUrlHelper urlHelper, string linkText = "", bool toStartEnd = false) {
            TagBuilder item = new TagBuilder("li");
            TagBuilder link = new TagBuilder("a");
            if (pageNumber == this.PageModel.PageNumber) {
                item.AddCssClass("active_page");
            }
            else {
                link.Attributes["href"] = urlHelper.Action(PageAction, new { page = pageNumber });
            }
            
            link.AddCssClass("page-link");

            if (toStartEnd == false) {
                link.InnerHtml.Append(pageNumber.ToString());
                item.AddCssClass("page-item");
            }
            else {
                link.InnerHtml.Append(linkText);
                item.AddCssClass("toStartEnd");
            }

            item.InnerHtml.AppendHtml(link);
            return item;
        }
    }
}
