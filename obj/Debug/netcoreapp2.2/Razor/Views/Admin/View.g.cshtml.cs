#pragma checksum "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Admin\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d10c3323c8ced1beb2275e77e15a70caa99d142"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_View), @"mvc.1.0.view", @"/Views/Admin/View.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/View.cshtml", typeof(AspNetCore.Views_Admin_View))]
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
#line 1 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\_ViewImports.cshtml"
using PremiumAccount;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\_ViewImports.cshtml"
using PremiumAccount.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d10c3323c8ced1beb2275e77e15a70caa99d142", @"/Views/Admin/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6f2d6af402c9f54082137674e6b15fa55d90aed", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(15, 17, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\t\t\t\t\t<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 32, "\"", 65, 2);
            WriteAttributeValue("", 38, "/postimages/", 38, 12, true);
#line 7 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Admin\View.cshtml"
WriteAttributeValue("", 50, Model.PhotoUrl, 50, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(66, 24, true);
            WriteLiteral(" alt=\"\">\r\n\t\t\t\t\t<h3 ><b> ");
            EndContext();
            BeginContext(91, 11, false);
#line 8 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Admin\View.cshtml"
                        Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(102, 42, true);
            WriteLiteral("</b></h3>\r\n\t\t\t\t\t\r\n\t\t\t\t\t\tby <a href=\"#\"><b>");
            EndContext();
            BeginContext(145, 12, false);
#line 10 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Admin\View.cshtml"
                                     Write(Model.Author);

#line default
#line hidden
            EndContext();
            BeginContext(157, 10, true);
            WriteLiteral(" </b></a> ");
            EndContext();
            BeginContext(168, 15, false);
#line 10 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Admin\View.cshtml"
                                                            Write(Model.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(183, 8, true);
            WriteLiteral("\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(192, 15, false);
#line 11 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Admin\View.cshtml"
                   Write(Model.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(207, 41, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t\r\n\t\t\t\t\t\r\n\t\t\t\t\t\r\n\t\t\t\t\t<p > ");
            EndContext();
            BeginContext(249, 27, false);
#line 16 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Admin\View.cshtml"
                    Write(Html.Raw(Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(276, 190, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\r\n\t\t\t\t\r\n\t\t\t\t\t\r\n\t\t\t\t\t\r\n\t\t\t\t\t\r\n\t\t\t\t\t\r\n\t\t\t\t\t\r\n\t\t\t\t\t<h4 ><b> COMMENTS</b></h4>\r\n\t\t\t\t\t\r\n\t\t\t\t\t<div>\r\n\t\t\t\t\t\r\n\t\t\t\t\t\t<!-- s-left -->\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t<!-- sided-70 -->\r\n");
            EndContext();
#line 33 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Admin\View.cshtml"
                     foreach (var x in ViewBag.Comments)
					{
						

#line default
#line hidden
            BeginContext(525, 152, true);
            WriteLiteral("\t\t\t\t<div >\r\n\t\t\t\t\t\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t<img src=\"images/profile-2-120x120.jpg\" alt=\"\">\r\n\t\t\t\t\t\t</div><!-- s-left -->\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t<h5><b>");
            EndContext();
            BeginContext(678, 6, false);
#line 43 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Admin\View.cshtml"
                              Write(x.Name);

#line default
#line hidden
            EndContext();
            BeginContext(684, 37, true);
            WriteLiteral(" </b> <span class=\"font-8 color-ash\">");
            EndContext();
            BeginContext(722, 10, false);
#line 43 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Admin\View.cshtml"
                                                                          Write(x.PostedAt);

#line default
#line hidden
            EndContext();
            BeginContext(732, 25, true);
            WriteLiteral("</span></h5>\r\n\t\t\t\t\t\t\t<p >");
            EndContext();
            BeginContext(758, 6, false);
#line 44 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Admin\View.cshtml"
                           Write(x.Text);

#line default
#line hidden
            EndContext();
            BeginContext(764, 130, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t<a ><b>LIKE</b></a>\r\n\t\t\t\t\t\t\t<a><b>REPLY</b></a>\r\n\t\t\t\t\t\t</div><!-- s-right -->\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t</div><!-- sided-70 -->\r\n");
            EndContext();
#line 50 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Admin\View.cshtml"
					}

#line default
#line hidden
            BeginContext(902, 57, true);
            WriteLiteral("\t\t\t\t\t\r\n\t\t\t\t\t\r\n\t\t\t\t\t\r\n\t\t\t\t\t\r\n\t\t\t\t\r\n\t\t\t\t\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
