#pragma checksum "C:\Users\ashehu\source\repos\HomeChallenge\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2430962ed7c9cea80179b7a18078da561464b845"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\ashehu\source\repos\HomeChallenge\Views\_ViewImports.cshtml"
using HomeChallenge;

#line default
#line hidden
#line 2 "C:\Users\ashehu\source\repos\HomeChallenge\Views\_ViewImports.cshtml"
using HomeChallenge.Models;

#line default
#line hidden
#line 3 "C:\Users\ashehu\source\repos\HomeChallenge\Views\_ViewImports.cshtml"
using HomeChallenge.Dtos;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2430962ed7c9cea80179b7a18078da561464b845", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"115cc31eb5a0946cda03b092244edb0c126dea87", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DropDownDtos>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/invoice.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 22, true);
            WriteLiteral("\r\n<div class=\"\">\r\n    ");
            EndContext();
            BeginContext(43, 644, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2430962ed7c9cea80179b7a18078da561464b8454101", async() => {
                BeginContext(49, 81, true);
                WriteLiteral("\r\n        <div class=\"form-row\">\r\n            <div class=\"form-group col-md-4\">\r\n");
                EndContext();
                BeginContext(199, 481, true);
                WriteLiteral(@"                <input type=""date"" class=""form-control"" id=""searchDate"">

            </div>
            <div class=""form-group col-md-2"">
                <button type=""button""  id =""btnSearch""class=""btn btn-primary"">Search</button>

            </div>
            <div class=""form-group col-md-2"">
                <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"">Add Invoice</button>

            </div>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(687, 629, true);
            WriteLiteral(@"

    <br />






</div>


<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Add Invoice</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            EndContext();
            BeginContext(1316, 4351, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2430962ed7c9cea80179b7a18078da561464b8456919", async() => {
                BeginContext(1322, 522, true);
                WriteLiteral(@"
                    <div class=""form-row"">
                        <div class=""form-group col-md-4"">
                            <label for=""amount"">Invoice Amount</label>
                            <input type=""text"" class=""form-control"" id=""amount"" placeholder=""amount"" required>
                        </div>
                        <div class=""form-group col-md-4"">
                            <label for=""currency""> Currency</label>
                            <select id=""currency"" class=""form-control"">
");
                EndContext();
#line 51 "C:\Users\ashehu\source\repos\HomeChallenge\Views\Home\Index.cshtml"
                                 foreach (var item in Model.Currencies)
                                {
                                    if (item.Name.ToLower() == "naira")
                                    {

#line default
#line hidden
                BeginContext(2064, 40, true);
                WriteLiteral("                                        ");
                EndContext();
                BeginContext(2104, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2430962ed7c9cea80179b7a18078da561464b8458328", async() => {
                    BeginContext(2174, 9, false);
#line 55 "C:\Users\ashehu\source\repos\HomeChallenge\Views\Home\Index.cshtml"
                                                                                                        Write(item.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#line 55 "C:\Users\ashehu\source\repos\HomeChallenge\Views\Home\Index.cshtml"
                                                    WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "exchangeRate", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 55 "C:\Users\ashehu\source\repos\HomeChallenge\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2152, item.ExchangeValue, 2152, 19, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2192, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 56 "C:\Users\ashehu\source\repos\HomeChallenge\Views\Home\Index.cshtml"
                                        continue; 

                                    }

#line default
#line hidden
                BeginContext(2287, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(2323, 79, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2430962ed7c9cea80179b7a18078da561464b84511523", async() => {
                    BeginContext(2384, 9, false);
#line 59 "C:\Users\ashehu\source\repos\HomeChallenge\Views\Home\Index.cshtml"
                                                                                           Write(item.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 59 "C:\Users\ashehu\source\repos\HomeChallenge\Views\Home\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "exchangeRate", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 59 "C:\Users\ashehu\source\repos\HomeChallenge\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2362, item.ExchangeValue, 2362, 19, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2402, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 60 "C:\Users\ashehu\source\repos\HomeChallenge\Views\Home\Index.cshtml"

                                }

#line default
#line hidden
                BeginContext(2441, 1439, true);
                WriteLiteral(@"                            </select>
                        </div>
                        <div class=""form-group col-md-4"">
                            <label for=""exchangeRate"">Exchange Rate</label>
                            <input type=""text"" class=""form-control"" id=""exchangeRate"" value=""0"" readonly>
                        </div>
                    </div>

                    <div class=""form-row"">
                        <div class=""form-group col-md-4"">
                            <label for=""invoicedate"">Invoice Date</label>
                            <input type=""date"" class=""form-control"" id=""invoicedate"">

                        </div>
                        <div class=""form-group col-md-4"">
                            <label for=""deliverydate"">Delivery Date</label>
                            <input type=""date"" class=""form-control"" id=""deliverydate"">
                        </div>
                        <div class=""form-group col-md-4"">
                            <label");
                WriteLiteral(@" for=""settledate"">Settle Date</label>
                            <input type=""date"" class=""form-control"" id=""settledate"">
                        </div>
                    </div>
                    <div class=""form-row"">
                        <div class=""form-group col-md-4"">
                            <label for=""vat""> Vat</label>
                            <select id=""vat"" class=""form-control"">
");
                EndContext();
#line 89 "C:\Users\ashehu\source\repos\HomeChallenge\Views\Home\Index.cshtml"
                                 foreach (var item in Model.Vats)
                                {

#line default
#line hidden
                BeginContext(3982, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(4018, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2430962ed7c9cea80179b7a18078da561464b84516171", async() => {
                    BeginContext(4044, 10, false);
#line 91 "C:\Users\ashehu\source\repos\HomeChallenge\Views\Home\Index.cshtml"
                                                        Write(item.Value);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 91 "C:\Users\ashehu\source\repos\HomeChallenge\Views\Home\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
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
                EndContext();
                BeginContext(4063, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 92 "C:\Users\ashehu\source\repos\HomeChallenge\Views\Home\Index.cshtml"

                                }

#line default
#line hidden
                BeginContext(4102, 268, true);
                WriteLiteral(@"                            </select>
                        </div>

                        <div class=""form-group col-md-4"">
                            <label for=""client""> Client</label>
                            <select id=""client"" class=""form-control"">
");
                EndContext();
#line 100 "C:\Users\ashehu\source\repos\HomeChallenge\Views\Home\Index.cshtml"
                                 foreach (var item in Model.Clients)
                                {
                                    

#line default
#line hidden
                BeginContext(4513, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(4549, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2430962ed7c9cea80179b7a18078da561464b84519142", async() => {
                    BeginContext(4575, 9, false);
#line 103 "C:\Users\ashehu\source\repos\HomeChallenge\Views\Home\Index.cshtml"
                                                        Write(item.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 103 "C:\Users\ashehu\source\repos\HomeChallenge\Views\Home\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
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
                EndContext();
                BeginContext(4593, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 104 "C:\Users\ashehu\source\repos\HomeChallenge\Views\Home\Index.cshtml"

                                }

#line default
#line hidden
                BeginContext(4632, 1028, true);
                WriteLiteral(@"                            </select>
                        </div>
                        <div class=""form-group col-md-4"">
                            <label for=""salesAgent"">Sales Agent</label>
                            <input type=""text"" class=""form-control"" id=""salesAgent"" placeholder=""Sales Agent name"">
                        </div>
                    </div>
                    <div class=""form-row"">
                        <div class=""form-group col-md-6"">
                            <label for=""orderNumber"">Order Number</label>
                            <input type=""text"" class=""form-control"" id=""orderNumber"" placeholder=""Order Number"">
                        </div>
                        <div class=""form-group col-md-6"">
                            <label for=""description"">Description</label>
                            <textarea class=""form-control"" id=""description"" placeholder=""description""></textarea>
                        </div>
                    </div>
            ");
                WriteLiteral("    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5667, 226, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" id=\"btnAddInvoice\"class=\"btn btn-primary\">Add Invoice</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5910, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(5918, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2430962ed7c9cea80179b7a18078da561464b84524037", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5957, 8, true);
                WriteLiteral("\r\n  \r\n\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DropDownDtos> Html { get; private set; }
    }
}
#pragma warning restore 1591