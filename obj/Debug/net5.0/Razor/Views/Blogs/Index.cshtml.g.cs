#pragma checksum "C:\Users\hagbe\OneDrive\Documents\Code\TheBlogProject\Views\Blogs\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "977abf12145d06850ed3d268bdf78088e64c5a015c9e910b6884085df2d6047d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogs_Index), @"mvc.1.0.view", @"/Views/Blogs/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\hagbe\OneDrive\Documents\Code\TheBlogProject\Views\_ViewImports.cshtml"
using TheBlogProject

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\hagbe\OneDrive\Documents\Code\TheBlogProject\Views\_ViewImports.cshtml"
using TheBlogProject.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"977abf12145d06850ed3d268bdf78088e64c5a015c9e910b6884085df2d6047d", @"/Views/Blogs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c53c84b3ee93d900b2e9aa3814213808e9bb91a7f18b8db527ffacebdb6f10d1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blogs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TheBlogProject.Models.Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hagbe\OneDrive\Documents\Code\TheBlogProject\Views\Blogs\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "977abf12145d06850ed3d268bdf78088e64c5a015c9e910b6884085df2d6047d4738", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 16 "C:\Users\hagbe\OneDrive\Documents\Code\TheBlogProject\Views\Blogs\Index.cshtml"
                 Html.DisplayNameFor(model => model.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 19 "C:\Users\hagbe\OneDrive\Documents\Code\TheBlogProject\Views\Blogs\Index.cshtml"
                 Html.DisplayNameFor(model => model.Description)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 22 "C:\Users\hagbe\OneDrive\Documents\Code\TheBlogProject\Views\Blogs\Index.cshtml"
                 Html.DisplayNameFor(model => model.Created)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 25 "C:\Users\hagbe\OneDrive\Documents\Code\TheBlogProject\Views\Blogs\Index.cshtml"
                 Html.DisplayNameFor(model => model.Updated)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 28 "C:\Users\hagbe\OneDrive\Documents\Code\TheBlogProject\Views\Blogs\Index.cshtml"
                 Html.DisplayNameFor(model => model.ImageData)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 31 "C:\Users\hagbe\OneDrive\Documents\Code\TheBlogProject\Views\Blogs\Index.cshtml"
                 Html.DisplayNameFor(model => model.ContentType)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 34 "C:\Users\hagbe\OneDrive\Documents\Code\TheBlogProject\Views\Blogs\Index.cshtml"
                 Html.DisplayNameFor(model => model.BlogUser)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\hagbe\OneDrive\Documents\Code\TheBlogProject\Views\Blogs\Index.cshtml"
 foreach (var blog in Model) {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            Write(
#nullable restore
#line 43 "C:\Users\hagbe\OneDrive\Documents\Code\TheBlogProject\Views\Blogs\Index.cshtml"
                 Html.DisplayFor(modelItem => blog.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            Write(
#nullable restore
#line 46 "C:\Users\hagbe\OneDrive\Documents\Code\TheBlogProject\Views\Blogs\Index.cshtml"
                 Html.DisplayFor(modelItem => blog.Description)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            Write(
#nullable restore
#line 49 "C:\Users\hagbe\OneDrive\Documents\Code\TheBlogProject\Views\Blogs\Index.cshtml"
                 Html.DisplayFor(modelItem => blog.Created)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            Write(
#nullable restore
#line 52 "C:\Users\hagbe\OneDrive\Documents\Code\TheBlogProject\Views\Blogs\Index.cshtml"
                 Html.DisplayFor(modelItem => blog.Updated)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            Write(
#nullable restore
#line 55 "C:\Users\hagbe\OneDrive\Documents\Code\TheBlogProject\Views\Blogs\Index.cshtml"
                 Html.DisplayFor(modelItem => blog.ImageData)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            Write(
#nullable restore
#line 58 "C:\Users\hagbe\OneDrive\Documents\Code\TheBlogProject\Views\Blogs\Index.cshtml"
                 Html.DisplayFor(modelItem => blog.ContentType)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            Write(
#nullable restore
#line 61 "C:\Users\hagbe\OneDrive\Documents\Code\TheBlogProject\Views\Blogs\Index.cshtml"
                 Html.DisplayFor(modelItem => blog.BlogUser.Id)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("   \r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "977abf12145d06850ed3d268bdf78088e64c5a015c9e910b6884085df2d6047d11252", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 64 "C:\Users\hagbe\OneDrive\Documents\Code\TheBlogProject\Views\Blogs\Index.cshtml"
                                                    blog.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "977abf12145d06850ed3d268bdf78088e64c5a015c9e910b6884085df2d6047d13482", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 65 "C:\Users\hagbe\OneDrive\Documents\Code\TheBlogProject\Views\Blogs\Index.cshtml"
                                                       blog.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "977abf12145d06850ed3d268bdf78088e64c5a015c9e910b6884085df2d6047d15718", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 66 "C:\Users\hagbe\OneDrive\Documents\Code\TheBlogProject\Views\Blogs\Index.cshtml"
                                                      blog.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 69 "C:\Users\hagbe\OneDrive\Documents\Code\TheBlogProject\Views\Blogs\Index.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TheBlogProject.Models.Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
