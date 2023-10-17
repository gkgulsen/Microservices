#pragma checksum "C:\Users\ggulsen\source\repos\Microservices\Frontends\MVC\Views\Home\Detail.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "00c8a1227f4f37ff575ce60ae950eac072f74ed639001146554d7593cfca2f5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ggulsen\source\repos\Microservices\Frontends\MVC\Views\_ViewImports.cshtml"
using FreeCourse.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ggulsen\source\repos\Microservices\Frontends\MVC\Views\_ViewImports.cshtml"
using FreeCourse.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ggulsen\source\repos\Microservices\Frontends\MVC\Views\_ViewImports.cshtml"
using FreeCourse.Web.Models.Catalogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ggulsen\source\repos\Microservices\Frontends\MVC\Views\_ViewImports.cshtml"
using FreeCourse.Web.Models.Baskets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ggulsen\source\repos\Microservices\Frontends\MVC\Views\_ViewImports.cshtml"
using FreeCourse.Web.Models.Orders;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"00c8a1227f4f37ff575ce60ae950eac072f74ed639001146554d7593cfca2f5e", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7f97ac767323ff6da64132cfe9539674295911114d69238c73433aa5a82cc133", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBasketItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ggulsen\source\repos\Microservices\Frontends\MVC\Views\Home\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-9\">\n\n        <div class=\"card\">\n            <img");
            BeginWriteAttribute("src", " src=\"", 153, "\"", 181, 1);
#nullable restore
#line 11 "C:\Users\ggulsen\source\repos\Microservices\Frontends\MVC\Views\Home\Detail.cshtml"
WriteAttributeValue("", 159, Model.StockPictureUrl, 159, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" />\n            <div class=\"card-body\">\n                <h5 class=\"card-title\">");
#nullable restore
#line 13 "C:\Users\ggulsen\source\repos\Microservices\Frontends\MVC\Views\Home\Detail.cshtml"
                                  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                <div class=\"badge bg-primary\">Kategori : ");
#nullable restore
#line 14 "C:\Users\ggulsen\source\repos\Microservices\Frontends\MVC\Views\Home\Detail.cshtml"
                                                    Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                <p class=\"card-text\"> ");
#nullable restore
#line 15 "C:\Users\ggulsen\source\repos\Microservices\Frontends\MVC\Views\Home\Detail.cshtml"
                                 Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n        </div>\n    </div>\n\n    <div class=\"col-md-3\">\n        <div class=\"card\">\n            <div class=\"card-body\">\n                <h4 class=\"card-title\">Fiyat : ");
#nullable restore
#line 23 "C:\Users\ggulsen\source\repos\Microservices\Frontends\MVC\Views\Home\Detail.cshtml"
                                          Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</h4>\n                <div class=\"d-grid\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00c8a1227f4f37ff575ce60ae950eac072f74ed639001146554d7593cfca2f5e7080", async() => {
                WriteLiteral("Sepete ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-courseId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\ggulsen\source\repos\Microservices\Frontends\MVC\Views\Home\Detail.cshtml"
                                                                                  WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["courseId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-courseId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["courseId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
