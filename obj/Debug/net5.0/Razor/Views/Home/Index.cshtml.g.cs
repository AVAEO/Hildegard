#pragma checksum "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "914c79d9ca100c10d5c3eeb71a0fed63557bf120"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"914c79d9ca100c10d5c3eeb71a0fed63557bf120", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"340edf49ce5be9d2c272bf3756ea67cfcfd10a24", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Htest.Models.HClass>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <ul class = \"list-group\">\r\n");
#nullable restore
#line 10 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Home\Index.cshtml"
         foreach (var hclass in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <li class = \"list-group-item\">\r\n                ");
#nullable restore
#line 13 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Home\Index.cshtml"
           Write(hclass.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           </li> \r\n");
#nullable restore
#line 15 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Htest.Models.HClass>> Html { get; private set; }
    }
}
#pragma warning restore 1591
