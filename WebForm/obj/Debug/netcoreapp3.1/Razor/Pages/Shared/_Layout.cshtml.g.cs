#pragma checksum "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d10cd5a8071503c7e258c9a54266ce4b481ba5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebForm.Pages.Shared.Pages_Shared__Layout), @"mvc.1.0.view", @"/Pages/Shared/_Layout.cshtml")]
namespace WebForm.Pages.Shared
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
#line 1 "D:\git\QuanLyTourDuLich\WebForm\Pages\_ViewImports.cshtml"
using WebForm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
using BUS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
using DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d10cd5a8071503c7e258c9a54266ce4b481ba5d", @"/Pages/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1a0e82eeb42b707043b0c5f7fab4f8b5db1f13f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo-mini.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Shared/QuanLyTour", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Shared/QuanLyNhanVien", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Shared/QuanLyKhachHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Shared/QuanLyDoan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Shared/QuanLyPhanCong", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Shared/QuanLyDiaDiem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Shared/QuanLyGia", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d10cd5a8071503c7e258c9a54266ce4b481ba5d7047", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("    <!-- Required meta tags -->\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <title>Website Quản Lý Tour</title>\r\n\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 299, "\"", 363, 1);
#nullable restore
#line 11 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 306, Url.Content("~/vendors/typicons.font/font/typicons.css"), 306, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" media=\"screen\" />\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 410, "\"", 469, 1);
#nullable restore
#line 12 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 417, Url.Content("~/vendors/css/vendor.bundle.base.css"), 417, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" media=\"screen\" />\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 516, "\"", 576, 1);
#nullable restore
#line 13 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 523, Url.Content("~/css/vertical-layout-light/style.css"), 523, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" media=\"screen\" />\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 623, "\"", 664, 1);
#nullable restore
#line 14 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 630, Url.Content("~/css/hung_css.css"), 630, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" media=\"screen\" />\r\n    <link rel=\"shortcut icon\"");
                BeginWriteAttribute("href", " href=\"", 714, "\"", 757, 1);
