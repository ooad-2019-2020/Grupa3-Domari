#pragma checksum "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\Blagajna.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04a20ac6f232421294a3b3d87320e8091941ec7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Uprava_Blagajna), @"mvc.1.0.view", @"/Views/Uprava/Blagajna.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04a20ac6f232421294a3b3d87320e8091941ec7f", @"/Views/Uprava/Blagajna.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e410ba33bd577e25e300ef3e44af039cd8b56ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Uprava_Blagajna : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentskiDom.Models.Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrapBlagajnaLogin.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #0c0b0d;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04a20ac6f232421294a3b3d87320e8091941ec7f4729", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0, shrink-to-fit=no\">\r\n    <title>blagajnaview</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "04a20ac6f232421294a3b3d87320e8091941ec7f5158", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"assets/css/styles.css\">\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04a20ac6f232421294a3b3d87320e8091941ec7f7109", async() => {
                WriteLiteral(@"
    <div class=""container"" style=""margin: 60px 0px 0px 50px;"">
        <div class=""row"">
            <div class=""col"">
                <h1 style=""color: rgb(248,250,251);font-family: COOPER;font-size: 82px;"">BLAGAJNA</h1>
            </div>
            <div class=""col"" style=""margin: 10px;"">
                <div class=""row"">
                    <div class=""col"">
                        <h3 class=""text-right"" style=""color: rgb(248,250,252);font-family: cooper;"">Stanje budžeta</h3>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col"">
                        <h1 class=""text-right"">");
#nullable restore
#line 29 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\Blagajna.cshtml"
                                          Write(ViewBag.Blagajna.StanjeBudgeta);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 35 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\Blagajna.cshtml"
     using (Html.BeginForm("ProvjeriID", "Uprava", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <div class=""row"" style=""margin: 40px 0px 0px 0px;"">
            <div class=""col"" style=""width: 200px;""><label class=""col-form-label text-right"" style=""font-size: 24px;width: 300px;color: rgb(30,129,228);margin: 10px 50px;"">ID Studenta:</label></div>
            <div class=""col"" style=""width: 450px;""><input name=""fldStudentId"" class=""border rounded"" type=""text"" style=""margin: 22px 0px;width: 350px;""></div>
            <div class=""col"" style=""width: 350px;""><button class=""btn btn-primary"" type=""submit"" style=""margin: 18px 0px 0px 0px;width: 300px;"">Provjeri ID</button></div>
        </div>
");
#nullable restore
#line 42 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\Blagajna.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <div class=""container"" style=""width: 1100px;"">
        <div class=""row"" style=""width: 1100px;"">
            <div class=""col"" style=""width:500px"">
                <div class=""table-responsive table-borderless text-center text-body"" style=""width: 450px;margin: 40px;"">
                    <table class=""table table-bordered table-sm"">
                        <thead class=""border-secondary"" style=""color: rgb(30,129,228);font-size: 17px;"">
                            <tr>
                                <th style=""color: rgb(18,124,230);font-size: 17px;"">Osnovni podaci</th>
                            </tr>
                        </thead>
                        <tbody style=""width: 500px;"">
                            <tr>
                                <td style=""width: 200px;color: rgb(248,250,251);"">Ime:</td>
                                <td>");
#nullable restore
#line 56 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\Blagajna.cshtml"
                               Write(ViewBag.Ime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td style=\"color: rgb(248,250,251);\">Prezime:</td>\r\n                                <td>");
#nullable restore
#line 60 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\Blagajna.cshtml"
                               Write(ViewBag.Prezime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td style=\"color: rgb(248,250,251);\">Fakultet:</td>\r\n                                <td>");
#nullable restore
#line 64 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\Blagajna.cshtml"
                               Write(ViewBag.Fakultet);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td style=\"color: rgb(248,250,251);\">Kanton:</td>\r\n                                <td>");
#nullable restore
#line 68 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\Blagajna.cshtml"
                               Write(ViewBag.Kanton);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td style=\"color: rgb(248,250,251);\">Soba:</td>\r\n                                <td>");
#nullable restore
#line 72 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\Blagajna.cshtml"
                               Write(ViewBag.Soba);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
            <div class=""col"" style=""width:500px"">
                <div class=""table-responsive table-borderless text-center text-body"" style=""width: 450px;margin: 40px;height: 209px;"">
                    <table class=""table table-bordered table-sm"">
                        <thead class=""border-secondary"" style=""color: rgb(30,129,228);font-size: 17px;"">
                            <tr>
                                <th style=""color: rgb(18,124,230);font-size: 17px;"">Neuplaćeni mjeseci</th>
                            </tr>
                        </thead>
                        <tbody style=""width: 500px;"">
                            <tr>
                                <td style=""width: 200px;color: rgb(248,250,251);"">
                                    <select name=""dlSort"" style=""width: 300px;margin-top: 20px;"">
                              ");
                WriteLiteral("          <optgroup label=\"Odaberite mjesec\">\r\n");
#nullable restore
#line 91 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\Blagajna.cshtml"
                                             foreach (var mjesec in ViewBag.mjeseci)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04a20ac6f232421294a3b3d87320e8091941ec7f14192", async() => {
#nullable restore
#line 93 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\Blagajna.cshtml"
                                                                  Write(mjesec);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\Blagajna.cshtml"
                                                  WriteLiteral(mjesec);

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
#line 94 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Uprava\Blagajna.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        </optgroup>
                                    </select>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <div style=""width: 500px;height: 50px;margin-right: 10px;margin-left: 600px;"">
        <div class=""btn-group"" role=""group"" style=""margin-top: 10px;""><button class=""btn btn-primary"" type=""button"" style=""width: 248px;height: 38px;"">Uplati dom za odabrani mjesec</button><button class=""btn btn-primary"" type=""button"" style=""margin-left: 100px;height: 38px;"">Gotovo</button></div>
    </div>
    <script src=""assets/js/jquery.min.js""></script>
    <script src=""assets/bootstrap/js/bootstrap.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentskiDom.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
