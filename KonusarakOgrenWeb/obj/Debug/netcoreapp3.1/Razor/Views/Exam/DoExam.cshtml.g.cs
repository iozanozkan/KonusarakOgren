#pragma checksum "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfd211afb1d77fa71f51cd913c1c8e745d261ecf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exam_DoExam), @"mvc.1.0.view", @"/Views/Exam/DoExam.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfd211afb1d77fa71f51cd913c1c8e745d261ecf", @"/Views/Exam/DoExam.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3d62e0d49b488469e30ad412ce343bac697419d", @"/Views/_ViewImports.cshtml")]
    public class Views_Exam_DoExam : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Exam>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
  
    ViewData["Title"] = "Sınav";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <h1>");
#nullable restore
#line 7 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <p>");
#nullable restore
#line 8 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
      Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p id=\"eId\" style=\"display:none;\">");
#nullable restore
#line 9 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
                                     Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <hr class=\"my-4\">\r\n        <div class=\"row ml-1\">\r\n");
#nullable restore
#line 12 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
             for (int i = 0; i <= Model.Questions.Count - 1; i++)
            {
                int x = i + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6\">\r\n                    <div class=\"row ml-1 mt-2\">\r\n                        ");
#nullable restore
#line 17 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
                   Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral(") ");
#nullable restore
#line 17 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
                       Write(Model.Questions[i].QuestionText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"container\">\r\n                        <div class=\"row ml-2 mt-2\"");
            BeginWriteAttribute("id", " id=\"", 648, "\"", 719, 2);
#nullable restore
#line 20 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 653, Model.Questions[i].Id, 653, 22, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 675, Model.Questions[i].Option1.Replace(" ","-"), 675, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <input");
            BeginWriteAttribute("id", " id=\"", 757, "\"", 816, 3);
#nullable restore
#line 21 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 762, Model.Questions[i].Id, 762, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 784, "+\'s\'+", 784, 5, true);
#nullable restore
#line 21 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 789, Model.Questions[i].Option1, 789, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 830, "\"", 859, 1);
#nullable restore
#line 21 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 837, Model.Questions[i].Id, 837, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-check-input\"");
            BeginWriteAttribute("value", " value=\"", 885, "\"", 920, 1);
#nullable restore
#line 21 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 893, Model.Questions[i].Option1, 893, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <label");
            BeginWriteAttribute("for", " for=\"", 960, "\"", 1020, 3);
#nullable restore
#line 22 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 966, Model.Questions[i].Id, 966, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 988, "+\'s\'+", 988, 5, true);
#nullable restore
#line 22 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 993, Model.Questions[i].Option1, 993, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">A)");
#nullable restore
#line 22 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
                                                                                             Write(Model.Questions[i].Option1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                        <div class=\"row ml-2\"");
            BeginWriteAttribute("id", " id=\"", 1138, "\"", 1209, 2);
#nullable restore
#line 24 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 1143, Model.Questions[i].Id, 1143, 22, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 1165, Model.Questions[i].Option2.Replace(" ","-"), 1165, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <input");
            BeginWriteAttribute("id", " id=\"", 1247, "\"", 1306, 3);
#nullable restore
#line 25 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 1252, Model.Questions[i].Id, 1252, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1274, "+\'s\'+", 1274, 5, true);
#nullable restore
#line 25 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 1279, Model.Questions[i].Option2, 1279, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 1320, "\"", 1349, 1);
#nullable restore
#line 25 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 1327, Model.Questions[i].Id, 1327, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-check-input\"");
            BeginWriteAttribute("value", " value=\"", 1375, "\"", 1410, 1);
#nullable restore
#line 25 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 1383, Model.Questions[i].Option2, 1383, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <label");
            BeginWriteAttribute("for", " for=\"", 1450, "\"", 1510, 3);
#nullable restore
#line 26 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 1456, Model.Questions[i].Id, 1456, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1478, "+\'s\'+", 1478, 5, true);
#nullable restore
#line 26 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 1483, Model.Questions[i].Option2, 1483, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">B)");
#nullable restore
#line 26 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
                                                                                             Write(Model.Questions[i].Option2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                        <div class=\"row ml-2\"");
            BeginWriteAttribute("id", " id=\"", 1628, "\"", 1699, 2);
#nullable restore
#line 28 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 1633, Model.Questions[i].Id, 1633, 22, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 1655, Model.Questions[i].Option3.Replace(" ","-"), 1655, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <input");
            BeginWriteAttribute("id", " id=\"", 1737, "\"", 1796, 3);
