#pragma checksum "I:\IIHT\Note App\JuniorFSE\Project\NoteApplicationWithMongoDb\NoteApplication\Views\NotesApp\GetAllNotes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9df2e2dc3e3e4ec6a80af8782ad117c664dac23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NotesApp_GetAllNotes), @"mvc.1.0.view", @"/Views/NotesApp/GetAllNotes.cshtml")]
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
#line 1 "I:\IIHT\Note App\JuniorFSE\Project\NoteApplicationWithMongoDb\NoteApplication\Views\_ViewImports.cshtml"
using NoteApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "I:\IIHT\Note App\JuniorFSE\Project\NoteApplicationWithMongoDb\NoteApplication\Views\_ViewImports.cshtml"
using NoteApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9df2e2dc3e3e4ec6a80af8782ad117c664dac23", @"/Views/NotesApp/GetAllNotes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a599dfbbf867dfcfa1cfbcb4b827494c6f6b5eda", @"/Views/_ViewImports.cshtml")]
    public class Views_NotesApp_GetAllNotes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NoteApplication.Entities.Notes>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateNotes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteNotes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "I:\IIHT\Note App\JuniorFSE\Project\NoteApplicationWithMongoDb\NoteApplication\Views\NotesApp\GetAllNotes.cshtml"
  
    ViewData["Title"] = "AllNotes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>AllNotes</h1>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Title</th>\r\n        <th>Author</th>\r\n        <th>Discription</th>\r\n        <th>Action</th>\r\n        <th>Edit/Delete</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "I:\IIHT\Note App\JuniorFSE\Project\NoteApplicationWithMongoDb\NoteApplication\Views\NotesApp\GetAllNotes.cshtml"
     foreach (var list in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>\r\n        ");
#nullable restore
#line 21 "I:\IIHT\Note App\JuniorFSE\Project\NoteApplicationWithMongoDb\NoteApplication\Views\NotesApp\GetAllNotes.cshtml"
   Write(Html.DisplayFor(modelitem => list.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 24 "I:\IIHT\Note App\JuniorFSE\Project\NoteApplicationWithMongoDb\NoteApplication\Views\NotesApp\GetAllNotes.cshtml"
   Write(Html.DisplayFor(modelitem => list.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 27 "I:\IIHT\Note App\JuniorFSE\Project\NoteApplicationWithMongoDb\NoteApplication\Views\NotesApp\GetAllNotes.cshtml"
   Write(Html.DisplayFor(modelitem => list.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 30 "I:\IIHT\Note App\JuniorFSE\Project\NoteApplicationWithMongoDb\NoteApplication\Views\NotesApp\GetAllNotes.cshtml"
   Write(Html.DisplayFor(modelitem => list.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 33 "I:\IIHT\Note App\JuniorFSE\Project\NoteApplicationWithMongoDb\NoteApplication\Views\NotesApp\GetAllNotes.cshtml"
   Write(Html.DisplayFor(modelitem => list.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9df2e2dc3e3e4ec6a80af8782ad117c664dac236217", async() => {
                WriteLiteral("Edit/");
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
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9df2e2dc3e3e4ec6a80af8782ad117c664dac237379", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </td>\r\n</tr>\r\n");
#nullable restore
#line 40 "I:\IIHT\Note App\JuniorFSE\Project\NoteApplicationWithMongoDb\NoteApplication\Views\NotesApp\GetAllNotes.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<div>\r\n    <input type=\"button\" value=\"HomePage\"");
            BeginWriteAttribute("onclick", " onclick=\"", 921, "\"", 975, 3);
            WriteAttributeValue("", 931, "location.href=\'", 931, 15, true);
#nullable restore
#line 44 "I:\IIHT\Note App\JuniorFSE\Project\NoteApplicationWithMongoDb\NoteApplication\Views\NotesApp\GetAllNotes.cshtml"
WriteAttributeValue("", 946, Url.Action("Index", "Home"), 946, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 974, "\'", 974, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NoteApplication.Entities.Notes>> Html { get; private set; }
    }
}
#pragma warning restore 1591
