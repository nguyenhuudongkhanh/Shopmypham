#pragma checksum "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7711f9dff6328037552ddaebe3db96b8d0d685eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Dashboard), @"mvc.1.0.view", @"/Views/Account/Dashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7711f9dff6328037552ddaebe3db96b8d0d685eb", @"/Views/Account/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8e0195ed7d808b9dae80c38130e37e3de706f81", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebBanHangOnline.Models.Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
  

    Layout = "~/Views/Shared/_Layout.cshtml";
    List<Order> listOrder = ViewBag.ListOrder;
  
    WebBanHangOnline.ModelView.ChangePasswordViewModel changePassword = new WebBanHangOnline.ModelView.ChangePasswordViewModel();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height"" data-bg-image=""assets/images/breadcrumb/bg/1-1-1920x373.jpg"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h2 class=""breadcrumb-heading"">Product Related</h2>
                        <ul>
                            <li>
                                <a href=""index.html"">Home <i class=""pe-7s-angle-right""></i></a>
                            </li>
                            <li>My Account</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""account-page-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3"">
                    <ul class=""nav myaccount-tab-trigger"" id=""account-page-tab"" role=""tablis");
            WriteLiteral(@"t"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" id=""account-dashboard-tab"" data-bs-toggle=""tab"" href=""#account-dashboard"" role=""tab"" aria-controls=""account-dashboard"" aria-selected=""true"">Th??ng tin kh??ch h??ng</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-orders-tab"" data-bs-toggle=""tab"" href=""#account-orders"" role=""tab"" aria-controls=""account-orders"" aria-selected=""false"">S???n ph???m ???? mua</a>
                        </li>

                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-details-tab"" data-bs-toggle=""tab"" href=""#account-details"" role=""tab"" aria-controls=""account-details"" aria-selected=""false"">Thay ?????i th??ng tin</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-logout-tab"" href=""/dang-xuat.html"" role=""tab"" a");
            WriteLiteral(@"ria-selected=""false"">Logout</a>
                        </li>
                    </ul>
                </div>
                <div class=""col-lg-9"">
                    <div class=""tab-content myaccount-tab-content"" id=""account-page-tab-content"">
                        <div class=""tab-pane fade show active"" id=""account-dashboard"" role=""tabpanel"" aria-labelledby=""account-dashboard-tab"">
                            <div class=""myaccount-dashboard"">
                                <p>
                                    Xin ch??o, <b>");
#nullable restore
#line 54 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                            Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                                </p>\r\n\r\n                            </div>\r\n                        </div>\r\n");
            WriteLiteral(@"                        <div class=""tab-pane fade"" id=""account-orders"" role=""tabpanel"" aria-labelledby=""account-address-tab"">
                            <div class=""myaccount-orders"">
                                <h4 class=""small-title"">DANH S??CH ????N H??NG</h4>
");
#nullable restore
#line 68 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                 if (listOrder != null && listOrder.Count() > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""table-responsive"">
                                <table class=""table table-bordered table-hover"">
                                    <tbody>
                                        <tr>
                                            <th>ORDER</th>

                                            <th>Ng??y mua h??ng</th>
                                            <th>Ng??y ship h??ng</th>
                                            <th>Tr???ng th??i ????n h??ng</th>
                                            <th>T???ng ti???n</th>
                                            <th></th>
                                        </tr>
");
#nullable restore
#line 82 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                         foreach (var item in listOrder)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td><a class=\"account-order-id\" href=\"javascript:void(0)\">#");
#nullable restore
#line 85 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                                                                              Write(item.OrdersId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n\r\n                                        <td>");
#nullable restore
#line 87 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                       Write(item.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 88 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                       Write(item.ShipDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 89 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                       Write(item.TransactStatus.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                        <td>\r\n                                            <a href=\"javascript:void(0)\" class=\"xemdonhang\" data-madonhang=\"");
#nullable restore
#line 92 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                                                                                       Write(item.OrdersId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Xem ????n h??ng</a>\r\n                                        </td>\r\n\r\n                                    </tr>\r\n");
#nullable restore
#line 96 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                    </tbody>
                                </table>
                                <br />
                                <br />
                                <br />
                                <br />
                                <hr />
                                <div id=""records_table"">

                                </div>
                            </div>
");
#nullable restore
#line 110 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>Ch??a c?? ????n h??ng</p>\r\n");
#nullable restore
#line 114 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"tab-pane fade\" id=\"account-details\" role=\"tabpanel\" aria-labelledby=\"account-details-tab\">\r\n\r\n                            ");
#nullable restore
#line 123 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                       Write(await Html.PartialAsync("ChanggePasswordPartial", changePassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <h4 class=\"card-title\">Th??ng tin kh??ch h??ng: ");
#nullable restore
#line 134 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                                Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
        <div class=""table-responsive"">
            <table class=""product-info-table m-t-20"">
                <tbody>

                    <tr>
                        <td>T??n kh??ch h??ng:</td>
                        <td class=""text-dark font-weight-semibold"">");
#nullable restore
#line 141 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                                              Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n\r\n                    <tr>\r\n                        <td>Ng??y sinh:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 147 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                                              Write(Model.Birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td>???nh kh??ch h??ng:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 152 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                                              Write(Model.Avatar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td>?????a ch??? kh??ch h??ng:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 157 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                                              Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n\r\n                    <tr>\r\n                        <td>Email:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 163 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                                              Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td>S??? ??i???n tho???i:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 168 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                                              Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Ng??y tham gia:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 173 "E:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                                              Write(Model.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $("".xemdonhang"").click(function () {
                var madonhang = $(this).attr(""data-madonhang"")
                $.ajax({
                    url:'/DonHang/Details',
                    datatype: ""json"",
                    type: ""POST"",
                    data: { id: madonhang },
                    async: true,
                    success: function (results) {
                        $(""#records_table"").html("""");
                        $(""#records_table"").html(results);
                    },
                    error: function (xhr) {
                        alert('error');
                    }
                });
            });
        });
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebBanHangOnline.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