#nullable restore
#line 29 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 1742, Model.Questions[i].Id, 1742, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1764, "+\'s\'+", 1764, 5, true);
#nullable restore
#line 29 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 1769, Model.Questions[i].Option3, 1769, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 1810, "\"", 1839, 1);
#nullable restore
#line 29 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 1817, Model.Questions[i].Id, 1817, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-check-input\"");
            BeginWriteAttribute("value", " value=\"", 1865, "\"", 1900, 1);
#nullable restore
#line 29 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 1873, Model.Questions[i].Option3, 1873, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <label");
            BeginWriteAttribute("for", " for=\"", 1940, "\"", 2000, 3);
#nullable restore
#line 30 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 1946, Model.Questions[i].Id, 1946, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1968, "+\'s\'+", 1968, 5, true);
#nullable restore
#line 30 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 1973, Model.Questions[i].Option3, 1973, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">C)");
#nullable restore
#line 30 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
                                                                                             Write(Model.Questions[i].Option3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                        <div class=\"row ml-2\"");
            BeginWriteAttribute("id", " id=\"", 2118, "\"", 2189, 2);
#nullable restore
#line 32 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 2123, Model.Questions[i].Id, 2123, 22, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 2145, Model.Questions[i].Option4.Replace(" ","-"), 2145, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <input");
            BeginWriteAttribute("id", " id=\"", 2227, "\"", 2286, 3);
#nullable restore
#line 33 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 2232, Model.Questions[i].Id, 2232, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2254, "+\'s\'+", 2254, 5, true);
#nullable restore
#line 33 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 2259, Model.Questions[i].Option4, 2259, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 2300, "\"", 2329, 1);
#nullable restore
#line 33 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 2307, Model.Questions[i].Id, 2307, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-check-input\"");
            BeginWriteAttribute("value", " value=\"", 2355, "\"", 2390, 1);
#nullable restore
#line 33 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 2363, Model.Questions[i].Option4, 2363, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <label");
            BeginWriteAttribute("for", " for=\"", 2430, "\"", 2490, 3);
#nullable restore
#line 34 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 2436, Model.Questions[i].Id, 2436, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2458, "+\'s\'+", 2458, 5, true);
#nullable restore
#line 34 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
WriteAttributeValue("", 2463, Model.Questions[i].Option4, 2463, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">D)");
#nullable restore
#line 34 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
                                                                                             Write(Model.Questions[i].Option4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 38 "C:\Users\Ozan\source\repos\KonusarakOgrenWeb\KonusarakOgrenWeb\Views\Exam\DoExam.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <hr class=""my-4"">
        <div class=""row"">
            <div class=""col-md-6 offset-md-3"">
                <button id=""but"" type=""submit"" class=""btn btn-success btn-lg btn-block"">SINAVI TAMAMLA</button>
            </div>
        </div>
    </div> 
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script>
    $(document).ready(function () {
        $(""#but"").click(function () {
            $("".form-check-input"").attr(""disabled"", true)
            var result = document.getElementsByTagName(""input"");
            var selected = new Array();
            var selectedIds = new Array();
            for (j = 0; j < result.length; j++) {
                if (result[j].checked) {
                    selected.push(result[j]);
                    selectedIds.push(result[j].name + result[j].value.replace("" "", ""-""));
                }
                if (j == 3) {
                    if (selected.length == 0) {
                        sele");
            WriteLiteral(@"cted.push({ ""defaultValue"": ""boş"" });
                        selectedIds.push(""boş"");
                    }
                }
                if (j == 7) {
                    if (selected.length == 1) {
                        selected.push({ ""defaultValue"": ""boş"" });
                        selectedIds.push(""boş"");
                    }
                }
                if (j == 11) {
                    if (selected.length == 2) {
                        selected.push({ ""defaultValue"": ""boş"" });
                        selectedIds.push(""boş"");
                    }
                }
                if (j == 15) {
                    if (selected.length == 3) {
                        selected.push({ ""defaultValue"": ""boş"" });
                        selectedIds.push(""boş"");
                    }
                }
            }
            var id = Number(document.getElementById(""eId"").innerHTML);
            $.ajax({
                type: 'POST',
                dataType: 'JSON',");
            WriteLiteral(@"
                url: '/Exam/IsCorrect',
                data: { id: id, question1: selected[0].defaultValue, question2: selected[1].defaultValue, question3: selected[2].defaultValue, question4: selected[3].defaultValue },  
                success: function (response) {
                    for (i = 0; i < response.length; i++) {
                        if (response[i] == false)
                            $(""#"" + selectedIds[i]).attr(""style"", ""background-color:red; color:white;"");
                        else
                            $(""#"" + selectedIds[i]).attr(""style"", ""background-color:green; color:white;"");
                    }
                }
            });
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exam> Html { get; private set; }
    }
}
#pragma warning restore 1591
