#pragma checksum "C:\Users\MASTER\Desktop\FinalProject\LendCar\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "916179053708f0ccd3c88d23422e5f1652cc58d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LendCar.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace LendCar.Pages
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
#line 1 "C:\Users\MASTER\Desktop\FinalProject\LendCar\Pages\_ViewImports.cshtml"
using LendCar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MASTER\Desktop\FinalProject\LendCar\Pages\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MASTER\Desktop\FinalProject\LendCar\Pages\_ViewImports.cshtml"
using X.PagedList.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MASTER\Desktop\FinalProject\LendCar\Pages\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"916179053708f0ccd3c88d23422e5f1652cc58d0", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15b977b634d12c183c18a55cc6d7d457786d75f5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CarList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\MASTER\Desktop\FinalProject\LendCar\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""header"">
    <div class=""container-fluid"">
        <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
            <!-- Indicators -->
            <ol class=""carousel-indicators"">
                <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#myCarousel"" data-slide-to=""1""></li>
                <li data-target=""#myCarousel"" data-slide-to=""2""></li>
                <li data-target=""#myCarousel"" data-slide-to=""3""></li>
            </ol>

            <div class=""carousel-inner"">
                <div class=""item active"">
                    <img src=""images/3qqv6mpm6i12we1r13lqjlaw6.jpg"" alt=""Los Angeles"" style=""width:100%; height: 500px;"">
                </div>

                <div class=""item"">
                    <img src=""images/200117085056-tesla-cars-file.jpg"" alt=""Chicago"" style=""width:100%;height: 500px;"">
                </div>

                <div class=""item"">
                    <img src=""images");
            WriteLiteral(@"/Full-HD-Wallpapers-1080p-Cars.jpg"" alt=""New york"" style=""width:100%; height: 500px;"">
                </div>

                <div class=""item"">
                    <img src=""images/a3xc2bcvf16h733mj3arn429z.jfif"" alt=""New york"" style=""width:100%; height: 500px;"">
                </div>
            </div>

            <a class=""left carousel-control"" href=""#myCarousel"" data-slide=""prev"">
                <span class=""glyphicon glyphicon-chevron-left""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""right carousel-control"" href=""#myCarousel"" data-slide=""next"">
                <span class=""glyphicon glyphicon-chevron-right""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>
    </div>
</section>

<section class=""short-contact"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h1><i class=""fas fa-car""></i> LendCars</h1>
                <div ");
            WriteLiteral(@"class=""map"">
                    <p class=""fas fa-map-marker fa-1x""> <a href=""#""> 310 NE 39th Ave Gainesville, FL 32609</a></p>
                    <p><span class=""fas fa-clock fa-1x""> <strong> Avalable</strong> 9:00 AM - 11:00 PM</span></p>
                    <p><span class=""fas fa-phone-square ""> <strong> Used </strong> (352) 275-5590</span></p>
                </div>
            </div>
        </div>
    </div>
</section>


<section id=""lend-features"" class=""lend-features"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-xs-12"">
                <div class=""ts-intro"">
                    <h2 class=""into-title"">About Us</h2>
                    <h3 class=""into-sub-title"">We deliver landmark projects</h3>
                    <p>
                        We are rethoric question ran over her cheek When she reached the first hills of the Italic Mountains,
                        she had a last view back on the skyline of her hometown Bookmarksgrove,");
            WriteLiteral(@" the headline of Alphabet Village
                        and the subline of her own road, the Line Lane.
                    </p>
                </div><!-- Intro box end -->

                <div class=""gap-20""></div>

                <div class=""row"">
                    <div class=""col-md-6"">
                        <div class=""ts-service-box"">
                            <span class=""ts-service-icon"">
                                <i class=""fa fa-trophy""></i>
                            </span>
                            <div class=""ts-service-box-content"">
                                <h3 class=""service-box-title"">We've Repution for Excellence</h3>
                            </div>
                        </div><!-- Service 1 end -->
                    </div><!-- col end -->

                    <div class=""col-md-6"">
                        <div class=""ts-service-box"">
                            <span class=""ts-service-icon"">
                                <i class=""fas ");
            WriteLiteral(@"fa-car""></i>
                            </span>
                            <div class=""ts-service-box-content"">
                                <h3 class=""service-box-title"">We Buy Cars</h3>
                            </div>
                        </div><!-- Service 2 end -->
                    </div><!-- col end -->
                </div><!-- Content row 1 end -->

                <div class=""row"">
                    <div class=""col-md-6"">
                        <div class=""ts-service-box"">
                            <span class=""ts-service-icon"">
                                <i class=""fa fa-thumbs-up""></i>
                            </span>
                            <div class=""ts-service-box-content"">
                                <h3 class=""service-box-title"">Guided by Commitment</h3>
                            </div>
                        </div><!-- Service 1 end -->
                    </div><!-- col end -->

                    <div class=""col-md-6"">
           ");
            WriteLiteral(@"             <div class=""ts-service-box"">
                            <span class=""ts-service-icon"">
                                <i class=""fa fa-users""></i>
                            </span>
                            <div class=""ts-service-box-content"">
                                <h3 class=""service-box-title"">A Team of Professionals</h3>
                            </div>
                        </div><!-- Service 2 end -->
                    </div><!-- col end -->
                </div><!-- Content row 1 end -->
            </div><!-- Col end -->

            <div class=""col-md-6 col-xs-12 home-panel"">
                <h3 class=""into-sub-title"">Our Values</h3>
                <p>
                    Minim Austin 3 wolf moon scenester aesthetic, umami odio pariatur bitters. Pop-up occaecat taxidermy
                    street art, tattooed beard literally.
                </p>
                <div class=""panel-group"" id=""accordion"">
                    <div class=""panel panel-");
            WriteLiteral(@"default"">
                        <div class=""panel-heading"">
                            <h4 class=""panel-title"">
                                <a data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseOne"">Safety</a>
                            </h4>
                        </div>
                        <div id=""collapseOne"" class=""panel-collapse collapse in"">
                            <div class=""panel-body"">
                                <p>
                                    Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3
                                    wolf moon officia aute, non cupidata
                                </p>
                            </div>
                        </div>
                    </div>
                    <!--/ Panel 1 end-->

                    <div class=""panel panel-default"">
                        <div class=""panel-heading"">
                            <h4 class=""panel-title"">
 ");
            WriteLiteral(@"                               <a data-toggle=""collapse"" class=""collapsed"" data-parent=""#accordion"" href=""#collapseTwo"">
                                    Customer
                                    Service
                                </a>
                            </h4>
                        </div>
                        <div id=""collapseTwo"" class=""panel-collapse collapse"">
                            <div class=""panel-body"">
                                <p>
                                    Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3
                                    wolf moon officia aute, non cupidata
                                </p>
                            </div>
                        </div>
                    </div>
                    <!--/ Panel 2 end-->


                    <div class=""panel panel-default"">
                        <div class=""panel-heading"">
                            <h4 class=");
            WriteLiteral(@"""panel-title"">
                                <a data-toggle=""collapse"" class=""collapsed"" data-parent=""#accordion"" href=""#collapseThree"">
                                    Integrity
                                </a>
                            </h4>
                        </div>
                        <div id=""collapseThree"" class=""panel-collapse collapse"">
                            <div class=""panel-body"">
                                <p>
                                    Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3
                                    wolf moon officia aute, non cupidata
                                </p>
                            </div>
                        </div>
                    </div>
                    <!--/ Panel 3 end-->

                </div>
                <!--/ Accordion end -->

            </div><!-- Col end -->
        </div><!-- Row end -->
    </div><!-- Container end -->
</");
            WriteLiteral("section><!-- Feature are end -->\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "916179053708f0ccd3c88d23422e5f1652cc58d013709", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 203 "C:\Users\MASTER\Desktop\FinalProject\LendCar\Pages\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = (IPagedList)Model.Vehicles;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n\r\n    ");
#nullable restore
#line 207 "C:\Users\MASTER\Desktop\FinalProject\LendCar\Pages\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model.Vehicles, page =>"/Index?Page="+page,
        new X.PagedList.Mvc.Common.PagedListRenderOptions
        {
            DisplayItemSliceAndTotal = true,
            ContainerDivClasses = new[] { "navigation" },
            LiElementClasses = new[] { "page-item" },
            PageClasses = new[] { "page-link" },
        }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'/*ul*/.pagination > li.disabled > a\').addClass(\'page-link\');\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LendCar.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LendCar.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LendCar.Pages.IndexModel>)PageContext?.ViewData;
        public LendCar.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
