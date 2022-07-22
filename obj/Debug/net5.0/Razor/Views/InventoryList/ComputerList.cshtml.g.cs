#pragma checksum "D:\source\vs-code\WebNDTIT01\Views\InventoryList\ComputerList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "192e8e274ad409180facc93243b5cd2351e64958"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InventoryList_ComputerList), @"mvc.1.0.view", @"/Views/InventoryList/ComputerList.cshtml")]
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
#line 1 "D:\source\vs-code\WebNDTIT01\Views\_ViewImports.cshtml"
using WebNDTIT01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\source\vs-code\WebNDTIT01\Views\_ViewImports.cshtml"
using WebNDTIT01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"192e8e274ad409180facc93243b5cd2351e64958", @"/Views/InventoryList/ComputerList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d16d438ee9b8a7641a6f079ba4ccee8c400f759d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_InventoryList_ComputerList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<WebNDTIT01.Models.GetAll>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/datatablecomputer.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\source\vs-code\WebNDTIT01\Views\InventoryList\ComputerList.cshtml"
  ViewData["Title"] = "Computer List";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
  <div class=""content-header"">
      <div class=""container-fluid"">
        <div class=""row mb-2"">
          <div class=""col-sm-6"">
            <h1 class=""m-0"">Computer List</h1>
          </div><!-- /.col -->
          <div class=""col-sm-6"">
            <ol class=""breadcrumb float-sm-right"">
              <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
              <li class=""breadcrumb-item active"">Computer List</li>
            </ol>
          </div><!-- /.col -->
        </div><!-- /.row -->
      </div><!-- /.container-fluid -->
    </div>
    <!-- /.content-header -->
    <!-- Main content -->
      <div class=""content"">
        <div class=""container-fluid"">
          <div class=""row"">
            <div class=""col-lg-12"">
              <div class=""card"">
                <div class=""card-header border-0"">
                  <div class=""d-flex justify-content-between"">
                    <h3 class=""card-title"">Computer List</h3>
                  </div>
                   ");
            WriteLiteral(@" <div id=""printbar"" style=""margin-top: 10px;""></div>
                </div>
                <div class=""card-body"">
                  <table id=""example"" class=""table table-bordered table-striped"" style=""width:100%"">
                          <thead>
                              <tr>
                                <th></th>
                                <th >Computer Name </th>
                                <th class=""none"">Operating System </th>
                                <th class=""none"">Ostype </th>
                                <th class=""none"">Computer-Manufacturer </th>
                                <th >Model </th>
                                <th >SerialNo </th>
                                <th class=""none"">Cpu </th>
                                <th class=""none"">Ram </th>
                                <th>Asset No. </th>
                                <th class=""none"">Network Type </th>
                                <th>IP Address </th>
                  ");
            WriteLiteral(@"              <th class=""none"">Mac-Address </th>
                                <th class=""none"">Domain </th>
                                <th class=""none"">User Name </th>
                                <th class=""none"">Lastname</th>
                                <th class=""none"">Monitor-Manufacturer</th>
                                <th class=""none"">Monitor-Model</th>
                                <th class=""none"">Monitor-SerialNo</th>
                                <th class=""none"">Monitor-Asset</th>
                                <th>Last Update</th>
                              </tr>
                          </thead>
                          <tfoot>
                              <tr>
                                  <th></th>
                                  <th>ComputerName </th>
                                  <th>Os </th>
                                  <th>Ostype </th>
                                  <th>ComManufacturer </th>
                                 ");
            WriteLiteral(@" <th>ComModel </th>
                                  <th>ComSerialNo </th>
                                  <th>Cpu </th>
                                  <th>Ram </th>
                                  <th>AssetNo </th>
                                  <th>Nictype </th>
                                  <th>Ipadds </th>
                                  <th>MacAdds </th>
                                  <th>Domain </th>
                                  <th>UserName </th>
                                  <th>UserLastname</th>
                                  <th>MonitorManufacturer</th>
                                  <th>MonitorModel</th>
                                  <th>MonitorSerialNo</th>
                                  <th>MonitorAsset</th>
                                  <th>Last Update</th>
                              </tr>
                          </tfoot>
                  </table>
                </div>
              </div>
            </div>
          </d");
            WriteLiteral(@"iv>
        </div>
      </div>

  <!--    <div class=""content"">
        <div class=""container-fluid"">
          <div class=""row"">
          <div class=""col-lg-12"">
            <div class=""card"">
              <div class=""card-header border-0"">
                <div class=""d-flex justify-content-between"">
                  <h3 class=""card-title"">Computer List</h3>
                </div>
              </div>
              <div class=""card-body"">
                <table id=""example"" class=""table table-bordered table-striped"">
                  <thead>
                  <tr>
                    <th>ComputerName </th>
                    <th>AssetNo </th>
                    <th>Os </th>
                    <th>Ostype </th>
                    <th>ComManufacturer </th>
                    <th>ComModel </th>
                    <th>ComSerialNo </th>
                    <th>CpuModel </th>
                    <th>Ramsize </th>
                    <th>Nictype </th>
                    <th>Ip");
            WriteLiteral(@"adds </th>
                    <th>MacAdds </th>
                    <th>Domain </th>
                    <th>UserName </th>
                    <th>UserLastname</th>
                    <th>MonitorManufacturer</th>
                    <th>MonitorModel</th>
                    <th>MonitorSerialNo</th>
                    <th>MonitorAsset</th>
                    <th>Last Update</th>
                  </tr>
                  </thead>
                  <tbody>
");
#nullable restore
#line 130 "D:\source\vs-code\WebNDTIT01\Views\InventoryList\ComputerList.cshtml"
                   foreach (var item in Model)
                      {

#line default
#line hidden
#nullable disable
            WriteLiteral("                          <tr>\r\n                            <td>");
#nullable restore
#line 133 "D:\source\vs-code\WebNDTIT01\Views\InventoryList\ComputerList.cshtml"
                           Write(item.ComputerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td>");
#nullable restore
#line 134 "D:\source\vs-code\WebNDTIT01\Views\InventoryList\ComputerList.cshtml"
                           Write(item.AssetNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td>");
#nullable restore
#line 135 "D:\source\vs-code\WebNDTIT01\Views\InventoryList\ComputerList.cshtml"
                           Write(item.Os);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td>");
#nullable restore
#line 136 "D:\source\vs-code\WebNDTIT01\Views\InventoryList\ComputerList.cshtml"
                           Write(item.Ostype);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td>");
#nullable restore
#line 137 "D:\source\vs-code\WebNDTIT01\Views\InventoryList\ComputerList.cshtml"
                           Write(item.ComManufacturer);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td>");
#nullable restore
#line 138 "D:\source\vs-code\WebNDTIT01\Views\InventoryList\ComputerList.cshtml"
                           Write(item.ComModel);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td>");
#nullable restore
#line 139 "D:\source\vs-code\WebNDTIT01\Views\InventoryList\ComputerList.cshtml"
                           Write(item.ComSerialNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td>");
#nullable restore
#line 140 "D:\source\vs-code\WebNDTIT01\Views\InventoryList\ComputerList.cshtml"
                           Write(item.CpuModel);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td>");
#nullable restore
#line 141 "D:\source\vs-code\WebNDTIT01\Views\InventoryList\ComputerList.cshtml"
                           Write(item.Ramsize);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td>");
#nullable restore
#line 142 "D:\source\vs-code\WebNDTIT01\Views\InventoryList\ComputerList.cshtml"
                           Write(item.Nictype);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td>");
#nullable restore
#line 143 "D:\source\vs-code\WebNDTIT01\Views\InventoryList\ComputerList.cshtml"
                           Write(item.Ipadds);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td>");
#nullable restore
#line 144 "D:\source\vs-code\WebNDTIT01\Views\InventoryList\ComputerList.cshtml"
                           Write(item.MacAdds);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td>");
#nullable restore
#line 145 "D:\source\vs-code\WebNDTIT01\Views\InventoryList\ComputerList.cshtml"
                           Write(item.Domain);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td>");
#nullable restore
#line 146 "D:\source\vs-code\WebNDTIT01\Views\InventoryList\ComputerList.cshtml"
                           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td>");
#nullable restore
#line 147 "D:\source\vs-code\WebNDTIT01\Views\InventoryList\ComputerList.cshtml"
                           Write(item.UserLastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 148 "D:\source\vs-code\WebNDTIT01\Views\InventoryList\ComputerList.cshtml"
                           Write(item.MonitorManufacturer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 149 "D:\source\vs-code\WebNDTIT01\Views\InventoryList\ComputerList.cshtml"
                           Write(item.MonitorModel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 150 "D:\source\vs-code\WebNDTIT01\Views\InventoryList\ComputerList.cshtml"
                           Write(item.MonitorSerialNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 151 "D:\source\vs-code\WebNDTIT01\Views\InventoryList\ComputerList.cshtml"
                           Write(item.MonitorAsset);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 152 "D:\source\vs-code\WebNDTIT01\Views\InventoryList\ComputerList.cshtml"
                           Write(item.DataUpdate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                          </tr>\r\n");
#nullable restore
#line 154 "D:\source\vs-code\WebNDTIT01\Views\InventoryList\ComputerList.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                  </tbody>
                  <tfoot>
                  <tr>
                    <th>ComputerName </th>
                    <th>AssetNo </th>
                    <th>Os </th>
                    <th>Ostype </th>
                    <th>ComManufacturer </th>
                    <th>ComModel </th>
                    <th>ComSerialNo </th>
                    <th>CpuModel </th>
                    <th>Ramsize </th>
                    <th>Nictype </th>
                    <th>Ipadds </th>
                    <th>MacAdds </th>
                    <th>Domain </th>
                    <th>UserName </th>
                    <th>UserLastname</th>
                    <th>MonitorManufacturer</th>
                    <th>MonitorModel</th>
                    <th>MonitorSerialNo</th>
                    <th>MonitorAsset</th>
                    <th>Last Updat</th>
                  </tr>
                  </tfoot>
                </table>
              </div>
            </div>
");
            WriteLiteral("            </div>\r\n          </div>\r\n        </div>\r\n      </div>-->\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "192e8e274ad409180facc93243b5cd2351e6495816841", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        \r\n      ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<WebNDTIT01.Models.GetAll>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
