#pragma checksum "C:\Users\Talvane\source\repos\ProjetoGerenciadorDeTarefas\Projeto.Presentation.Mvc\Views\Usuarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74220bb9fc18b0e88e6c2fbf0f7a9e9e119cfcab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Index), @"mvc.1.0.view", @"/Views/Usuarios/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74220bb9fc18b0e88e6c2fbf0f7a9e9e119cfcab", @"/Views/Usuarios/Index.cshtml")]
    public class Views_Usuarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Projeto.Infra.Data.Entities.Usuario>>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Talvane\source\repos\ProjetoGerenciadorDeTarefas\Projeto.Presentation.Mvc\Views\Usuarios\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74220bb9fc18b0e88e6c2fbf0f7a9e9e119cfcab3053", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74220bb9fc18b0e88e6c2fbf0f7a9e9e119cfcab4112", async() => {
                WriteLiteral("\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Talvane\source\repos\ProjetoGerenciadorDeTarefas\Projeto.Presentation.Mvc\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Talvane\source\repos\ProjetoGerenciadorDeTarefas\Projeto.Presentation.Mvc\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Talvane\source\repos\ProjetoGerenciadorDeTarefas\Projeto.Presentation.Mvc\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Permissao));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Talvane\source\repos\ProjetoGerenciadorDeTarefas\Projeto.Presentation.Mvc\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Senha));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\Talvane\source\repos\ProjetoGerenciadorDeTarefas\Projeto.Presentation.Mvc\Views\Usuarios\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Talvane\source\repos\ProjetoGerenciadorDeTarefas\Projeto.Presentation.Mvc\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Talvane\source\repos\ProjetoGerenciadorDeTarefas\Projeto.Presentation.Mvc\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\Talvane\source\repos\ProjetoGerenciadorDeTarefas\Projeto.Presentation.Mvc\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Permissao));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Talvane\source\repos\ProjetoGerenciadorDeTarefas\Projeto.Presentation.Mvc\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Senha));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1272, "\"", 1302, 1);
#nullable restore
#line 52 "C:\Users\Talvane\source\repos\ProjetoGerenciadorDeTarefas\Projeto.Presentation.Mvc\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 1287, item.IdUsuario, 1287, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1355, "\"", 1385, 1);
#nullable restore
#line 53 "C:\Users\Talvane\source\repos\ProjetoGerenciadorDeTarefas\Projeto.Presentation.Mvc\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 1370, item.IdUsuario, 1370, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1440, "\"", 1470, 1);
#nullable restore
#line 54 "C:\Users\Talvane\source\repos\ProjetoGerenciadorDeTarefas\Projeto.Presentation.Mvc\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 1455, item.IdUsuario, 1455, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "C:\Users\Talvane\source\repos\ProjetoGerenciadorDeTarefas\Projeto.Presentation.Mvc\Views\Usuarios\Index.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\r\n</table>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Projeto.Infra.Data.Entities.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
