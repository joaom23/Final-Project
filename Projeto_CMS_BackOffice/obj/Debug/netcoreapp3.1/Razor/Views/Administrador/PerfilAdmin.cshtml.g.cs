#pragma checksum "D:\3 Ano\Projeto\Projeto\Projeto_CMS_BackOffice\Views\Administrador\PerfilAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d75ccc61f4b5828fb6f1d8924c67ec9d9cf3638"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_PerfilAdmin), @"mvc.1.0.view", @"/Views/Administrador/PerfilAdmin.cshtml")]
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
#line 1 "D:\3 Ano\Projeto\Projeto\Projeto_CMS_BackOffice\Views\_ViewImports.cshtml"
using Projeto_CMS_BackOffice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\3 Ano\Projeto\Projeto\Projeto_CMS_BackOffice\Views\_ViewImports.cshtml"
using Projeto_CMS_BackOffice.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\3 Ano\Projeto\Projeto\Projeto_CMS_BackOffice\Views\Administrador\PerfilAdmin.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d75ccc61f4b5828fb6f1d8924c67ec9d9cf3638", @"/Views/Administrador/PerfilAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e9b2e183eb0482d4489a19e4be266a1cca6f229", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_PerfilAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Projeto_CMS_BackOffice.Administrador>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SubmeterAlterarPalavraPasse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-popup-content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\3 Ano\Projeto\Projeto\Projeto_CMS_BackOffice\Views\Administrador\PerfilAdmin.cshtml"
  
    ViewData["Title"] = "PerfilCliente";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Perfil Admin</h1>\r\n\r\n");
#nullable restore
#line 10 "D:\3 Ano\Projeto\Projeto\Projeto_CMS_BackOffice\Views\Administrador\PerfilAdmin.cshtml"
 if (ViewBag.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 200, "\"", 251, 4);
            WriteAttributeValue("", 208, "alert", 208, 5, true);
            WriteAttributeValue(" ", 213, "alert-", 214, 7, true);
#nullable restore
#line 12 "D:\3 Ano\Projeto\Projeto\Projeto_CMS_BackOffice\Views\Administrador\PerfilAdmin.cshtml"
WriteAttributeValue("", 220, ViewBag.Type, 220, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 233, "alert-dismissible", 234, 18, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n        ");
#nullable restore
#line 14 "D:\3 Ano\Projeto\Projeto\Projeto_CMS_BackOffice\Views\Administrador\PerfilAdmin.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 16 "D:\3 Ano\Projeto\Projeto\Projeto_CMS_BackOffice\Views\Administrador\PerfilAdmin.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""perfil-foto"">
    <img src=""http://127.0.0.1:2626/api/administrador/ImageGetDefault/admin.jpg"" />
</div>


<table class=""table"">
    <thead>
        <tr>
            <th>
                Seu Id
            </th>
            <th>
                Email
            </th>
            <th>
                Nome
            </th>

            <th></th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>
                ");
#nullable restore
#line 42 "D:\3 Ano\Projeto\Projeto\Projeto_CMS_BackOffice\Views\Administrador\PerfilAdmin.cshtml"
           Write(Html.DisplayFor(modelItem => Model.IdANavegation.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "D:\3 Ano\Projeto\Projeto\Projeto_CMS_BackOffice\Views\Administrador\PerfilAdmin.cshtml"
           Write(Html.DisplayFor(modelItem => Model.IdANavegation.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "D:\3 Ano\Projeto\Projeto\Projeto_CMS_BackOffice\Views\Administrador\PerfilAdmin.cshtml"
           Write(Html.DisplayFor(modelItem => Model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a onclick=\"openForm()\" class=\"open-form\">Alterar Palavra-Passe</a>\r\n            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n\r\n<div class=\"form-popup\" id=\"emailForm\" style=\"display: none;\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d75ccc61f4b5828fb6f1d8924c67ec9d9cf36387919", async() => {
                WriteLiteral(@"

        <label><b>Alterar Palavra Pass</b></label><br />

        <label>Por favor insira a palavra passe antiga</label><br />
        <input id=""password1"" type=""password"" placeholder=""Palavra passe antiga"" name=""passAntiga"" required style=""width: 40%;"">
        <i class=""bi bi-eye-slash"" id=""1"" style=""position:relative; margin-left: 80%; top:-30px; cursor:pointer;"" onclick=""showPassword(this.id)""></i><br />

        <label>Nova palavra passe</label><br />
        <input id=""password2"" type=""password"" placeholder=""Nova palavra passe"" name=""passNova"" required style=""width: 40%;"">
        <i class=""bi bi-eye-slash"" id=""2"" style=""position:relative; margin-left: 80%; top:-30px; cursor:pointer;"" onclick=""showPassword(this.id)""></i><br />

        <label>Confirmar nova palavra passe</label><br />
        <input id=""password3"" type=""password"" placeholder=""Confirmar nova palavra passe"" name=""passNovaConfirmar"" required style=""width: 40%;"">
        <i class=""bi bi-eye-slash"" id=""3"" style=""position:rel");
                WriteLiteral(@"ative; margin-left: 80%; top:-30px; cursor:pointer;"" onclick=""showPassword(this.id)""></i><br />

        <span class=""close-form"" onclick=""closeForm()"">&times;</span><br />
        <input type=""submit"" value=""Ok"" class=""btn btn-success"" style=""width: 30%;"" />
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function openForm() {
            document.getElementById(""emailForm"").style.display = ""block"";
        }

        function closeForm() {
            document.getElementById(""emailForm"").style.display = ""none"";
        }


        function showPassword() {
            var button = document.getElementById(""togglePassword"");
            var x = document.getElementById(""password"");
            if (x.type === ""password"") {
                x.type = ""text"";
                button.classList.add(""bi-eye"");
            } else {
                x.type = ""password"";
                button.classList.remove(""bi-eye"");
            }
        }

        function showPassword(id) {
            var button = document.getElementById(id);
            var x = document.getElementById(""password"" + id);
            if (x.type === ""password"") {
                x.type = ""text"";
                button.classList.add(""bi-eye"");
            } else {
                x.type = ""password"";
 ");
                WriteLiteral("               button.classList.remove(\"bi-eye\");\r\n            }\r\n        }\r\n\r\n    </script>\r\n");
#nullable restore
#line 116 "D:\3 Ano\Projeto\Projeto\Projeto_CMS_BackOffice\Views\Administrador\PerfilAdmin.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projeto_CMS_BackOffice.Administrador> Html { get; private set; }
    }
}
#pragma warning restore 1591
