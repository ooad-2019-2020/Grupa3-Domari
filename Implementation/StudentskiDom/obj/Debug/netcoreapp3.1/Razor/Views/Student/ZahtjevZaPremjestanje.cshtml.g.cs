#pragma checksum "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Student\ZahtjevZaPremjestanje.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d838835fdfcb2e0d410712ca2c480640a4712c12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_ZahtjevZaPremjestanje), @"mvc.1.0.view", @"/Views/Student/ZahtjevZaPremjestanje.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d838835fdfcb2e0d410712ca2c480640a4712c12", @"/Views/Student/ZahtjevZaPremjestanje.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cc0e2512298311bcce8892fa996745ef0eb41af", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_ZahtjevZaPremjestanje : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d838835fdfcb2e0d410712ca2c480640a4712c124056", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=no"">
    <title>zahtjevZaPremjestanje</title>
    <link rel=""stylesheet"" href=""../../wwwroot/lib/bootstrap/dist/css/bootstrapZahtjevZaPremjestanje.min.css"">
    <link rel=""stylesheet"" href=""../../wwwroot/css/stylesZahtjevZaPremjestanje.css"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d838835fdfcb2e0d410712ca2c480640a4712c125401", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Student\ZahtjevZaPremjestanje.cshtml"
     using (Html.BeginForm("posaljiZahtjevZaPremjestanje", "Student", new { id = ViewBag.id }, FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <h1 class=""text-center text-primary"" style=""font-style: normal;"">Zahtjev za premještanje</h1>
        <div>
            <div class=""container text-left"" style=""width: 1000px;margin: 70px;"">
                <div class=""row"">
                    <div class=""col-md-6"">
                        <div class=""table-responsive"">
                            <table class=""table"">
                                <tbody>
                                    <tr style=""height: 80px;"">
                                        <td>Trenutni paviljon</td>
                                        <td><select name=""dlTrenutniPaviljon"" style=""width: 250px;height: 30px;"">
                                                <optgroup label=""Trenutni paviljon"">
");
#nullable restore
#line 27 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Student\ZahtjevZaPremjestanje.cshtml"
                                                     foreach (Paviljon p in ViewBag.paviljoni)
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d838835fdfcb2e0d410712ca2c480640a4712c127221", async() => {
#nullable restore
#line 29 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Student\ZahtjevZaPremjestanje.cshtml"
                                                                                             Write(p.Naziv);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Student\ZahtjevZaPremjestanje.cshtml"
                                                           WriteLiteral(p.PaviljonId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Student\ZahtjevZaPremjestanje.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                </optgroup>
                                            </select>
                                        </td>
                                    </tr>
                                    <tr style=""height: 80px;"">
                                        <td>Trenutna soba</td>
                                        <td><select name=""dlTrenutnaSoba"" style=""width: 250px;height: 30px;"">
                                                <optgroup label=""Trenutna soba"">
");
#nullable restore
#line 39 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Student\ZahtjevZaPremjestanje.cshtml"
                                                     foreach (Soba s in ViewBag.sobe)
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d838835fdfcb2e0d410712ca2c480640a4712c1210548", async() => {
#nullable restore
#line 41 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Student\ZahtjevZaPremjestanje.cshtml"
                                                                                         Write(s.BrojSobe);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Student\ZahtjevZaPremjestanje.cshtml"
                                                           WriteLiteral(s.SobaId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Student\ZahtjevZaPremjestanje.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                </optgroup>
                                            </select>
                                        </td>
                                    </tr>
                                    <tr style=""height: 80px;"">
                                        <td>Novi paviljon<br><br></td>
                                        <td><select name=""dlNoviPaviljon"" style=""width: 250px;height: 30px;"">
                                                <optgroup label=""Novi paviljon"">
");
#nullable restore
#line 51 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Student\ZahtjevZaPremjestanje.cshtml"
                                                     foreach (Paviljon p in ViewBag.paviljoni)
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d838835fdfcb2e0d410712ca2c480640a4712c1213888", async() => {
#nullable restore
#line 53 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Student\ZahtjevZaPremjestanje.cshtml"
                                                                                             Write(p.Naziv);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Student\ZahtjevZaPremjestanje.cshtml"
                                                           WriteLiteral(p.PaviljonId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 54 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Student\ZahtjevZaPremjestanje.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                </optgroup>
                                            </select>
                                        </td>
                                    </tr>
                                    <tr style=""height: 80px;"">
                                        <td><label>Nova soba<br></label><br><br><br></td>
                                        <td><select name=""dlNovaSoba"" style=""width: 250px;height: 30px;"">
                                                <optgroup label=""Nova Soba"">
");
#nullable restore
#line 63 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Student\ZahtjevZaPremjestanje.cshtml"
                                                     foreach (Soba s in ViewBag.sobe)
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d838835fdfcb2e0d410712ca2c480640a4712c1217235", async() => {
#nullable restore
#line 65 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Student\ZahtjevZaPremjestanje.cshtml"
                                                                                         Write(s.BrojSobe);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Student\ZahtjevZaPremjestanje.cshtml"
                                                           WriteLiteral(s.SobaId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 66 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Student\ZahtjevZaPremjestanje.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                </optgroup>
                                            </select>
                                        </td>
                                    </tr>
                                    <tr style=""height: 150px;"">
                                        <td></td>
                                        <td><button class=""btn btn-primary"" type=""submit"" style=""margin: 50px;"">Pošalji zahtjev</button></td>
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
       ");
                WriteLiteral(@"                             <tr>
                                        <td><textarea name=""fldNapomene"" class=""form-control-lg"" style=""width: 400px;height: 234px;""></textarea></td>
                                    </tr>
                                    <tr style=""height: 150px;"">
                                        <td>
                                            <div class=""btn-group"" role=""group""><button class=""btn btn-secondary"" type=""button"" style=""margin: 50px;"">Odbaci zahtjev</button></div>
                                        </td>
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
#nullable restore
#line 103 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Student\ZahtjevZaPremjestanje.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
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
