#pragma checksum "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Teacher\IndexV3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "126c925542c821b0f037d77ddf5e2616a0c875e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_IndexV3), @"mvc.1.0.view", @"/Views/Teacher/IndexV3.cshtml")]
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
#line 1 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\_ViewImports.cshtml"
using Htest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\_ViewImports.cshtml"
using Htest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Teacher\IndexV3.cshtml"
using Htest.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"126c925542c821b0f037d77ddf5e2616a0c875e2", @"/Views/Teacher/IndexV3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"340edf49ce5be9d2c272bf3756ea67cfcfd10a24", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_IndexV3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentClassesDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Teacher\IndexV3.cshtml"
  
    ViewData["Title"] = "Home Page";
    HClass selectedClass = null;
    if(Model.SelectedClass != null) {
        selectedClass = Model.SelectedClass;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    #selection-students-wrapper .list-group-item {
        display: flex;
        border: none;
        border-bottom: 1px solid #eee;
    }

    #selection-students-wrapper .list-group-item:hover {
       background-color: #fafafa;
    }

    #selection-students-wrapper .avatar {
        height: 32px;
        width: 32px;
        border-radius: 100%;
        background-color: #2196f3;
        color: #fff;
        display: flex;
        justify-content: center;
        align-items: center;
    }

    #selection-students-wrapper .student-achievement-button,
    #selection-students-wrapper .student-endeavour-button {
        color: #bbb;
        cursor: pointer;
    }

    #selection-students-wrapper .student-achievement-button:hover,
    #selection-students-wrapper .student-endeavour-button:hover {
        color:  #2196f3;
    }

    .input-group-text {
        background-color: #2196f3;
        color: #fff;
    }

    .toast {
        min-width: 290px ;
    }");
            WriteLiteral("\n\r\n</style>\r\n    <div class=\"select-wrapper\" style=\"position: relative;\">\r\n        \r\n\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Select Awards</h1>\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 1468, "\"", 1476, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "126c925542c821b0f037d77ddf5e2616a0c875e25607", async() => {
                WriteLiteral(@"
                <div class=""form-row align-items-center justify-content-end mb-4"">
                    <div class=""col-9 col-md-5 col-lg-3 my-1"">
                    <label class=""mr-sm-2 sr-only"" for=""inlineFormCustomSelect"">Class Selection</label>
                    <div class=""input-group"">
                        <div class=""input-group-prepend"">
                            <div class=""input-group-text""><i class=""fas fa-circle-notch fa-spin""></i></div>
                        </div>  
                       
                        <select class=""custom-select mr-sm-2"" id=""ClassSelect"" name=""classRef"">
");
#nullable restore
#line 71 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Teacher\IndexV3.cshtml"
                             foreach(var Class in Model.classes) {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Teacher\IndexV3.cshtml"
                                 if(Class == selectedClass) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "126c925542c821b0f037d77ddf5e2616a0c875e27078", async() => {
#nullable restore
#line 73 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Teacher\IndexV3.cshtml"
                                                                  Write(Class.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Teacher\IndexV3.cshtml"
                                               WriteLiteral(Class.Name);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 74 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Teacher\IndexV3.cshtml"
                                }
                                else {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "126c925542c821b0f037d77ddf5e2616a0c875e29632", async() => {
#nullable restore
#line 76 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Teacher\IndexV3.cshtml"
                                                         Write(Class.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Teacher\IndexV3.cshtml"
                                      WriteLiteral(Class.Name);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 77 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Teacher\IndexV3.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Teacher\IndexV3.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </select>
                    </div>
                    <div class=""col-auto my-1"">
                        <button id=""btn-submit"" type=""submit"" class=""btn btn-primary d-none"">SELECT</button>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row mt-4\" id=\"selection-students-wrapper\">\r\n            <div class=\"col-12\">\r\n");
#nullable restore
#line 89 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Teacher\IndexV3.cshtml"
             if(Model.students != null) {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Teacher\IndexV3.cshtml"
                 foreach (var student in Model.students)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <ul class=""list-group"">
                            <li class = ""list-group-item justify-content-between align-items-center""> 
                                <div class=""d-flex align-items-center"">
                                    <div class=""mr-3 avatar"">");
#nullable restore
#line 95 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Teacher\IndexV3.cshtml"
                                                        Write(String.Format("{0}{1}", @student.firstName.ToUpper()[0], @student.secondName.ToUpper()[0]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    <div class=\"student-name\">");
#nullable restore
#line 96 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Teacher\IndexV3.cshtml"
                                                         Write(student.secondName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 96 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Teacher\IndexV3.cshtml"
                                                                              Write(student.firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                </div>
                                <div class=""d-flex align-items-center"">
                                    <div class=""mr-4 student-achievement-button"">Achievement</div>
                                    <div class=""student-endeavour-button"">Endeavour</div>
                                </div>
                                
                            </li>
                    </ul>
");
#nullable restore
#line 105 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Teacher\IndexV3.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Teacher\IndexV3.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>
<!-- Position it -->
<!-- Position should be right: 40px but means I can't change class before selecting students-->
<div style=""position: fixed; top: 90px; left: 40px;"">
    <div id=""achievement-award-toast"" class=""toast"" data-delay=""4000""");
            BeginWriteAttribute("style", " style=\"", 4380, "\"", 4388, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""toast-header"">
        <strong class=""mr-auto text-primary"">Information</strong>
        </div>
        <div class=""toast-body"">
            Student Achievement Award Saved Ok
        </div>
    </div>

    <div id=""endeavour-award-toast"" class=""toast"" data-delay=""4000""");
            BeginWriteAttribute("style", " style=\"", 4690, "\"", 4698, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"toast-header\">\r\n        <strong class=\"mr-auto text-primary\">Information</strong>\r\n        </div>\r\n        <div class=\"toast-body\">\r\n            Student Endeavour Award Saved Ok\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function() {
           
            $("".input-group-text i"").removeClass(""fa-circle-notch fa-spin"").addClass(""fa-list"")
            $(""#ClassSelect"").change(function() {
                // $('#teacher-award-toast').toast('show'); // for later use when posting award selecting. Just testing Bootstrap toasts.
                $("".fa-upload"").removeClass(""d-none"")
                $("".input-group-text i"").removeClass(""fa-list"").addClass(""fa-circle-notch fa-spin"")
                $(""#btn-submit"").click()
            });

            $("".student-achievement-button"").on(""click"", function() {
                $("".student-achievement-button"").each(function(index, value) {
                    $(this).css({""font-weight"": ""normal"", ""color"": ""#bbb""})
                    $(this).closest(""li"").find("".student-name"").css({""font-weight"": ""normal"", ""color"": ""#bbb""});
                }) 
                $(this).css({""font-weight"": ""bold"", ""color"": ""#2196f3""})
              ");
                WriteLiteral(@"  var li = $(this).closest(""li"").find("".student-name"");
                $(li).css({""font-weight"": ""bold"", ""color"": ""#2196f3""})
                $('#achievement-award-toast').toast('show')
            })

            $("".student-endeavour-button"").on(""click"", function() {
                 $("".student-endeavour-button"").each(function(index, value) {
                    $(this).css({""font-weight"": ""normal"", ""color"": ""#bbb""})
                    $(this).closest(""li"").find("".student-name"").css({""font-weight"": ""normal"", ""color"": ""#bbb""});
                })
                $(this).css({""font-weight"": ""bold"", ""color"": ""#2196f3""})
                 var li = $(this).closest(""li"").find("".student-name"");
                $(li).css({""font-weight"": ""bold"", ""color"": ""#2196f3""})
                $('#endeavour-award-toast').toast('show')
            })
        });

     </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentClassesDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
