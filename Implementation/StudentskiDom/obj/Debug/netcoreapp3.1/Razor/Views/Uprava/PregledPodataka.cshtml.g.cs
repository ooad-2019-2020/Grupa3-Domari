#pragma checksum "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\PregledPodataka.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dbda575abe2c709e59f76799d6d0548e31cf99e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Uprava_PregledPodataka), @"mvc.1.0.view", @"/Views/Uprava/PregledPodataka.cshtml")]
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
#nullable restore
#line 3 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dbda575abe2c709e59f76799d6d0548e31cf99e", @"/Views/Uprava/PregledPodataka.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cc0e2512298311bcce8892fa996745ef0eb41af", @"/Views/_ViewImports.cshtml")]
    public class Views_Uprava_PregledPodataka : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dbda575abe2c709e59f76799d6d0548e31cf99e4084", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dbda575abe2c709e59f76799d6d0548e31cf99e5398", async() => {
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
#line 28 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\PregledPodataka.cshtml"
                                                                                                                                                                                                         Write(ViewBag.Student.LicniPodaci.Prezime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></td>\r\n                                    <td>JMBG&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<label>");
#nullable restore
#line 29 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\PregledPodataka.cshtml"
                                                                                                                                                                                                Write(ViewBag.Student.LicniPodaci.Jmbg.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></td>
                                </tr>
                                <tr style=""height: 80px;"">
                                    <td>&nbsp; Ime&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<label>");
#nullable restore
#line 32 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\PregledPodataka.cshtml"
                                                                                                                                                                                                                          Write(ViewBag.Student.LicniPodaci.Ime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></td>\r\n                                    <td>Datum rođenja&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<label>");
#nullable restore
#line 33 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\PregledPodataka.cshtml"
                                                                                                                                                 Write(ViewBag.Student.LicniPodaci.DatumRodjenja.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></td>
                                </tr>
                                <tr style=""height: 80px;"">
                                    <td>&nbsp; Mjesto rođenja&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<label>");
#nullable restore
#line 36 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\PregledPodataka.cshtml"
                                                                                                                                                                      Write(ViewBag.Student.LicniPodaci.MjestoRodjenja);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></td>\r\n                                    <td><label>Mobitel&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</label><label>+387 ");
#nullable restore
#line 37 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\PregledPodataka.cshtml"
                                                                                                                                                                                                         Write(ViewBag.Student.LicniPodaci.Mobitel.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></td>
                                </tr>
                                <tr style=""height: 80px;"">
                                    <td>&nbsp; Pol&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<label>");
#nullable restore
#line 40 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\PregledPodataka.cshtml"
                                                                                                                                                                                                                                 Write(ViewBag.Student.LicniPodaci.Pol.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></td>
                                    <td></td>
                                </tr>
                                <tr style=""height: 150px;"">
                                    <td><label>&nbsp; E-mail&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</label><label style=""margin-left: 9px;"">");
#nullable restore
#line 44 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\PregledPodataka.cshtml"
                                                                                                                                                                                                                                           Write(ViewBag.Student.LicniPodaci.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></td>\r\n                                    <td><label>Slika&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</label>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7dbda575abe2c709e59f76799d6d0548e31cf99e12656", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3922, "~/images/", 3922, 9, true);
#nullable restore
#line 45 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\PregledPodataka.cshtml"
AddHtmlAttributeValue("", 3931, ViewBag.Student.LicniPodaci.Slika, 3931, 34, false);

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
                BeginWriteAttribute("onclick", " onclick=\"", 4440, "\"", 4537, 3);
                WriteAttributeValue("", 4450, "window.location.href=\'", 4450, 22, true);
#nullable restore
#line 54 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\PregledPodataka.cshtml"
WriteAttributeValue("", 4472, Url.Action("ListaStudenata", "Uprava", new { id = ViewBag.id }), 4472, 64, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4536, "\'", 4536, 1, true);
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-primary"" type=""button"" style=""margin: 0px;width: 150px;margin-left: 0px;"">Gotovo</button></td>
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
                                    <td style=""height: 80px;"">Adresa&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbs");
                WriteLiteral("p; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<label>");
#nullable restore
#line 71 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\PregledPodataka.cshtml"
                                                                                                                                                                                                   Write(ViewBag.Student.PrebivalisteInfo.Adresa);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></td>\r\n                                    <td style=\"height: 80px;\">Kanton&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<label>");
#nullable restore
#line 72 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\PregledPodataka.cshtml"
                                                                                                                                                                                                   Write(ViewBag.Student.PrebivalisteInfo.Kanton);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></td>
                                </tr>
                                <tr>
                                    <td><label>Općina&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</label><label>");
#nullable restore
#line 75 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\PregledPodataka.cshtml"
                                                                                                                                                                                                  Write(ViewBag.Student.PrebivalisteInfo.Opcina);

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
#line 90 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\PregledPodataka.cshtml"
                                                                                                                                                                                                    Write(ViewBag.Student.SkolovanjeInfo.Fakultet);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></td>\r\n                                    <td style=\"height: 80px;\">Ciklus studija&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<label>");
#nullable restore
#line 91 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\PregledPodataka.cshtml"
                                                                                                                                                                              Write(ViewBag.Student.SkolovanjeInfo.CiklusStudija);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></td>
                                </tr>
                                <tr>
                                    <td><label>Broj indeksa&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</label><label>");
#nullable restore
#line 94 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\PregledPodataka.cshtml"
                                                                                                                                                               Write(ViewBag.Student.SkolovanjeInfo.BrojIndeksa);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></td>\r\n                                    <td><label>Godina studija&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; </label><label>");
#nullable restore
#line 95 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\PregledPodataka.cshtml"
                                                                                                                                                           Write(ViewBag.Student.SkolovanjeInfo.GodinaStudija);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </label></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <div class=""table-responsive"" style=""margin: 30px;margin-top: 69px;"">
                        <table class=""table"">
                            <tbody>
                                <tr>
                                    <td style=""width: 200px;""><button");
                BeginWriteAttribute("onclick", " onclick=\"", 8402, "\"", 8499, 3);
                WriteAttributeValue("", 8412, "window.location.href=\'", 8412, 22, true);
#nullable restore
#line 104 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\PregledPodataka.cshtml"
WriteAttributeValue("", 8434, Url.Action("ObrisiStudenta", "Uprava", new { id = ViewBag.id }), 8434, 64, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 8498, "\'", 8498, 1, true);
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-primary"" type=""button"" style=""margin: 0px;width: 150px;margin-left: 0px;"">Obriši studenta</button></td>
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
