#pragma checksum "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd3f1e340f1eb6d4daeeae27e242b070eafeafdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_News_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/News/Delete.cshtml")]
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
#line 1 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\_ViewImports.cshtml"
using WebBanHangOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\_ViewImports.cshtml"
using WebBanHangOnline.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd3f1e340f1eb6d4daeeae27e242b070eafeafdf", @"/Areas/Admin/Views/News/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8e0195ed7d808b9dae80c38130e37e3de706f81", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_News_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebBanHangOnline.Models.News>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "News", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Admin/Views/Shared/Admin_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"page-header\">\r\n    <h2 class=\"header-title\">X??a tin</h2>\r\n    <div class=\"header-sub-title\">\r\n        <nav class=\"breadcrumb breadcrumb-dash\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd3f1e340f1eb6d4daeeae27e242b070eafeafdf7172", async() => {
                WriteLiteral("<i class=\"anticon anticon-home m-r-5\"></i>Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd3f1e340f1eb6d4daeeae27e242b070eafeafdf8870", async() => {
                WriteLiteral("News");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <span class=\"breadcrumb-item active\">Th??ng Tin</span>\r\n        </nav>\r\n    </div>\r\n</div>\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <h4 class=\"card-title\">Th??ng tin tin t???c: ");
#nullable restore
#line 21 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
                                             Write(Model.Tiltle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
        <div class=""table-responsive"">
            <table class=""product-info-table m-t-20"">
                <tbody>
                    <tr>
                        <td>M?? tin:</td>
                        <td class=""text-dark font-weight-semibold"">");
#nullable restore
#line 27 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
                                                              Write(Model.PostId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>T??n s???n ph???m:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 31 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
                                                              Write(Model.Tiltle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n\r\n                    <tr>\r\n                        <td>M?? t??? ng???n:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 37 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
                                                              Write(Model.Scontents);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n\r\n                    <tr>\r\n                        <td>M?? t???:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 43 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
                                                              Write(Model.Contents);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Thu???c danh m???c:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 48 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
                                                              Write(Model.Cat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td>???nh s???n ph???m:</td>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cd3f1e340f1eb6d4daeeae27e242b070eafeafdf13713", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1981, "~/images/news/", 1981, 14, true);
#nullable restore
#line 53 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
AddHtmlAttributeValue("", 1995, Model.Thumb, 1995, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 53 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
AddHtmlAttributeValue("", 2014, Model.Tiltle, 2014, 13, false);

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
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n\r\n                    <tr>\r\n                        <td>B?? danh:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 59 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
                                                              Write(Model.Alias);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Ng??y t???o:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 64 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
                                                              Write(Model.CreteDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td>T??c gi???:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 69 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
                                                              Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td>T??i kho???ng:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 74 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
                                                              Write(Model.AccountId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Tr???ng th??i tin:</td>\r\n                        <td>\r\n");
#nullable restore
#line 80 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
                             if (Model.Published == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""d-flex align-items-center"">
                                    <div class=""badge badge-success badge-dot m-r-10""></div>
                                    <div>Active</div>
                                </div>
");
#nullable restore
#line 86 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""d-flex align-items-center"">
                                    <div class=""badge badge-warning badge-dot m-r-10""></div>
                                    <div>Block</div>
                                </div>
");
#nullable restore
#line 93 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Tr???ng th??i tin hot:</td>\r\n                        <td>\r\n");
#nullable restore
#line 101 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
                             if (Model.IsHot == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""d-flex align-items-center"">
                                    <div class=""badge badge-success badge-dot m-r-10""></div>
                                    <div>Active</div>
                                </div>
");
#nullable restore
#line 107 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""d-flex align-items-center"">
                                    <div class=""badge badge-warning badge-dot m-r-10""></div>
                                    <div>Block</div>
                                </div>
");
#nullable restore
#line 114 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Tr???ng th??i tin m???i:</td>\r\n                        <td>\r\n");
#nullable restore
#line 121 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
                             if (Model.IsNewfedd == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""d-flex align-items-center"">
                                    <div class=""badge badge-success badge-dot m-r-10""></div>
                                    <div>Active</div>
                                </div>
");
#nullable restore
#line 127 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""d-flex align-items-center"">
                                    <div class=""badge badge-warning badge-dot m-r-10""></div>
                                    <div>Block</div>
                                </div>
");
#nullable restore
#line 134 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n\r\n                    <tr>\r\n                        <td>Tag tin:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 141 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
                                                              Write(Model.Tags);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td>T??n b?? danh:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 147 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
                                                              Write(Model.Alias);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td>T??? kh??a:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 154 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
                                                              Write(Model.MetaKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td>MetaDesc:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 160 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
                                                              Write(Model.MetaDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td>S??? l?????ng view:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 166 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
                                                              Write(Model.Views);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td>X??c nh???n x??a:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd3f1e340f1eb6d4daeeae27e242b070eafeafdf25320", async() => {
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cd3f1e340f1eb6d4daeeae27e242b070eafeafdf25611", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 174 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\News\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PostId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd3f1e340f1eb6d4daeeae27e242b070eafeafdf27479", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n\r\n\r\n                    </tr>\r\n\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebBanHangOnline.Models.News> Html { get; private set; }
    }
}
#pragma warning restore 1591
