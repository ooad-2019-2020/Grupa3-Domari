#pragma checksum "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledCimeraj.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af40013975873ae0067d4a7dd7485b1449182a7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zahtjev_PregledCimeraj), @"mvc.1.0.view", @"/Views/Zahtjev/PregledCimeraj.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af40013975873ae0067d4a7dd7485b1449182a7e", @"/Views/Zahtjev/PregledCimeraj.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e410ba33bd577e25e300ef3e44af039cd8b56ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Zahtjev_PregledCimeraj : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af40013975873ae0067d4a7dd7485b1449182a7e3397", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=no"">
    <title>pregledCimeraj</title>
    <link rel=""stylesheet"" href=""../../wwwroot/lib/bootstrap/dist/css/bootstrapCimeraj.min.css>
    <link rel=""stylesheet"" href=""../../wwwroot/css/stylesPregledCimeraj.css"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af40013975873ae0067d4a7dd7485b1449182a7e4712", async() => {
                WriteLiteral(@"
    <h1 class=""text-center text-primary"" style=""font-style: normal;"">Pregled cimeraja</h1>
    <div>
        <div class=""container text-left"" style=""width: 1000px;margin: 70px;height: 500px;"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <tbody>
                                <tr style=""height: 80px;"">
                                    <td>Paviljon</td>
                                    <td><label>LabelPaviljon</label></td>
                                </tr>
                                <tr style=""height: 80px;"">
                                    <td>Soba</td>
                                    <td><label>LabelSoba</label></td>
                                </tr>
                                <tr style=""height: 80px;"">
                                    <td>Prvi cimer</td>
                                    <td><label>Label");
                WriteLiteral(@"PrviCimer</label></td>
                                </tr>
                                <tr style=""height: 80px;"">
                                    <td>Drugi cimer</td>
                                    <td><label>LabelDrugiCimer</label></td>
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
                                    <td style=""height: 80px;"">Dodatne napomene</td>
                                </tr>
                                <tr>
                                    <td style=""width: 469.6px;height: 239.4px;""><label>LabelDodatneNapomene</label></td>
                                </tr>
                            </tbody>
                        </ta");
                WriteLiteral(@"ble>
                    </div>
                </div>
            </div>
            <div class=""table-responsive"" style=""width: 980px;"">
                <table class=""table"">
                    <tbody>
                        <tr>
                            <td style=""width: 483px;"">
                                <div class=""table-responsive"" style=""margin: 30px;width: 400px;"">
                                    <table class=""table"">
                                        <tbody>
                                            <tr>
                                                <td style=""width: 200px;""><button class=""btn btn-primary"" type=""button"" style=""margin: 0px;width: 150px;margin-left: 0px;"">Odobri upis</button></td>
                                                <td><button class=""btn btn-secondary"" type=""button"" style=""margin: 0px;width: 150px;margin-left: 0px;"">Odbij zahtjev</button></td>
                                            </tr>
                                        ");
                WriteLiteral(@"</tbody>
                                    </table>
                                </div>
                            </td>
                            <td>
                                <div class=""table-responsive"" style=""margin: 30px;width: 410px;"">
                                    <table class=""table"">
                                        <tbody>
                                            <tr style=""width: 427px;"">
                                                <td style=""width: 240px;""><button class=""btn btn-secondary"" type=""button"" style=""margin: 0px;width: 150px;margin-left: 0px;"">Pregled kartice</button></td>
                                                <td style=""width: 240px;""><button class=""btn btn-secondary"" type=""button"" style=""margin: 0px;width: 151px;margin-left: 0px;"">Pregled podataka</button></td>
                                            </tr>
                                        </tbody>
                                    </table>
                        ");
                WriteLiteral(@"        </div>
                            </td>
                        </tr>
                    </tbody>
                </table>
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
