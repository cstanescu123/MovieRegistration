#pragma checksum "C:\Users\cstanescu\source\repos\Movie\MovieRegistration\MovieRegistration\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b90e06e8e5181187fd373c5df921a70d43848b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
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
#line 1 "C:\Users\cstanescu\source\repos\Movie\MovieRegistration\MovieRegistration\Views\_ViewImports.cshtml"
using MovieRegistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cstanescu\source\repos\Movie\MovieRegistration\MovieRegistration\Views\_ViewImports.cshtml"
using MovieRegistration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b90e06e8e5181187fd373c5df921a70d43848b2", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6edb0700316839935d5586746ff80ad9306f8388", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieRegistration.Models.ResultViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n    <ul class=\"flex-outer\">\r\n\r\n        <h1>");
#nullable restore
#line 7 "C:\Users\cstanescu\source\repos\Movie\MovieRegistration\MovieRegistration\Views\Home\Result.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" has been registered.</h1>



    </ul>

<style>

    .flex-outer {
        background-color: whitesmoke;
        list-style-type: none;
        padding: 1em;
        border-radius: 3px;
        outline-style: solid;
        position: relative;
        top: 50%;
        transform: translateY(50%);
        font-size: 150%;
    }

    h1 {
        display: flex;
        justify-content: center;
    }





</style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieRegistration.Models.ResultViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591