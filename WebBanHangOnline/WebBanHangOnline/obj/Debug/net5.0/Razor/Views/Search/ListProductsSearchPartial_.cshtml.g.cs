#pragma checksum "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Search\ListProductsSearchPartial_.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b2823339365bd7aef9a1aa611cd7d59a31ff31d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_ListProductsSearchPartial_), @"mvc.1.0.view", @"/Views/Search/ListProductsSearchPartial_.cshtml")]
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
#line 1 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\_ViewImports.cshtml"
using WebBanHangOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\_ViewImports.cshtml"
using WebBanHangOnline.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b2823339365bd7aef9a1aa611cd7d59a31ff31d", @"/Views/Search/ListProductsSearchPartial_.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8e0195ed7d808b9dae80c38130e37e3de706f81", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_ListProductsSearchPartial_ : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"tab-pane fade\" id=\"list-view\" role=\"tabpanel\" aria-labelledby=\"list-view-tab\">\r\n    <div class=\"product-list-view with-sidebar row\">\r\n");
#nullable restore
#line 4 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Search\ListProductsSearchPartial_.cshtml"
         if (Model != null && Model.Count() > 0)
        {
            foreach (var item in Model)
            {
                string url = $"{item.Alias}-{item.ProductsId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-12\">\r\n                    <div class=\"product-item\">\r\n                        <div class=\"product-img img-zoom-effect\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 538, "\"", 549, 1);
#nullable restore
#line 12 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Search\ListProductsSearchPartial_.cshtml"
WriteAttributeValue("", 545, url, 545, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3b2823339365bd7aef9a1aa611cd7d59a31ff31d4815", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 614, "~/images/products/", 614, 18, true);
#nullable restore
#line 14 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Search\ListProductsSearchPartial_.cshtml"
AddHtmlAttributeValue("", 632, item.Thumb, 632, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 14 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Search\ListProductsSearchPartial_.cshtml"
AddHtmlAttributeValue("", 650, item.ProductsName, 650, 18, false);

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
            WriteLiteral(@"
                            </a>
                            <div class=""product-add-action"">
                                <ul>
                                    <li>
                                        <a href=""cart.html"">
                                            <i class=""pe-7s-cart""></i>
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""compare.html"">
                                            <i class=""pe-7s-shuffle""></i>
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""wishlist.html"">
                                            <i class=""pe-7s-like""></i>
                                        </a>
                                    </li>
                                </ul>
                            </div>
        ");
            WriteLiteral("                </div>\r\n                        <div class=\"product-content\">\r\n                            <a class=\"product-name\" href=\"single-product.html\">");
#nullable restore
#line 37 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Search\ListProductsSearchPartial_.cshtml"
                                                                          Write(item.ProductsName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <div class=\"price-box pb-1\">\r\n");
#nullable restore
#line 39 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Search\ListProductsSearchPartial_.cshtml"
                                 if (item.Discount != 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"new-price text-danger\">");
#nullable restore
#line 41 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Search\ListProductsSearchPartial_.cshtml"
                                                                   Write(item.Discount.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</span>\r\n                                    <span class=\"old-price text-primary\">");
#nullable restore
#line 42 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Search\ListProductsSearchPartial_.cshtml"
                                                                    Write(item.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</span>\r\n");
#nullable restore
#line 43 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Search\ListProductsSearchPartial_.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"new-price text-danger\">");
#nullable restore
#line 46 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Search\ListProductsSearchPartial_.cshtml"
                                                                   Write(item.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</span>\r\n");
#nullable restore
#line 47 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Search\ListProductsSearchPartial_.cshtml"


                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                            <div class=""rating-box"">
                                <ul>
                                    <li><i class=""pe-7s-star""></i></li>
                                    <li><i class=""pe-7s-star""></i></li>
                                    <li><i class=""pe-7s-star""></i></li>
                                    <li><i class=""pe-7s-star""></i></li>
                                    <li><i class=""pe-7s-star""></i></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 63 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Search\ListProductsSearchPartial_.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
