#pragma checksum "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1126f1691259920036c6772cd4583917e645fb53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Index.cshtml", typeof(AspNetCore.Views_Student_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1126f1691259920036c6772cd4583917e645fb53", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb32006c3eaf874b490c70bf47ea0b0cfd5fb01d", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentSlotTableViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CancelBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
  
    ViewData["Title"] = "Slot List";

#line default
#line hidden
            BeginContext(81, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(88, 17, false);
#line 7 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(105, 47, true);
            WriteLiteral("</h2>\r\n<h2>Manage Your Booking</h2>\r\n<br />\r\n\r\n");
            EndContext();
            BeginContext(152, 184, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5559e90d5f6c46c89c403c24424e5308", async() => {
                BeginContext(177, 152, true);
                WriteLiteral("\r\n    <p>\r\n        Search Available Slots by Staff: <input type=\"text\" name=\"StaffSearchString\">\r\n        <input type=\"submit\" value=\"Go\" />\r\n    </p>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(336, 52, true);
            WriteLiteral("\r\n\r\n<br />\r\n<br />\r\n\r\n<div class=\"form-group\">\r\n    ");
            EndContext();
            BeginContext(389, 100, false);
#line 22 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
Write(Html.LabelFor(x => Model.SelectedStaffID, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(489, 38, true);
            WriteLiteral("\r\n    <div class=\"col-md-5\">\r\n        ");
            EndContext();
            BeginContext(528, 174, false);
#line 24 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
   Write(Html.DropDownListFor(x => Model.StaffIDNames, new SelectList(Model.StaffIDNames, "Text"),
             htmlAttributes: new { @class = "form-control", id = "SelectedStaff" }));

#line default
#line hidden
            EndContext();
            BeginContext(702, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(726, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5176e473b2c34dd28450aec8bb7cbe45", async() => {
                BeginContext(801, 6, true);
                WriteLiteral("Search");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-StaffSearchString", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
                                       WriteLiteral(Model.SelectedStaffID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["StaffSearchString"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-StaffSearchString", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["StaffSearchString"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(811, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(815, 537, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba390c3896fc4ca09a2ae2de5b2d3022", async() => {
                BeginContext(821, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 32 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
     using (Html.BeginForm("Index", "Student", FormMethod.Post))
    {

#line default
#line hidden
                BeginContext(896, 144, true);
                WriteLiteral("        <table cellpadding=\"0\" cellspacing=\"0\">\r\n            <tr>\r\n                <td>Gender: </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1041, 105, false);
#line 38 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
               Write(Html.DropDownListFor(m => m.SelectedStaffID, new SelectList(Model.StaffIDNames, "Text"), "Please select"));

#line default
#line hidden
                EndContext();
                BeginContext(1146, 192, true);
                WriteLiteral("\r\n                </td>\r\n            </tr> \r\n            <tr>\r\n                <td></td>\r\n                <td><input type=\"submit\" value=\"Submit\" /></td>\r\n            </tr>\r\n        </table>\r\n");
                EndContext();
#line 46 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
    }

#line default
#line hidden
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
            EndContext();
            BeginContext(1352, 110, true);
            WriteLiteral("\r\n\r\n<br />\r\n<br />\r\n\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1463, 65, false);
#line 58 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Slots.FirstOrDefault().RoomID));

#line default
#line hidden
            EndContext();
            BeginContext(1528, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1584, 68, false);
#line 61 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Slots.FirstOrDefault().StartTime));

#line default
#line hidden
            EndContext();
            BeginContext(1652, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1708, 66, false);
#line 64 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Slots.FirstOrDefault().StaffID));

#line default
#line hidden
            EndContext();
            BeginContext(1774, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1830, 68, false);
#line 67 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Slots.FirstOrDefault().StudentID));

#line default
#line hidden
            EndContext();
            BeginContext(1898, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 72 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
         foreach (var item in Model.Slots)
        {

#line default
#line hidden
            BeginContext(2016, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2077, 41, false);
#line 76 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.RoomID));

#line default
#line hidden
            EndContext();
            BeginContext(2118, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2186, 44, false);
#line 79 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StartTime));

#line default
#line hidden
            EndContext();
            BeginContext(2230, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2298, 42, false);
#line 82 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StaffID));

#line default
#line hidden
            EndContext();
            BeginContext(2340, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 85 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
                     if (item.StudentID != null)
                    {
                        

#line default
#line hidden
            BeginContext(2485, 44, false);
#line 87 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.StudentID));

#line default
#line hidden
            EndContext();
#line 87 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
                                                                     ;

#line default
#line hidden
            BeginContext(2532, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2556, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfe6250b5c344be3989476434103a01a", async() => {
                BeginContext(2653, 11, true);
                WriteLiteral("Cancel Book");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-roomid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 88 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
                                                         WriteLiteral(item.RoomID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roomid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-roomid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roomid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 88 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
                                                                                            WriteLiteral(item.StartTime);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["starttime"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-starttime", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["starttime"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2668, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 89 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2742, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2766, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea4c322faa1046ee87bbff49b4895283", async() => {
                BeginContext(2857, 4, true);
                WriteLiteral("Book");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-roomid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 92 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
                                                   WriteLiteral(item.RoomID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roomid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-roomid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roomid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 92 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
                                                                                      WriteLiteral(item.StartTime);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["starttime"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-starttime", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["starttime"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2865, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 93 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2890, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 96 "D:\WDT\AsrSystemApp\AsrSystem\AsrSystem\Views\Student\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2943, 42, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<br />\r\n<br />\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentSlotTableViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