#nullable restore
#line 15 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 721, Url.Content("~/images/favicon.png"), 721, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" media=\"screen\" />\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 804, "\"", 860, 1);
#nullable restore
#line 16 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 811, Url.Content("~/vendors/select2/select2.min.css"), 811, 49, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 890, "\"", 972, 1);
#nullable restore
#line 17 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 897, Url.Content("~/vendors/select2-bootstrap-theme/select2-bootstrap.min.css"), 897, 75, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n \r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d10cd5a8071503c7e258c9a54266ce4b481ba5d11323", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 21 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
      
        List<TourDTO> list = new List<TourDTO>();
        List<LoaiTourDTO> listloai = new List<LoaiTourDTO>();
        TourBUS bus = new TourBUS();
        LoaiTourBUS busloai = new LoaiTourBUS();
        list = bus.List();
        listloai = busloai.List();
    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <div class=""container-scroller"">
        <nav class=""navbar col-lg-12 col-12 p-0 fixed-top d-flex flex-row"">
            <div class=""text-center navbar-brand-wrapper d-flex align-items-center justify-content-center"">
                <a class=""navbar-brand brand-logo-mini"" href=""index.html"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2d10cd5a8071503c7e258c9a54266ce4b481ba5d12347", async() => {
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
                WriteLiteral(@"</a>
                <button class=""navbar-toggler navbar-toggler align-self-center d-none d-lg-flex"" type=""button"" data-toggle=""minimize"">
                    <span class=""typcn typcn-th-menu""></span>
                </button>
            </div>
            <div class=""navbar-menu-wrapper d-flex align-items-center justify-content-end"">
                <ul class=""navbar-nav mr-lg-2"">
                   
                </ul>
            </div>
        </nav>

        <div class=""container-fluid page-body-wrapper"">

            <nav class=""sidebar sidebar-offcanvas"" id=""sidebar"">
                <ul class=""nav"">
                    <li class=""nav-item"">
                        <div class=""d-flex sidebar-profile"">
                            <div class=""sidebar-profile-image"">
                                <img src=""images/faces/face29.png"" alt=""image"">
                                <span class=""sidebar-status-indicator""></span>
                            </div>
                      ");
                WriteLiteral(@"      <div class=""sidebar-profile-name"">
                                <p class=""sidebar-name"">
                                    Website Quản Lý Tour
                                </p>
                            </div>
                        </div>
                    </li>
                    <li class=""nav-item"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d10cd5a8071503c7e258c9a54266ce4b481ba5d14974", async() => {
                    WriteLiteral("\r\n                            <i class=\"typcn typcn-document-text menu-icon\"></i>\r\n                            <span class=\"menu-title\">Quản Lý Tour</span>\r\n                            <i class=\"menu-arrow\"></i>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </li>\r\n                    <hr />\r\n                    <li class=\"nav-item\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d10cd5a8071503c7e258c9a54266ce4b481ba5d16654", async() => {
                    WriteLiteral("\r\n                            <i class=\"typcn typcn-globe-outline menu-icon\"></i>\r\n                            <span class=\"menu-title\">Quản Lý Nhân Viên</span>\r\n                            <i class=\"menu-arrow\"></i>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </li>\r\n                    <hr />\r\n                    <li class=\"nav-item\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d10cd5a8071503c7e258c9a54266ce4b481ba5d18339", async() => {
                    WriteLiteral("\r\n                            <i class=\"typcn typcn-document-text menu-icon\"></i>\r\n                            <span class=\"menu-title\">Quản Lý Khách Hàng</span>\r\n                            <i class=\"menu-arrow\"></i>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </li>\r\n                    <hr />\r\n                    <li class=\"nav-item\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d10cd5a8071503c7e258c9a54266ce4b481ba5d20025", async() => {
                    WriteLiteral("\r\n                            <i class=\"typcn typcn-globe-outline menu-icon\"></i>\r\n                            <span class=\"menu-title\">Quản Lý Đoàn</span>\r\n                            <i class=\"menu-arrow\"></i>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </li>\r\n                    <hr />\r\n                    <li class=\"nav-item\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d10cd5a8071503c7e258c9a54266ce4b481ba5d21705", async() => {
                    WriteLiteral("\r\n                            <i class=\"typcn typcn-globe-outline menu-icon\"></i>\r\n                            <span class=\"menu-title\">Quản Lý Phân Công</span>\r\n                            <i class=\"menu-arrow\"></i>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </li>\r\n                    <hr />\r\n                    <li class=\"nav-item\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d10cd5a8071503c7e258c9a54266ce4b481ba5d23390", async() => {
                    WriteLiteral("\r\n                            <i class=\"typcn typcn-document-text menu-icon\"></i>\r\n                            <span class=\"menu-title\">Quản Lý Địa Điểm</span>\r\n                            <i class=\"menu-arrow\"></i>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </li>\r\n                    <hr />\r\n                    <li class=\"nav-item\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d10cd5a8071503c7e258c9a54266ce4b481ba5d25074", async() => {
                    WriteLiteral("\r\n                            <i class=\"typcn typcn-globe-outline menu-icon\"></i>\r\n                            <span class=\"menu-title\">Quản Lý Giá</span>\r\n                            <i class=\"menu-arrow\"></i>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n            </nav>\r\n\r\n            <!-- Phần dùng riêng-->\r\n            ");
#nullable restore
#line 120 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n        </div>\r\n    </div>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 6000, "\"", 6056, 1);
#nullable restore
#line 125 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 6006, Url.Content("~/vendors/js/vendor.bundle.base.js"), 6006, 50, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 6080, "\"", 6120, 1);
#nullable restore
#line 126 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 6086, Url.Content("~/js/off-canvas.js"), 6086, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 6144, "\"", 6192, 1);
#nullable restore
#line 127 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 6150, Url.Content("~/js/hoverable-collapse.js"), 6150, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 6216, "\"", 6254, 1);
#nullable restore
#line 128 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 6222, Url.Content("~/js/template.js"), 6222, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 6278, "\"", 6316, 1);
#nullable restore
#line 129 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 6284, Url.Content("~/js/settings.js"), 6284, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 6340, "\"", 6378, 1);
#nullable restore
#line 130 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 6346, Url.Content("~/js/todolist.js"), 6346, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 6402, "\"", 6467, 1);
#nullable restore
#line 131 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 6408, Url.Content("~/vendors/progressbar.js/progressbar.min.js"), 6408, 59, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 6491, "\"", 6544, 1);
#nullable restore
#line 132 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 6497, Url.Content("~/vendors/chart.js/Chart.min.js"), 6497, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 6568, "\"", 6607, 1);
#nullable restore
#line 133 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 6574, Url.Content("~/js/dashboard.js"), 6574, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 6631, "\"", 6699, 1);
#nullable restore
#line 134 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 6637, Url.Content("~/vendors/typeahead.js/typeahead.bundle.min.js"), 6637, 62, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 6723, "\"", 6777, 1);
#nullable restore
#line 135 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 6729, Url.Content("~/vendors/select2/select2.min.js"), 6729, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 6801, "\"", 6842, 1);
#nullable restore
#line 136 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 6807, Url.Content("~/js/file-upload.js"), 6807, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 6866, "\"", 6905, 1);
#nullable restore
#line 137 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 6872, Url.Content("~/js/typeahead.js"), 6872, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 6929, "\"", 6966, 1);
#nullable restore
#line 138 "D:\git\QuanLyTourDuLich\WebForm\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 6935, Url.Content("~/js/select2.js"), 6935, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
