#pragma checksum "C:\Users\EPIC\Desktop\test\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf6e302700e7a4866af9872830f8578c36e0944b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
#line 1 "C:\Users\EPIC\Desktop\test\Views\_ViewImports.cshtml"
using WebApplication117;

#line default
#line hidden
#line 2 "C:\Users\EPIC\Desktop\test\Views\_ViewImports.cshtml"
using WebApplication117.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf6e302700e7a4866af9872830f8578c36e0944b", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8db584871f68af27d513324239dbb9aa52b8ed9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 63, true);
            WriteLiteral("<div class=\"rowProd\">\r\n    <div class=\"ourContacts column-2\">\r\n");
            EndContext();
#line 3 "C:\Users\EPIC\Desktop\test\Views\Home\Contact.cshtml"
          
            ViewData["Title"] = "Contact";
        

#line default
#line hidden
            BeginContext(130, 12, true);
            WriteLiteral("        <h2>");
            EndContext();
            BeginContext(143, 17, false);
#line 6 "C:\Users\EPIC\Desktop\test\Views\Home\Contact.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(160, 48, true);
            WriteLiteral("</h2>\r\n        <hr class=\"line\" />\r\n        <h3>");
            EndContext();
            BeginContext(209, 19, false);
#line 8 "C:\Users\EPIC\Desktop\test\Views\Home\Contact.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(228, 841, true);
            WriteLiteral(@"</h3>
        <address>
            One WebStore Adress<br />
            SomeSity, QA 11122-3333<br />
            <abbr title=""Phone"">P:</abbr>
            111.222.0303
        </address>
        <address>
            <strong>Support:</strong> <a href=""mailto:Support@example.com"">Support@example.com</a><br />
            <strong>Marketing:</strong> <a href=""mailto:Marketing@example.com"">Marketing@example.com</a>
        </address>
    </div>
    <iframe class=""map column-2"" src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d165950.16050174492!2d-115.87610989795478!3d37.29665929256487!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x80b81baaba3e8c81%3A0x970427e38e6237ae!2z0JDRgNC10Y8gNTEsINCd0LXQstCw0LTQsCwg0KHQqNCQ!5e0!3m2!1sru!2sua!4v1676120655302!5m2!1sru!2sua"" width=""800"" height=""600"" style=""border:0;""");
            EndContext();
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 1069, "\"", 1087, 0);
            EndWriteAttribute();
            BeginContext(1088, 77, true);
            WriteLiteral(" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
