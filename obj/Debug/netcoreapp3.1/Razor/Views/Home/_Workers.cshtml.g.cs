#pragma checksum "C:\Users\Dominik\source\repos\HomeworkFromKPMG\HomeworkFromKPMG\Views\Home\_Workers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8322c32f102f24e33047f5368531670f93ba902d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Workers), @"mvc.1.0.view", @"/Views/Home/_Workers.cshtml")]
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
#line 1 "C:\Users\Dominik\source\repos\HomeworkFromKPMG\HomeworkFromKPMG\Views\_ViewImports.cshtml"
using HomeworkFromKPMG;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dominik\source\repos\HomeworkFromKPMG\HomeworkFromKPMG\Views\_ViewImports.cshtml"
using HomeworkFromKPMG.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dominik\source\repos\HomeworkFromKPMG\HomeworkFromKPMG\Views\_ViewImports.cshtml"
using HomeworkFromKPMG.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8322c32f102f24e33047f5368531670f93ba902d", @"/Views/Home/_Workers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5718d3b8c69240569f848222afdb564280ecf411", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__Workers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllWorkersVM>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <div class=""col-sm-10 row mx-auto"">


        <div class=""col-sm-6 container   pb-2 text-center"">
            <div class=""display-4"">Managers</div>

            <div class=""card blockquote  mt-4 p-3"">
                <div class=""row"">
                    <div class=""col-sm-2  "">
                        Id
                    </div>
                    <div class=""col-sm-4"">
                        Name
                    </div>
                    <div class=""col-sm-3"">
                        Since
                    </div>
                    <div class=""col-sm-3"">
                        Team
                    </div>
                </div>
            </div>

");
#nullable restore
#line 26 "C:\Users\Dominik\source\repos\HomeworkFromKPMG\HomeworkFromKPMG\Views\Home\_Workers.cshtml"
             foreach (var manager in Model.Managers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card m-3 img-thumbnail shadow-sm \">\r\n                    <div class=\"row  \">\r\n                        <div class=\"col-sm-1 text-center\">\r\n                            ");
#nullable restore
#line 31 "C:\Users\Dominik\source\repos\HomeworkFromKPMG\HomeworkFromKPMG\Views\Home\_Workers.cshtml"
                       Write(manager.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-sm-4\">\r\n                            ");
#nullable restore
#line 34 "C:\Users\Dominik\source\repos\HomeworkFromKPMG\HomeworkFromKPMG\Views\Home\_Workers.cshtml"
                       Write(manager.ManagerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 34 "C:\Users\Dominik\source\repos\HomeworkFromKPMG\HomeworkFromKPMG\Views\Home\_Workers.cshtml"
                                            Write(manager.ManagerSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-sm-3\">\r\n                            ");
#nullable restore
#line 37 "C:\Users\Dominik\source\repos\HomeworkFromKPMG\HomeworkFromKPMG\Views\Home\_Workers.cshtml"
                       Write(manager.ManagerEmployment.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-sm-4 \">\r\n                            <select class=\"form-control \">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8322c32f102f24e33047f5368531670f93ba902d6011", async() => {
                WriteLiteral("Team");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\Dominik\source\repos\HomeworkFromKPMG\HomeworkFromKPMG\Views\Home\_Workers.cshtml"
                                 foreach(var employees in manager.Employees)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8322c32f102f24e33047f5368531670f93ba902d7319", async() => {
#nullable restore
#line 44 "C:\Users\Dominik\source\repos\HomeworkFromKPMG\HomeworkFromKPMG\Views\Home\_Workers.cshtml"
                                       Write(employees.EmployeeName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 44 "C:\Users\Dominik\source\repos\HomeworkFromKPMG\HomeworkFromKPMG\Views\Home\_Workers.cshtml"
                                                               Write(employees.EmployeeSurname);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\Users\Dominik\source\repos\HomeworkFromKPMG\HomeworkFromKPMG\Views\Home\_Workers.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </select>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 50 "C:\Users\Dominik\source\repos\HomeworkFromKPMG\HomeworkFromKPMG\Views\Home\_Workers.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>

        <div class=""col-sm-6 container  pb-2 text-center"">
            <div class=""display-4"">Employees</div>

            <div class=""card blockquote  mt-4 p-3"">
                <div class=""row"">
                    <div class=""col-sm-2 "">
                        Id
                    </div>
                    <div class=""col-sm-4"">
                        Name
                    </div>
                    <div class=""col-sm-3"">
                        Since
                    </div>
                    <div class=""col-sm-3"">
                        Manager
                    </div>

                </div>
            </div>

");
#nullable restore
#line 74 "C:\Users\Dominik\source\repos\HomeworkFromKPMG\HomeworkFromKPMG\Views\Home\_Workers.cshtml"
             foreach (var employe in Model.Employees)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card m-2 img-thumbnail shadow-sm\">\r\n                    <div class=\"row  \">\r\n                        <div class=\"col-sm-2 \">\r\n                            ");
#nullable restore
#line 79 "C:\Users\Dominik\source\repos\HomeworkFromKPMG\HomeworkFromKPMG\Views\Home\_Workers.cshtml"
                       Write(employe.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-sm-4\">\r\n                            ");
#nullable restore
#line 82 "C:\Users\Dominik\source\repos\HomeworkFromKPMG\HomeworkFromKPMG\Views\Home\_Workers.cshtml"
                       Write(employe.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 82 "C:\Users\Dominik\source\repos\HomeworkFromKPMG\HomeworkFromKPMG\Views\Home\_Workers.cshtml"
                                             Write(employe.EmployeeSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-sm-3\">\r\n                            ");
#nullable restore
#line 85 "C:\Users\Dominik\source\repos\HomeworkFromKPMG\HomeworkFromKPMG\Views\Home\_Workers.cshtml"
                       Write(employe.DateEmployment.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-sm-3 \">\r\n                            ");
#nullable restore
#line 88 "C:\Users\Dominik\source\repos\HomeworkFromKPMG\HomeworkFromKPMG\Views\Home\_Workers.cshtml"
                       Write(employe.Manager.ManagerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 88 "C:\Users\Dominik\source\repos\HomeworkFromKPMG\HomeworkFromKPMG\Views\Home\_Workers.cshtml"
                                                    Write(employe.Manager.ManagerSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 92 "C:\Users\Dominik\source\repos\HomeworkFromKPMG\HomeworkFromKPMG\Views\Home\_Workers.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllWorkersVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
