#pragma checksum "C:\Users\Administrator\source\repos\Ninestars\Ninestars\Areas\Admin\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "833ba070d678e703783b25861262d208013c2955"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\Administrator\source\repos\Ninestars\Ninestars\Areas\Admin\Views\_ViewImports.cshtml"
using DAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"833ba070d678e703783b25861262d208013c2955", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a081f5a5081a68200c247d1e9d82762bc6dda074", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "slider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "833ba070d678e703783b25861262d208013c29554303", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <title>Majestic Admin</title>
    <!-- plugins:css -->
    <link rel=""stylesheet"" href=""/admin/vendors/mdi/css/materialdesignicons.min.css"">
    <link rel=""stylesheet"" href=""/admin/vendors/base/vendor.bundle.base.css"">
    <!-- endinject -->
    <!-- plugin css for this page -->
    <link rel=""stylesheet"" href=""/admin/vendors/datatables.net-bs4/dataTables.bootstrap4.css"">
    <!-- End plugin css for this page -->
    <!-- inject:css -->
    <link rel=""stylesheet"" href=""/admin/css/style.css"">
    <!-- endinject -->
    <link rel=""shortcut icon"" href=""/admin/images/favicon.png"" />
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "833ba070d678e703783b25861262d208013c29556049", async() => {
                WriteLiteral(@"
    <div class=""container-scroller"">
        <!-- partial:partials/_navbar.html -->
        <nav class=""navbar col-lg-12 col-12 p-0 fixed-top d-flex flex-row"">
            <div class=""navbar-brand-wrapper d-flex justify-content-center"">
                <div class=""navbar-brand-inner-wrapper d-flex justify-content-between align-items-center w-100"">
                    <a class=""navbar-brand brand-logo"" href=""index.html""><img src=""/admin/images/logo.svg"" alt=""logo"" /></a>
                    <a class=""navbar-brand brand-logo-mini"" href=""index.html""><img src=""/admin/images/logo-mini.svg"" alt=""logo"" /></a>
                    <button class=""navbar-toggler navbar-toggler align-self-center"" type=""button"" data-toggle=""minimize"">
                        <span class=""mdi mdi-sort-variant""></span>
                    </button>
                </div>
            </div>
            <div class=""navbar-menu-wrapper d-flex align-items-center justify-content-end"">
                <ul class=""navbar-nav mr-lg-4 ");
                WriteLiteral(@"w-100"">
                    <li class=""nav-item nav-search d-none d-lg-block w-100"">
                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text"" id=""search"">
                                    <i class=""mdi mdi-magnify""></i>
                                </span>
                            </div>
                            <input type=""text"" class=""form-control"" placeholder=""Search now"" aria-label=""search"" aria-describedby=""search"">
                        </div>
                    </li>
                </ul>
                <ul class=""navbar-nav navbar-nav-right"">
                    <li class=""nav-item dropdown mr-1"">
                        <a class=""nav-link count-indicator dropdown-toggle d-flex justify-content-center align-items-center"" id=""messageDropdown"" href=""#"" data-toggle=""dropdown"">
                            <i class=""mdi mdi-message-text mx-0""></i>
           ");
                WriteLiteral(@"                 <span class=""count""></span>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right navbar-dropdown"" aria-labelledby=""messageDropdown"">
                            <p class=""mb-0 font-weight-normal float-left dropdown-header"">Messages</p>
                            <a class=""dropdown-item"">
                                <div class=""item-thumbnail"">
                                    <img src=""/admin/images/faces/face4.jpg"" alt=""image"" class=""profile-pic"">
                                </div>
                                <div class=""item-content flex-grow"">
                                    <h6 class=""ellipsis font-weight-normal"">
                                        David Grey
                                    </h6>
                                    <p class=""font-weight-light small-text text-muted mb-0"">
                                        The meeting is cancelled
                                    </p>
        ");
                WriteLiteral(@"                        </div>
                            </a>
                            <a class=""dropdown-item"">
                                <div class=""item-thumbnail"">
                                    <img src=""/admin/images/faces/face2.jpg"" alt=""image"" class=""profile-pic"">
                                </div>
                                <div class=""item-content flex-grow"">
                                    <h6 class=""ellipsis font-weight-normal"">
                                        Tim Cook
                                    </h6>
                                    <p class=""font-weight-light small-text text-muted mb-0"">
                                        New product launch
                                    </p>
                                </div>
                            </a>
                            <a class=""dropdown-item"">
                                <div class=""item-thumbnail"">
                                    <img src=""/admin/images/fa");
                WriteLiteral(@"ces/face3.jpg"" alt=""image"" class=""profile-pic"">
                                </div>
                                <div class=""item-content flex-grow"">
                                    <h6 class=""ellipsis font-weight-normal"">
                                        Johnson
                                    </h6>
                                    <p class=""font-weight-light small-text text-muted mb-0"">
                                        Upcoming board meeting
                                    </p>
                                </div>
                            </a>
                        </div>
                    </li>
                    <li class=""nav-item dropdown mr-4"">
                        <a class=""nav-link count-indicator dropdown-toggle d-flex align-items-center justify-content-center notification-dropdown"" id=""notificationDropdown"" href=""#"" data-toggle=""dropdown"">
                            <i class=""mdi mdi-bell mx-0""></i>
                            <span c");
                WriteLiteral(@"lass=""count""></span>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right navbar-dropdown"" aria-labelledby=""notificationDropdown"">
                            <p class=""mb-0 font-weight-normal float-left dropdown-header"">Notifications</p>
                            <a class=""dropdown-item"">
                                <div class=""item-thumbnail"">
                                    <div class=""item-icon bg-success"">
                                        <i class=""mdi mdi-information mx-0""></i>
                                    </div>
                                </div>
                                <div class=""item-content"">
                                    <h6 class=""font-weight-normal"">Application Error</h6>
                                    <p class=""font-weight-light small-text mb-0 text-muted"">
                                        Just now
                                    </p>
                                </div>
   ");
                WriteLiteral(@"                         </a>
                            <a class=""dropdown-item"">
                                <div class=""item-thumbnail"">
                                    <div class=""item-icon bg-warning"">
                                        <i class=""mdi mdi-settings mx-0""></i>
                                    </div>
                                </div>
                                <div class=""item-content"">
                                    <h6 class=""font-weight-normal"">Settings</h6>
                                    <p class=""font-weight-light small-text mb-0 text-muted"">
                                        Private message
                                    </p>
                                </div>
                            </a>
                            <a class=""dropdown-item"">
                                <div class=""item-thumbnail"">
                                    <div class=""item-icon bg-info"">
                                        <i cla");
                WriteLiteral(@"ss=""mdi mdi-account-box mx-0""></i>
                                    </div>
                                </div>
                                <div class=""item-content"">
                                    <h6 class=""font-weight-normal"">New user registration</h6>
                                    <p class=""font-weight-light small-text mb-0 text-muted"">
                                        2 days ago
                                    </p>
                                </div>
                            </a>
                        </div>
                    </li>
                    <li class=""nav-item nav-profile dropdown"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" data-toggle=""dropdown"" id=""profileDropdown"">
                            <img src=""/admin/images/faces/face5.jpg"" alt=""profile"" />
                            <span class=""nav-profile-name"">Louis Barnett</span>
                        </a>
                        <div class=""dropdown-menu d");
                WriteLiteral(@"ropdown-menu-right navbar-dropdown"" aria-labelledby=""profileDropdown"">
                            <a class=""dropdown-item"">
                                <i class=""mdi mdi-settings text-primary""></i>
                                Settings
                            </a>
                            <a class=""dropdown-item"">
                                <i class=""mdi mdi-logout text-primary""></i>
                                Logout
                            </a>
                        </div>
                    </li>
                </ul>
                <button class=""navbar-toggler navbar-toggler-right d-lg-none align-self-center"" type=""button"" data-toggle=""offcanvas"">
                    <span class=""mdi mdi-menu""></span>
                </button>
            </div>
        </nav>
        <!-- partial -->
        <div class=""container-fluid page-body-wrapper"">
            <!-- partial:partials/_sidebar.html -->
            <nav class=""sidebar sidebar-offcanvas"" id=""sidebar""");
                WriteLiteral(@">
                <ul class=""nav"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""index.html"">
                            <i class=""mdi mdi-home menu-icon""></i>
                            <span class=""menu-title"">Dashboard</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" data-toggle=""collapse"" href=""#ui-basic"" aria-expanded=""false"" aria-controls=""ui-basic"">
                            <i class=""mdi mdi-circle-outline menu-icon""></i>
                            <span class=""menu-title"">UI Elements</span>
                            <i class=""menu-arrow""></i>
                        </a>
                        <div class=""collapse"" id=""ui-basic"">
                            <ul class=""nav flex-column sub-menu"">
                                <li class=""nav-item""> <a class=""nav-link"" href=""pages/ui-features/buttons.html"">Buttons</a></li>
            ");
                WriteLiteral(@"                    <li class=""nav-item""> <a class=""nav-link"" href=""pages/ui-features/typography.html"">Typography</a></li>
                            </ul>
                        </div>
                    </li>
                    <li class=""nav-item"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "833ba070d678e703783b25861262d208013c295517471", async() => {
                    WriteLiteral("\r\n                            <i class=\"mdi mdi-view-headline menu-icon\"></i>\r\n                            <span class=\"menu-title\">Sliders</span>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""pages/charts/chartjs.html"">
                            <i class=""mdi mdi-chart-pie menu-icon""></i>
                            <span class=""menu-title"">Charts</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""pages/tables/basic-table.html"">
                            <i class=""mdi mdi-grid-large menu-icon""></i>
                            <span class=""menu-title"">Tables</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""pages/icons/mdi.html"">
                            <i class=""mdi mdi-emoticon menu-icon""></i>
                            <span class=""menu-title"">Icons</span>
                        </a>
                    </li>
                    <li class=""nav-it");
                WriteLiteral(@"em"">
                        <a class=""nav-link"" data-toggle=""collapse"" href=""#auth"" aria-expanded=""false"" aria-controls=""auth"">
                            <i class=""mdi mdi-account menu-icon""></i>
                            <span class=""menu-title"">User Pages</span>
                            <i class=""menu-arrow""></i>
                        </a>
                        <div class=""collapse"" id=""auth"">
                            <ul class=""nav flex-column sub-menu"">
                                <li class=""nav-item""> <a class=""nav-link"" href=""pages/samples/login.html""> Login </a></li>
                                <li class=""nav-item""> <a class=""nav-link"" href=""pages/samples/login-2.html""> Login 2 </a></li>
                                <li class=""nav-item""> <a class=""nav-link"" href=""pages/samples/register.html""> Register </a></li>
                                <li class=""nav-item""> <a class=""nav-link"" href=""pages/samples/register-2.html""> Register 2 </a></li>
                       ");
                WriteLiteral(@"         <li class=""nav-item""> <a class=""nav-link"" href=""pages/samples/lock-screen.html""> Lockscreen </a></li>
                            </ul>
                        </div>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""documentation/documentation.html"">
                            <i class=""mdi mdi-file-document-box-outline menu-icon""></i>
                            <span class=""menu-title"">Documentation</span>
                        </a>
                    </li>
                </ul>
            </nav>
            <!-- partial -->
            <div class=""main-panel"">
                <div class=""content-wrapper"">

                    ");
#nullable restore
#line 242 "C:\Users\Administrator\source\repos\Ninestars\Ninestars\Areas\Admin\Views\Shared\_Layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
                <!-- content-wrapper ends -->
                <!-- partial:partials/_footer.html -->
                <footer class=""footer"">
                    <div class=""d-sm-flex justify-content-center justify-content-sm-between"">
                        <span class=""text-muted text-center text-sm-left d-block d-sm-inline-block"">Copyright ?? 2018 <a href=""https://www.bootstrapdash.com/"" target=""_blank"">Bootstrapdash</a>. All rights reserved.</span>
                        <span class=""float-none float-sm-right d-block mt-1 mt-sm-0 text-center"">Hand-crafted & made with <i class=""mdi mdi-heart text-danger""></i></span>
                    </div>
                </footer>
                <!-- partial -->
            </div>
            <!-- main-panel ends -->
        </div>
        <!-- page-body-wrapper ends -->
    </div>
    <!-- container-scroller -->
    <!-- plugins:js -->
    <script src=""/admin/vendors/base/vendor.bundle.base.js""></script>
    <!-- endinject -");
                WriteLiteral(@"->
    <!-- Plugin js for this page-->
    <script src=""/admin/vendors/chart.js/Chart.min.js""></script>
    <script src=""/admin/vendors/datatables.net/jquery.dataTables.js""></script>
    <script src=""/admin/vendors/datatables.net-bs4/dataTables.bootstrap4.js""></script>
    <!-- End plugin js for this page-->
    <!-- inject:js -->
    <script src=""/admin/js/off-canvas.js""></script>
    <script src=""/admin/js/hoverable-collapse.js""></script>
    <script src=""/admin/js/template.js""></script>
    <!-- endinject -->
    <!-- Custom js for this page-->
    <script src=""/admin/js/dashboard.js""></script>
    <script src=""/admin/js/data-table.js""></script>
    <script src=""/admin/js/jquery.dataTables.js""></script>
    <script src=""/admin/js/dataTables.bootstrap4.js""></script>
    <!-- End custom js for this page-->
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
            WriteLiteral("\r\n\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
