#pragma checksum "C:\Angular repo\angular-repo-1\AngularMythics\Areas\Admin\Views\Shared\_StatsLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbe9278440e8eeefef7ed838d71c6822db02b262"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AngularMythics.Areas.Admin.Views.Shared.Areas_Admin_Views_Shared__StatsLayout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_StatsLayout.cshtml")]
namespace AngularMythics.Areas.Admin.Views.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbe9278440e8eeefef7ed838d71c6822db02b262", @"/Areas/Admin/Views/Shared/_StatsLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"131fb08f030778809319f3f66b5dbe307b547b03", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__StatsLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModelService.AdminBaseViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col"">
            <!-- Content Row -->
            <div class=""row"">
                <!-- Schedule Task Processing -->
                <div class=""col-xl-3 col-md-6 mb-4"">
                    <div class=""card border-left-primary shadow h-100 py-2"">
                        <div class=""card-body"">
                            <div class=""row no-gutters align-items-center"">
                                <div class=""col mr-2"">
                                    <div class=""text-xs font-weight-bold text-dark text-uppercase mb-1"">Total Users</div>
                                    <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 14 "C:\Angular repo\angular-repo-1\AngularMythics\Areas\Admin\Views\Shared\_StatsLayout.cshtml"
                                                                                   Write(Model.Dashboard.TotalUsers);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                </div>
                                <div class=""col-auto"">
                                    <i class=""fas fa-users fa-2x text-gray-300""></i>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Schedule Task Count -->
                <div class=""col-xl-3 col-md-6 mb-4"">
                    <div class=""card border-left-warning shadow h-100 py-2"">
                        <div class=""card-body"">
                            <div class=""row no-gutters align-items-center"">
                                <div class=""col mr-2"">
                                    <div class=""text-xs font-weight-bold text-dark text-uppercase mb-1"">New Users</div>
                                    <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 30 "C:\Angular repo\angular-repo-1\AngularMythics\Areas\Admin\Views\Shared\_StatsLayout.cshtml"
                                                                                   Write(Model.Dashboard.NewUsers);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                </div>
                                <div class=""col-auto"">
                                    <i class=""fas fa-user-friends fa-2x text-gray-300""></i>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Schedule Task Stuck -->
                <div class=""col-xl-3 col-md-6 mb-4"">
                    <div class=""card border-left-success shadow h-100 py-2"">
                        <div class=""card-body"">
                            <div class=""row no-gutters align-items-center"">
                                <div class=""col mr-2"">
                                    <div class=""text-xs font-weight-bold text-dark text-uppercase mb-1"">Total Posts</div>
                                    <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 46 "C:\Angular repo\angular-repo-1\AngularMythics\Areas\Admin\Views\Shared\_StatsLayout.cshtml"
                                                                                   Write(Model.Dashboard.TotalPosts);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                </div>
                                <div class=""col-auto"">
                                    <i class=""fas fa-blog fa-2x text-gray-300""></i>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Schedule Task Failed -->
                <div class=""col-xl-3 col-md-6 mb-4"">
                    <div class=""card border-left-secondary shadow h-100 py-2"">
                        <div class=""card-body"">
                            <div class=""row no-gutters align-items-center"">
                                <div class=""col mr-2"">
                                    <div class=""text-xs font-weight-bold text-dark text-uppercase mb-1"">Pending Approval</div>
                                    <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 62 "C:\Angular repo\angular-repo-1\AngularMythics\Areas\Admin\Views\Shared\_StatsLayout.cshtml"
                                                                                   Write(Model.Dashboard.PendingRequests);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                </div>
                                <div class=""col-auto"">
                                    <i class=""fas fa-thumbs-up fa-2x text-gray-300""></i>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>


            </div>
        </div>
    </div>

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModelService.AdminBaseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
