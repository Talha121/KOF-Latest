#pragma checksum "D:\personal\KOF-12-2-2022\KOF\KOF\Views\Home\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3df0b8e73ff4c4f7a573074ecb03087b61551bec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Checkout), @"mvc.1.0.view", @"/Views/Home/Checkout.cshtml")]
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
#line 1 "D:\personal\KOF-12-2-2022\KOF\KOF\Views\_ViewImports.cshtml"
using KOF;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\personal\KOF-12-2-2022\KOF\KOF\Views\_ViewImports.cshtml"
using KOF.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\personal\KOF-12-2-2022\KOF\KOF\Views\Home\Checkout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\personal\KOF-12-2-2022\KOF\KOF\Views\Home\Checkout.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3df0b8e73ff4c4f7a573074ecb03087b61551bec", @"/Views/Home/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57500bc9ac7b0ad983b31e1a1af4fc8524b44c3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("checkout_coupon woocommerce-form-coupon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("checkout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("checkout woocommerce-checkout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Checkout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\personal\KOF-12-2-2022\KOF\KOF\Views\Home\Checkout.cshtml"
   ViewData["Title"] = "MyAccount";
                Layout = "~/Views/Shared/_LayoutWebsite.cshtml";
          

                List<Cart> mycart = new List<Cart>();

                var data = @HttpContextAccessor.HttpContext.Session.GetString("mycart");

                if (data != null)
                {
                    var data2 = JsonConvert.DeserializeObject<IEnumerable<Cart>>(data);
                    mycart.AddRange(data2);
                } 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css"" integrity=""sha512-c42qTSw/wPZ3/5LBzD+Bw5f7bSF2oxou6wEb+I/lqeaKV5FDIfMvvRp772y4jcJLKuGUOpbJMdg/BTl50fJYAw=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/limonte-sweetalert2/11.1.9/sweetalert2.min.css"" integrity=""sha512-cyIcYOviYhF0bHIhzXWJQ/7xnaBuIIOecYoPZBgJHQKFPo+TOBA+BY1EnTpmM8yKDU4ZdI3UGccNGCEUdfbBqw=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
<script src=""https://cdnjs.cloudflare.com/ajax/libs/limonte-sweetalert2/11.1.9/sweetalert2.all.min.js"" integrity=""sha512-IZ95TbsPTDl3eT5GwqTJH/14xZ2feLEGJRbII6bRKtE/HC6x3N4cHye7yyikadgAsuiddCY2+6gMntpVHL1gHw=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>

");
#nullable restore
#line 22 "D:\personal\KOF-12-2-2022\KOF\KOF\Views\Home\Checkout.cshtml"
   if (ViewBag.orderadded == "Success")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n\r\n\r\n        Swal.fire(\r\n            \'Order Placed Successfully!\',\r\n            \'We Will Contact You Soon!\',\r\n            \'success\'\r\n        )\r\n\r\n\r\n\r\n    </script> ");
#nullable restore
#line 35 "D:\personal\KOF-12-2-2022\KOF\KOF\Views\Home\Checkout.cshtml"
              } 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""page-heading"">
    <div class=""page-title"">
        <h2>Cart</h2>
    </div>
</div>
<div class=""main-container col1-layout"">
    <div class=""main container"">
        <div class=""row"">
            <section class=""col-main col-sm-12"">
                <div class=""one-page-checkout"">
                    <div class=""woocommerce"">
                        <div class=""woocommerce-notices-wrapper""></div><div class=""woocommerce-form-coupon-toggle"">

                            <div class=""woocommerce-info"">
                                Have a coupon? <a href=""#"" class=""showcoupon"">Click here to enter your code</a>
                            </div>
                        </div>

                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3df0b8e73ff4c4f7a573074ecb03087b61551bec8802", async() => {
                WriteLiteral(@"

                            <p>If you have a coupon code, please apply it below.</p>

                            <p class=""form-row form-row-first"">
                                <input type=""text"" name=""coupon_code"" class=""input-text"" placeholder=""Coupon code"" id=""coupon_code""");
                BeginWriteAttribute("value", " value=\"", 2845, "\"", 2853, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            </p>

                            <p class=""form-row form-row-last"">
                                <button type=""submit"" class=""button"" name=""apply_coupon"" value=""Apply coupon"">Apply coupon</button>
                            </p>

                            <div class=""clear""></div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div class=\"woocommerce-notices-wrapper\"></div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3df0b8e73ff4c4f7a573074ecb03087b61551bec11315", async() => {
                WriteLiteral(@"



                            <div class=""col2-set"" id=""customer_details"">
                                <div class=""col-1"">
                                    <div class=""woocommerce-billing-fields"">

                                        <h3>Billing details</h3>



                                        <div class=""woocommerce-billing-fields__field-wrapper"">


                                            <p class=""form-row address-field validate-required form-row-wide"" id=""billing_address_1_field"" data-priority=""50""><label for=""billing_address_1""");
                BeginWriteAttribute("class", " class=\"", 4009, "\"", 4017, 0);
                EndWriteAttribute();
                WriteLiteral(">Street address&nbsp;<abbr class=\"required\" title=\"required\">*</abbr></label><span class=\"woocommerce-input-wrapper\"><input type=\"text\" class=\"input-text \" name=\"streadaddress\" id=\"billing_address_1\" placeholder=\"House number and street name\"");
                BeginWriteAttribute("value", " value=\"", 4260, "\"", 4268, 0);
                EndWriteAttribute();
                WriteLiteral(@" autocomplete=""address-line1"" data-placeholder=""House number and street name""></span></p>
                                            <p class=""form-row address-field form-row-wide"" id=""billing_address_2_field"" data-priority=""60""><label for=""billing_address_2"" class=""screen-reader-text"">Apartment, suite, unit, etc.&nbsp;<span class=""optional"">(optional)</span></label><span class=""woocommerce-input-wrapper""><input type=""text"" class=""input-text "" name=""homeadderess"" id=""billing_address_2"" placeholder=""Apartment, suite, unit, etc. (optional)""");
                BeginWriteAttribute("value", " value=\"", 4815, "\"", 4823, 0);
                EndWriteAttribute();
                WriteLiteral(@" autocomplete=""address-line2"" data-placeholder=""Apartment, suite, unit, etc. (optional)""></span></p>
                                            <p class=""form-row address-field validate-required form-row-wide"" id=""billing_city_field"" data-priority=""70"" data-o_class=""form-row form-row-wide address-field validate-required""><label for=""billing_city""");
                BeginWriteAttribute("class", " class=\"", 5174, "\"", 5182, 0);
                EndWriteAttribute();
                WriteLiteral(">Town / City&nbsp;<abbr class=\"required\" title=\"required\">*</abbr></label><span class=\"woocommerce-input-wrapper\"><input type=\"text\" class=\"input-text \" name=\"city\" id=\"billing_city\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 5365, "\"", 5379, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 5380, "\"", 5388, 0);
                EndWriteAttribute();
                WriteLiteral(" autocomplete=\"address-level2\"></span></p>\r\n                                            <p class=\"form-row form-row-wide validate-required validate-phone\" id=\"billing_phone_field\" data-priority=\"100\"><label for=\"billing_phone\"");
                BeginWriteAttribute("class", " class=\"", 5615, "\"", 5623, 0);
                EndWriteAttribute();
                WriteLiteral(">Phone&nbsp;<abbr class=\"required\" title=\"required\">*</abbr></label><span class=\"woocommerce-input-wrapper\"><input type=\"tel\" class=\"input-text \" name=\"phone\" id=\"billing_phone\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 5801, "\"", 5815, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 5816, "\"", 5824, 0);
                EndWriteAttribute();
                WriteLiteral(" autocomplete=\"tel\"></span></p>\r\n                                            <p class=\"form-row form-row-wide validate-required validate-email\" id=\"billing_email_field\" data-priority=\"110\"><label for=\"billing_email\"");
                BeginWriteAttribute("class", " class=\"", 6040, "\"", 6048, 0);
                EndWriteAttribute();
                WriteLiteral(">Email address&nbsp;<abbr class=\"required\" title=\"required\">*</abbr></label><span class=\"woocommerce-input-wrapper\"><input type=\"email\" class=\"input-text \" name=\"email\" id=\"billing_email\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 6236, "\"", 6250, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 6251, "\"", 6259, 0);
                EndWriteAttribute();
                WriteLiteral(@" autocomplete=""email""></span></p>
                                        </div>

                                    </div>


                                </div>

                                <div class=""col-2"">
                                    <div class=""woocommerce-shipping-fields"">
                                    </div>
                                    <div class=""woocommerce-additional-fields"">



                                        <h3>Additional information</h3>


                                        <div class=""woocommerce-additional-fields__field-wrapper"">
                                            <p class=""form-row notes"" id=""order_comments_field"" data-priority=""""><label for=""order_comments""");
                BeginWriteAttribute("class", " class=\"", 7015, "\"", 7023, 0);
                EndWriteAttribute();
                WriteLiteral(@">Order notes&nbsp;<span class=""optional"">(optional)</span></label><span class=""woocommerce-input-wrapper""><textarea name=""Ordernote"" class=""input-text "" id=""order_comments"" placeholder=""Notes about your order, e.g. special notes for delivery."" rows=""2"" cols=""5""></textarea></span></p>
                                        </div>


                                    </div>
                                </div>
                            </div>




                            <h3 id=""order_review_heading"">Your order</h3>


                            <div id=""order_review"" class=""woocommerce-checkout-review-order"">
                                <table class=""shop_table woocommerce-checkout-review-order-table"">
                                    <thead>
                                        <tr>
                                            <th class=""product-name"">Product</th>
                                            <th class=""product-total"">Subtotal</th>
                         ");
                WriteLiteral("               </tr>\r\n                                    </thead>\r\n                                    <tbody>\r\n");
#nullable restore
#line 130 "D:\personal\KOF-12-2-2022\KOF\KOF\Views\Home\Checkout.cshtml"
                                         foreach (var item in mycart)
                                        {
                                            var productname = _dbContext.Products.Where(x => x.Id == item.ProductId).SingleOrDefault().Name;

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr class=\"cart_item\">\r\n                                <td class=\"product-name\">\r\n                                    ");
#nullable restore
#line 135 "D:\personal\KOF-12-2-2022\KOF\KOF\Views\Home\Checkout.cshtml"
                               Write(productname);

#line default
#line hidden
#nullable disable
                WriteLiteral("&nbsp;\t\t\t\t\t\t <strong class=\"product-quantity\">(");
#nullable restore
#line 135 "D:\personal\KOF-12-2-2022\KOF\KOF\Views\Home\Checkout.cshtml"
                                                                                                            Write(item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("×&nbsp;");
#nullable restore
#line 135 "D:\personal\KOF-12-2-2022\KOF\KOF\Views\Home\Checkout.cshtml"
                                                                                                                                 Write(item.PerUnitPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(@")</strong>
                                </td>
                                <td class=""product-total"">
                                    <span class=""woocommerce-Price-amount amount""><bdi><span class=""woocommerce-Price-currencySymbol"">Rs : </span>");
#nullable restore
#line 138 "D:\personal\KOF-12-2-2022\KOF\KOF\Views\Home\Checkout.cshtml"
                                                                                                                                              Write(item.Quantity*item.PerUnitPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</bdi></span>\r\n                                </td>\r\n                            </tr>");
#nullable restore
#line 140 "D:\personal\KOF-12-2-2022\KOF\KOF\Views\Home\Checkout.cshtml"
                                 }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </tbody>
                                    <tfoot>

                                        <tr class=""cart-subtotal"">
                                            <th>Subtotal</th>
                                            <td><span class=""woocommerce-Price-amount amount""><bdi><span class=""woocommerce-Price-currencySymbol"">Rs : </span>");
#nullable restore
#line 147 "D:\personal\KOF-12-2-2022\KOF\KOF\Views\Home\Checkout.cshtml"
                                                                                                                                                         Write(mycart.Sum(x => x.TotalPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</bdi></span></td>
                                        </tr>






                                        <tr class=""order-total"">
                                            <th>Total</th>
                                            <td><strong><span class=""woocommerce-Price-amount amount""><bdi><span class=""woocommerce-Price-currencySymbol"">Rs : </span>");
#nullable restore
#line 157 "D:\personal\KOF-12-2-2022\KOF\KOF\Views\Home\Checkout.cshtml"
                                                                                                                                                                 Write(mycart.Sum(x => x.TotalPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</bdi></span></strong> </td>
                                        </tr>


                                    </tfoot>
                                </table>

                                <div id=""payment"" class=""woocommerce-checkout-payment"">
                                    
                                    <div class=""form-row place-order"">
                                        <noscript>
                                            Since your browser does not support JavaScript, or it is disabled, please ensure you click the <em>Update Totals</em> button before placing your order. You may be charged more than the amount stated above if you fail to do so.			<br /><button type=""submit"" class=""button alt"" name=""woocommerce_checkout_update_totals"" value=""Update totals"">Update totals</button>
                                        </noscript>

                                        <div class=""woocommerce-terms-and-conditions-wrapper"">
                                           ");
                WriteLiteral(@" <div class=""woocommerce-privacy-policy-text"">
                                                <p>Your personal data will be used to process your order, support your experience throughout this website, and for other purposes described in our <a href=""https://klbtheme.com/qualis/?page_id=3"" class=""woocommerce-privacy-policy-link"" target=""_blank"">privacy policy</a>.</p>
                                            </div>
                                        </div>
");
#nullable restore
#line 176 "D:\personal\KOF-12-2-2022\KOF\KOF\Views\Home\Checkout.cshtml"
                                         if (mycart.Count() > 0)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <button type=\"submit\" class=\"button alt\" name=\"woocommerce_checkout_place_order\" id=\"place_order\" value=\"Place order\" data-value=\"Place order\">Place order</button>");
#nullable restore
#line 178 "D:\personal\KOF-12-2-2022\KOF\KOF\Views\Home\Checkout.cshtml"
                                                                                                                                                                                               }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                    </div>\r\n                                </div>\r\n\r\n                            </div>\r\n\r\n\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n            </section>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--WPFC_FOOTER_START-->\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public KOF.Context.ApplicationDbContext _dbContext { get; private set; }
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
