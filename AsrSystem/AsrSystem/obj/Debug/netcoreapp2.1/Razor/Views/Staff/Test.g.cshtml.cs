#pragma checksum "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Staff\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "637f82c2cbd32d66e76ba01795f1afca02223d0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_Test), @"mvc.1.0.view", @"/Views/Staff/Test.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Staff/Test.cshtml", typeof(AspNetCore.Views_Staff_Test))]
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
#line 1 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\_ViewImports.cshtml"
using AsrSystem;

#line default
#line hidden
#line 2 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\_ViewImports.cshtml"
using AsrSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"637f82c2cbd32d66e76ba01795f1afca02223d0e", @"/Views/Staff/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb32006c3eaf874b490c70bf47ea0b0cfd5fb01d", @"/Views/_ViewImports.cshtml")]
    public class Views_Staff_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AsrSystem.Models.Slot>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Staff\Test.cshtml"
  
    ViewData["Title"] = "Test";

#line default
#line hidden
            BeginContext(72, 479, true);
            WriteLiteral(@"<link rel=""stylesheet"" href=""//code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css"">
<script src=""//code.jquery.com/jquery-1.10.2.js""></script>
<script src=""//code.jquery.com/ui/1.11.4/jquery-ui.js""></script>

<script>

    $(document).ready(function () {
        $(""#EnterDate"").datepicker({
            dateFormat: ""dd-mm-yy"",
            minDate: -0,
            maxDate: ""+0M +0D""

        });
    });
</script>

<h2>Test</h2>

<h4>Slot</h4>
<hr />
");
            EndContext();
#line 26 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Staff\Test.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(586, 23, false);
#line 28 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Staff\Test.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(613, 61, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(675, 64, false);
#line 33 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Staff\Test.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(739, 48, true);
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(788, 98, false);
#line 35 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Staff\Test.cshtml"
       Write(Html.LabelFor(model => model.StartTime, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(886, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(942, 98, false);
#line 37 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Staff\Test.cshtml"
           Write(Html.EditorFor(model => model.StartTime, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1040, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1059, 87, false);
#line 38 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Staff\Test.cshtml"
           Write(Html.ValidationMessageFor(model => model.StartTime, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1146, 54, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n");
            EndContext();
#line 44 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Staff\Test.cshtml"
}

#line default
#line hidden
            BeginContext(2705, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2725, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 78 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Staff\Test.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AsrSystem.Models.Slot> Html { get; private set; }
    }
}
#pragma warning restore 1591
