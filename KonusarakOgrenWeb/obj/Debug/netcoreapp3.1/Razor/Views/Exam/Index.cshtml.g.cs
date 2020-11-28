#pragma checksum "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83d379aa7b7dc2a4d1b7b6a9cec6dacd8f27f0e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exam_Index), @"mvc.1.0.view", @"/Views/Exam/Index.cshtml")]
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
#line 1 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\_ViewImports.cshtml"
using KonusarakOgrenWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\_ViewImports.cshtml"
using KonusarakOgrenWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83d379aa7b7dc2a4d1b7b6a9cec6dacd8f27f0e5", @"/Views/Exam/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3d62e0d49b488469e30ad412ce343bac697419d", @"/Views/_ViewImports.cshtml")]
    public class Views_Exam_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Exam>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\Index.cshtml"
  
    ViewData["Title"] = "Exam";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Sınavlar</h1>

<table class=""table table-hover"" id=""tableExam"">
    <thead>
        <tr>
            <th scope=""col"">Başlık</th>
            <th scope=""col"">Tarih</th>
            <th scope=""col""></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 17 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\Index.cshtml"
         foreach (var exam in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 405, "\"", 433, 2);
            WriteAttributeValue("", 412, "/Exam/DoExam/", 412, 13, true);
#nullable restore
#line 20 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\Index.cshtml"
WriteAttributeValue("", 425, exam.Id, 425, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\Index.cshtml"
                                           Write(exam.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\Index.cshtml"
           Write(exam.DateAdded.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><button type=\"button\" class=\"btn btn-danger btnDeleteExam\" data-id=\"");
#nullable restore
#line 22 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\Index.cshtml"
                                                                               Write(exam.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Sil</button></td>\r\n        </tr>\r\n");
#nullable restore
#line 24 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</tbody>
</table>


<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script>
    $(""#tableExam"").on(""click"", "".btnDeleteExam"", function () {
        if (confirm(""Sınavı silmek istediğinize emin misiniz?"")) {
            var id = $(this).data(""id"");
            var btn = $(this);
            $.ajax({
                type: ""GET"",
                url: ""/Exam/DeleteExam/"" + id,
                success: function () {
                    btn.parent().parent().remove();
                }
            });
        }
    });
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Exam>> Html { get; private set; }
    }
}
#pragma warning restore 1591
