#pragma checksum "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cca268064de6fc69b09218a73ba4e4b9dcebe69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
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
#line 1 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\_ViewImports.cshtml"
using Vidly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\_ViewImports.cshtml"
using Vidly.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cca268064de6fc69b09218a73ba4e4b9dcebe69", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5f1cd008877cdb7a8309a52d389048c655f591a", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>Movies</h3>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Movie\Index.cshtml"
Write(Html.ActionLink("New","New","Movie",null, new {@class = "btn btn-primary"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Movie\Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>No hay peliculas</h2>\r\n");
#nullable restore
#line 13 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Movie\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-hover"">

        <thead>
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Name </th>
            <th scope=""col"">Genre </th>
            <th scope=""col"">Action </th>

        </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 28 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Movie\Index.cshtml"
         foreach (var movie  in @Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"table-active\">\r\n\r\n                <td>");
#nullable restore
#line 32 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Movie\Index.cshtml"
               Write(movie.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Movie\Index.cshtml"
               Write(movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Movie\Index.cshtml"
               Write(movie.Genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 819, "\"", 841, 2);
            WriteAttributeValue("", 826, "movie/", 826, 6, true);
#nullable restore
#line 36 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Movie\Index.cshtml"
WriteAttributeValue("", 832, movie.Id, 832, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Movie\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n\r\n    </table>\r\n");
#nullable restore
#line 42 "C:\Users\Mike\Desktop\Git\Vidly\Vidly\Vidly\Views\Movie\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
