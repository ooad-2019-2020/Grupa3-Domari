#pragma checksum "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledUpis.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6bdada10dfd67d388fe1fca3cd93bcb7c0d6be3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zahtjev_PregledUpis), @"mvc.1.0.view", @"/Views/Zahtjev/PregledUpis.cshtml")]
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
#line 1 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\_ViewImports.cshtml"
using StudentskiDom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\_ViewImports.cshtml"
using StudentskiDom.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6bdada10dfd67d388fe1fca3cd93bcb7c0d6be3", @"/Views/Zahtjev/PregledUpis.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cc0e2512298311bcce8892fa996745ef0eb41af", @"/Views/_ViewImports.cshtml")]
    public class Views_Zahtjev_PregledUpis : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 120px;height: 120px;margin: 14px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6bdada10dfd67d388fe1fca3cd93bcb7c0d6be34149", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=no"">
    <title>odobriUpis</title>
    <link rel=""stylesheet"" href=""../../wwwroot/lib/bootstrap/dist/css/bootstrapPregledUpis.min.css"">
    <link rel=""stylesheet"" href=""../../wwwroot/css/stylesPregledUpis.css"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6bdada10dfd67d388fe1fca3cd93bcb7c0d6be35463", async() => {
                WriteLiteral(@"
    <h1 class=""text-center text-primary"" style=""font-style: normal;"">Pregled zahtjeva za upis</h1>
    <div>
        <div class=""container text-left"" style=""width: 1000px;margin: 70px;"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <div class=""table-responsive border rounded border-secondary shadow"">
                        <table class=""table table-sm"">
                            <thead>
                                <tr>
                                    <th class=""table-secondary"" style=""width: 231px;"">Lični podaci:</th>
                                    <th class=""table-secondary"" style=""width: 223px;""></th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr style=""height: 80px;"">
                                    <td>&nbsp; Prezime&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; ");
                WriteLiteral("&nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<label>");
#nullable restore
#line 28 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledUpis.cshtml"
                                                                                                                                                                                                         Write(ViewBag.ZahtjevZaUpis.LicniPodaci.Prezime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></td>\r\n                                    <td>JMBG&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<label>");
#nullable restore
#line 29 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledUpis.cshtml"
                                                                                                                                                                                                Write(ViewBag.ZahtjevZaUpis.LicniPodaci.Jmbg.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></td>
                                </tr>
                                <tr style=""height: 80px;"">
                                    <td>&nbsp; Ime&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<label>");
#nullable restore
#line 32 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledUpis.cshtml"
                                                                                                                                                                                                                          Write(ViewBag.ZahtjevZaUpis.LicniPodaci.Ime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></td>\r\n                                    <td>Datum rođenja&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<label>");
#nullable restore
#line 33 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledUpis.cshtml"
                                                                                                                                                 Write(ViewBag.ZahtjevZaUpis.LicniPodaci.DatumRodjenja.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></td>
                                </tr>
                                <tr style=""height: 80px;"">
                                    <td>&nbsp; Mjesto rođenja&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<label>");
#nullable restore
#line 36 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledUpis.cshtml"
                                                                                                                                                                      Write(ViewBag.ZahtjevZaUpis.LicniPodaci.MjestoRodjenja);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></td>\r\n                                    <td><label>Mobitel&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</label><label>");
#nullable restore
#line 37 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledUpis.cshtml"
                                                                                                                                                                                                    Write(ViewBag.ZahtjevZaUpis.LicniPodaci.Mobitel.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></td>
                                </tr>
                                <tr style=""height: 80px;"">
                                    <td>&nbsp; Pol&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<label>");
#nullable restore
#line 40 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledUpis.cshtml"
                                                                                                                                                                                                                                 Write(ViewBag.ZahtjevZaUpis.LicniPodaci.Pol.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></td>
                                    <td></td>
                                </tr>
                                <tr style=""height: 150px;"">
                                    <td><label>&nbsp; E-mail&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</label><label style=""margin-left: 9px;"">");
#nullable restore
#line 44 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledUpis.cshtml"
                                                                                                                                                                                                                                           Write(ViewBag.ZahtjevZaUpis.LicniPodaci.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></td>\r\n                                    <td><label>Slika&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</label>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f6bdada10dfd67d388fe1fca3cd93bcb7c0d6be312886", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3956, "~/images/", 3956, 9, true);
#nullable restore
#line 45 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledUpis.cshtml"
AddHtmlAttributeValue("", 3965, ViewBag.ZahtjevZaUpis.LicniPodaci.Slika, 3965, 40, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <div class=""table-responsive"" style=""margin: 30px;width: 400px;"">
                        <table class=""table"">
                            <tbody>
                                <tr>
                                    <td style=""width: 200px;""><button");
                BeginWriteAttribute("onclick", " onclick=\"", 4480, "\"", 4600, 5);
                WriteAttributeValue("", 4490, "window.location.href=\'", 4490, 22, true);
#nullable restore
#line 54 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledUpis.cshtml"
WriteAttributeValue("", 4512, Url.Action("PrihvatiZahtjevZaUpis","Zahtjev"), 4512, 46, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4558, "?id=\'", 4558, 5, true);
                WriteAttributeValue(" ", 4563, "+", 4564, 2, true);
#nullable restore
#line 54 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledUpis.cshtml"
WriteAttributeValue(" ", 4565, ViewBag.ZahtjevZaUpis.ZahtjevId, 4566, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\" type=\"button\" style=\"margin: 0px;width: 150px;margin-left: 0px;\">Odobri upis</button></td>\r\n                                    <td><button");
                BeginWriteAttribute("onclick", " onclick=\"", 4765, "\"", 4876, 5);
                WriteAttributeValue("", 4775, "window.location.href=\'", 4775, 22, true);
#nullable restore
#line 55 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledUpis.cshtml"
WriteAttributeValue("", 4797, Url.Action("OdbijZahtjev","Zahtjev"), 4797, 37, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4834, "?id=\'", 4834, 5, true);
                WriteAttributeValue(" ", 4839, "+", 4840, 2, true);
#nullable restore
#line 55 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledUpis.cshtml"
WriteAttributeValue(" ", 4841, ViewBag.ZahtjevZaUpis.ZahtjevId, 4842, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-secondary"" type=""button"" style=""margin: 0px;width: 150px;margin-left: 0px;"">Odbij zahtjev</button></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <div class=""col-md-6"">
                    <div class=""table-responsive border rounded border-secondary shadow"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th class=""table-secondary"" style=""width: 235.1px;"">Podaci o prebivalištu:</th>
                                    <th class=""table-secondary""></th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td style=""height: 80px;"">Adresa&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &n");
                WriteLiteral("bsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<label>");
#nullable restore
#line 72 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledUpis.cshtml"
                                                                                                                                                                                                   Write(ViewBag.ZahtjevZaUpis.PrebivalisteInfo.Adresa);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></td>\r\n                                    <td style=\"height: 80px;\">Kanton&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<label>");
#nullable restore
#line 73 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledUpis.cshtml"
                                                                                                                                                                                                   Write(ViewBag.ZahtjevZaUpis.PrebivalisteInfo.Kanton);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></td>
                                </tr>
                                <tr>
                                    <td><label>Općina&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</label><label>");
#nullable restore
#line 76 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledUpis.cshtml"
                                                                                                                                                                                                  Write(ViewBag.ZahtjevZaUpis.PrebivalisteInfo.Opcina);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <div class=""table-responsive border rounded border-secondary shadow"" style=""margin-top: 50px;"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th class=""table-secondary"" style=""width: 235.1px;"">Podaci o školovanju:</th>
                                    <th class=""table-secondary""></th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td style=""height: 80px;"">Fakultet&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<label>");
#nullable restore
#line 91 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledUpis.cshtml"
                                                                                                                                                                                                    Write(ViewBag.ZahtjevZaUpis.SkolovanjeInfo.Fakultet);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></td>\r\n                                    <td style=\"height: 80px;\">Ciklus studija&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<label>");
#nullable restore
#line 92 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledUpis.cshtml"
                                                                                                                                                                              Write(ViewBag.ZahtjevZaUpis.SkolovanjeInfo.CiklusStudija);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td><label>Broj indeksa&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</label><label>");
#nullable restore
#line 95 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledUpis.cshtml"
                                                                                                                                                              Write(ViewBag.ZahtjevZaUpis.SkolovanjeInfo.BrojIndeksa);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></td>\r\n                                    <td><label>Godina studija&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</label><label>");
#nullable restore
#line 96 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledUpis.cshtml"
                                                                                                                                                         Write(ViewBag.ZahtjevZaUpis.SkolovanjeInfo.GodinaStudija);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <div class=""table-responsive"" style=""margin: 30px;margin-top: 69px;"">
                        <table class=""table"">
                            <tbody>
                                <tr>
                                    <td><button");
                BeginWriteAttribute("onclick", " onclick=\"", 8763, "\"", 8879, 5);
                WriteAttributeValue("", 8773, "window.location.href=\'", 8773, 22, true);
#nullable restore
#line 105 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledUpis.cshtml"
WriteAttributeValue("", 8795, Url.Action("StudentskaKartica","Zahtjev"), 8795, 42, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 8837, "?id=\'", 8837, 5, true);
                WriteAttributeValue(" ", 8842, "+", 8843, 2, true);
#nullable restore
#line 105 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledUpis.cshtml"
WriteAttributeValue(" ", 8844, ViewBag.ZahtjevZaUpis.ZahtjevId, 8845, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-secondary"" type=""button"" style=""margin: 0px;width: 150px;margin-left: 0px;"">Pregled kartice</button></td>
                                    <td><button class=""btn btn-secondary"" type=""button"" style=""margin: 0px;width: 151px;margin-left: 0px;"">Pregled podataka</button></td>
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
            WriteLiteral("\r\n\r\n</html>");
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
