#pragma checksum "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0e1a596b1781e4ca5ee65f8756f67d151fbc7d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/_ViewImports.cshtml"
using Proj3_Ali;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/_ViewImports.cshtml"
using Proj3_Ali.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0e1a596b1781e4ca5ee65f8756f67d151fbc7d6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a01ecb865701035d0ab96ed66ecd4cb58f05aaa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Proj3_Ali.Models.RegisteredUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\n    <h1 class=\"display-4\">Car Loan Application</h1>\n</div>\n");
            WriteLiteral("\n");
#nullable restore
#line 11 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
 using (Html.BeginForm("Submit", "Home", FormMethod.Post))
{

    //Displays summary of all validation errors on a web page
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
                                                                                                             

    //Start of Table

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\n        <tr>\n            <td>");
#nullable restore
#line 21 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.LabelFor(m=>m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("            <td>");
#nullable restore
#line 23 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.TextBoxFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("            <td>");
#nullable restore
#line 25 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.ValidationMessageFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 29 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.LabelFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("            <td>");
#nullable restore
#line 31 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.TextBoxFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("            <td>");
#nullable restore
#line 33 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.ValidationMessageFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 37 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.LabelFor(m => m.Zip));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("            <td>");
#nullable restore
#line 39 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.TextBoxFor(m => m.Zip));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("            <td>");
#nullable restore
#line 41 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.ValidationMessageFor(m => m.Zip));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 45 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("            <td>");
#nullable restore
#line 47 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("            <td>");
#nullable restore
#line 49 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.ValidationMessageFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 53 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.LabelFor(m => m.PhoneNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("            <td>");
#nullable restore
#line 55 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.TextBoxFor(m => m.PhoneNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("            <td>");
#nullable restore
#line 57 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.ValidationMessageFor(m => m.PhoneNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 61 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.LabelFor(m => m.YearlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("            <td>");
#nullable restore
#line 63 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.TextBoxFor(m => m.YearlyIncome, new { @required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("            <td>");
#nullable restore
#line 65 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.ValidationMessageFor(m => m.YearlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 69 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.LabelFor(m => m.LoanTerm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>\n");
            WriteLiteral("                ");
#nullable restore
#line 72 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.DropDownListFor(m => m.LoanTerm, new SelectList(
           new List<SelectListItem> {
               new SelectListItem(){ Text = "24-months", Value = "24-months" },
               new SelectListItem(){ Text = "36-months", Value = "36-months" },
               new SelectListItem(){ Text = "48-months", Value = "48-months" },
               new SelectListItem(){ Text = "60-months", Value = "60-months" },
               new SelectListItem(){ Text = "72-months", Value = "72-months" },
               new SelectListItem(){ Text = "84-months", Value = "84-months" }
           },
           "Text", "Value")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n            </td>\n        </tr>\n");
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 87 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.LabelFor(m => m.CreditCheck));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("            <td>");
#nullable restore
#line 89 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.CheckBoxFor(m => m.CreditCheck));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("            <td>");
#nullable restore
#line 91 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.ValidationMessageFor(m => m.CreditCheck));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 95 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.LabelFor(m => m.PrimaryContact));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>\n");
            WriteLiteral("                ");
#nullable restore
#line 98 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.RadioButtonFor(m => m.PrimaryContact, "Email"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Email\n                <br />\n                ");
#nullable restore
#line 100 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.RadioButtonFor(m => m.PrimaryContact, "Phone"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Phone\n            </td>\n");
            WriteLiteral("            <td>");
#nullable restore
#line 103 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.ValidationMessageFor(m => m.PrimaryContact));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 107 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.LabelFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("            <td>");
#nullable restore
#line 109 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.TextBoxFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("            <td>");
#nullable restore
#line 111 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.ValidationMessageFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 115 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("            <td>");
#nullable restore
#line 117 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("            <td>");
#nullable restore
#line 119 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.ValidationMessageFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 123 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.LabelFor(m => m.PasswordConfirm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("            <td>");
#nullable restore
#line 125 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.PasswordFor(m => m.PasswordConfirm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("            <td>");
#nullable restore
#line 127 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
           Write(Html.ValidationMessageFor(m => m.PasswordConfirm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
            WriteLiteral("    </table>\n");
#nullable restore
#line 131 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
    //End of table

    //Submit button

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Register\" class=\"btn btn-primary\" />\n");
#nullable restore
#line 135 "/Users/MaryamAli/Documents/Spring 2021/IT-330/Proj3-Ali/Proj3-Ali/Views/Home/Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Proj3_Ali.Models.RegisteredUser> Html { get; private set; }
    }
}
#pragma warning restore 1591