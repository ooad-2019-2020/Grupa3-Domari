#pragma checksum "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledPremjestanje.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96b536339a8f60095ca8ad57b295cbc76ff26894"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zahtjev_PregledPremjestanje), @"mvc.1.0.view", @"/Views/Zahtjev/PregledPremjestanje.cshtml")]
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
#line 1 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\_ViewImports.cshtml"
using StudentskiDom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\_ViewImports.cshtml"
using StudentskiDom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96b536339a8f60095ca8ad57b295cbc76ff26894", @"/Views/Zahtjev/PregledPremjestanje.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e410ba33bd577e25e300ef3e44af039cd8b56ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Zahtjev_PregledPremjestanje : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96b536339a8f60095ca8ad57b295cbc76ff268943362", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=no"">
    <title>pregledPremjestanje</title>
    <link rel=""stylesheet"" href=""../../wwwroot/lib/bootstrap/dist/css/bootstrapPregledPremjestanje.css"">
    <link rel=""stylesheet"" href=""../../wwwroot/css/stylesPregledPremjestanje.css"">
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96b536339a8f60095ca8ad57b295cbc76ff268944697", async() => {
                WriteLiteral(@"
    <h1 class=""text-center text-primary"" style=""font-style: normal;"">Pregled zahtjeva za premještanje</h1>
    <div>
        <div class=""container text-left"" style=""width: 1000px;margin: 70px;"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <tbody>
                                <tr style=""height: 80px;"">
                                    <td>Trenutni paviljon</td>
                                    <td><label>");
#nullable restore
#line 23 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledPremjestanje.cshtml"
                                          Write(ViewBag.ZahtjevZaPremjestanje.Paviljon1.Naziv);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></td>\r\n                                </tr>\r\n                                <tr style=\"height: 80px;\">\r\n                                    <td>Trenutna soba</td>\r\n                                    <td><label>");
#nullable restore
#line 27 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledPremjestanje.cshtml"
                                          Write(ViewBag.ZahtjevZaPremjestanje.Soba1.BrojSobe);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></td>\r\n                                </tr>\r\n                                <tr style=\"height: 80px;\">\r\n                                    <td>Novi paviljon<br><br></td>\r\n                                    <td><label>");
#nullable restore
#line 31 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledPremjestanje.cshtml"
                                          Write(ViewBag.ZahtjevZaPremjestanje.Paviljon2.Naziv);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></td>\r\n                                </tr>\r\n                                <tr style=\"height: 80px;\">\r\n                                    <td><label>Nova soba<br></label><br><br><br></td>\r\n                                    <td><label>");
#nullable restore
#line 35 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledPremjestanje.cshtml"
                                          Write(ViewBag.ZahtjevZaPremjestanje.Soba1.BrojSobe);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <div class=""table-responsive"" style=""margin: 30px;width: 400px;"">
                        <table class=""table"">
                            <tbody>
                                <tr>
                                    <td style=""width: 200px;""><button");
                BeginWriteAttribute("onclick", " onclick=\"", 2294, "\"", 2424, 3);
                WriteAttributeValue("", 2304, "window.location.href=\'", 2304, 22, true);
#nullable restore
#line 44 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledPremjestanje.cshtml"
WriteAttributeValue("", 2326, Url.Action("OdobriPremjestanje","Zahtjev", new { id = ViewBag.ZahtjevZaPremjestanje.ZahtjevId }), 2326, 97, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2423, "\'", 2423, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\" type=\"button\" style=\"margin: 0px;width: 173px;margin-left: 0px;\">Odobri premještanje</button></td>\r\n                                    <td><button");
                BeginWriteAttribute("onclick", " onclick=\"", 2597, "\"", 2726, 3);
                WriteAttributeValue("", 2607, "window.location.href=\'", 2607, 22, true);
#nullable restore
#line 45 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledPremjestanje.cshtml"
WriteAttributeValue("", 2629, Url.Action("OdbijPremjestanje","Zahtjev", new { id = ViewBag.ZahtjevZaPremjestanje.ZahtjevId }), 2629, 96, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2725, "\'", 2725, 1, true);
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-secondary"" type=""button"" style=""margin: 0px;width: 150px;margin-left: 0px;"">Odbij zahtjev</button></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <div class=""col-md-6"">
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <tbody>
                                <tr>
                                    <td style=""height: 80px;"">Razlog premještanja</td>
                                </tr>
                                <tr>
                                    <td style=""height: 264.4px;""><label>");
#nullable restore
#line 59 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledPremjestanje.cshtml"
                                                                   Write(ViewBag.ZahtjevZaPremjestanje.RazlogPremjestanja);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <div class=""table-responsive"" style=""margin: 30px;"">
                        <table class=""table"">
                            <tbody>
                                <tr>
                                    <td>Podnosilac zahtjeva:</td>
                                    <td>");
#nullable restore
#line 69 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledPremjestanje.cshtml"
                                   Write(ViewBag.ZahtjevZaPremjestanje.Student.LicniPodaci.Prezime);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 69 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledPremjestanje.cshtml"
                                                                                              Write(ViewBag.ZahtjevZaPremjestanje.Student.LicniPodaci.Ime);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script src=""assets/js/jquery.min.js""></script>
    <script src=""assets/bootstrap/js/bootstrap.min.js""></script>
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
            WriteLiteral("\r\n\r\n</html>\r\n");
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
