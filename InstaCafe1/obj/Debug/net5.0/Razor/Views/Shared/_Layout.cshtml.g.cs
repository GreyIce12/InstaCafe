#pragma checksum "C:\Users\moniq\source\repos\InstaCafe1\InstaCafe1\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e7d6f9c7d03cef234b5e5d47106405c77286e52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\moniq\source\repos\InstaCafe1\InstaCafe1\Views\_ViewImports.cshtml"
using InstaCafe1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\moniq\source\repos\InstaCafe1\InstaCafe1\Views\_ViewImports.cshtml"
using InstaCafe1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e7d6f9c7d03cef234b5e5d47106405c77286e52", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b748a1bd682f1d15624e759da043832454b9de61", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e7d6f9c7d03cef234b5e5d47106405c77286e523254", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">

    <!-- Page Title -->
    <title>Insta Cafe</title>

    <!-- Favicon -->
    <link rel=""shortcut icon"" href=""https://i.imgur.com/PLnOUba.png"" type=""image/x-icon"">

    <!-- CSS Files -->
    <link rel=""stylesheet"" href=""css/animate-3.7.0.css"">
    <link rel=""stylesheet"" href=""css/font-awesome-4.7.0.min.css"">
    <link rel=""stylesheet"" href=""css/bootstrap-4.1.3.min.css"">
    <link rel=""stylesheet"" href=""css/owl-carousel.min.css"">
    <link rel=""stylesheet"" href=""css/jquery.datetimepicker.min.css"">
    <link rel=""stylesheet"" href=""css/style.css"">

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e7d6f9c7d03cef234b5e5d47106405c77286e524993", async() => {
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 25 "C:\Users\moniq\source\repos\InstaCafe1\InstaCafe1\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <header class=""header-area"">
        <div class=""container "">
            <div class=""row"">
                <div class=""col-lg-2"">
                    <div class=""logo-area"">
                        <a href=""index.html""><img src=""https://i.imgur.com/PLnOUba.png"" alt=""logo"" width=""60px"" height=""60px"">Insta Cafe</a>
                    </div>
                </div>
                <div class=""col-lg-10"">
                    <div class=""custom-navbar"">
                        <span></span>
                        <span></span>
                        <span></span>
                    </div>
                    <div class=""main-menu"">
                        <ul>
                            <li class=""active""><a href=""index.html"">Home</a></li>

                            <li><a href=""menu.html"">menu</a></li>
                            <li>
                                <a href=""#"">Join!</a>
                                <ul class=""sub-menu"">
                                    <l");
                WriteLiteral(@"i><a href=""blog-home.html"">Sign up</a></li>
                                    <li><a href=""blog-details.html"">Log in</a></li>
                                </ul>
                            </li>
                            <li><a href=""contact-us.html"">Order</a></li>
                            <li><a href=""elements.html"">Food Cart </a></li>

                            
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </header>
    <!-- Footer Area Starts -->
    <footer class=""footer-area"">
        <div class=""footer-widget section-padding"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-4"">
                        <div class=""single-widget single-widget1"">
                            <a href=""index.html""><img src=""https://i.imgur.com/PLnOUba.png""");
                BeginWriteAttribute("alt", " alt=\"", 2753, "\"", 2759, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""60px"" height=""60px""></a>
                            <p class=""mt-3"">Which morning fourth great won't is to fly bearing man. Called unto shall seed, deep, herb set seed land divide after over first creeping. First creature set upon stars deep male gathered said she'd an image spirit our</p>
                        </div>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""single-widget single-widget2 my-5 my-md-0"">
                            <h5 class=""mb-4"">contact us</h5>
                            <div class=""d-flex"">
                                <div class=""into-icon"">
                                    <i class=""fa fa-map-marker""></i>
                                </div>
                                <div class=""info-text"">
                                    <p>1234 Some St San Francisco, CA 94102, US 1.800.123.4567 </p>
                                </div>
                            </div>
                        ");
                WriteLiteral(@"    <div class=""d-flex"">
                                <div class=""into-icon"">
                                    <i class=""fa fa-phone""></i>
                                </div>
                                <div class=""info-text"">
                                    <p>(123) 456 78 90</p>
                                </div>
                            </div>
                            <div class=""d-flex"">
                                <div class=""into-icon"">
                                    <i class=""fa fa-envelope-o""></i>
                                </div>
                                <div class=""info-text"">
                                    <p>support@axiomthemes.com</p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""single-widget single-widget3"">
                            <h5 class=""mb-4"">opening ");
                WriteLiteral(@"hours</h5>
                            <p>Monday ...................... Closed</p>
                            <p>Tue-Fri .............. 10 am - 12 pm</p>
                            <p>Sat-Sun ............... 8 am - 11 pm</p>
                            <p>Holidays ............. 10 am - 12 pm</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""footer-copyright"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-7 col-md-6"">
                        <span>

                            Copyright &copy;
                            <script>document.write(new Date().getFullYear());</script> All rights reserved | Insta Cafe

                        </span>
                    </div>

                </div>
            </div>
        </div>
    </footer>
    <!-- Footer Area End -->
");
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
            WriteLiteral("\r\n</html>\r\n");
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
