#pragma checksum "/home/tociex/dotnet/surplus/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e78832e0a790bff929106275776e0be7577f2f31"
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
#line 1 "/home/tociex/dotnet/surplus/Views/_ViewImports.cshtml"
using surplus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/tociex/dotnet/surplus/Views/_ViewImports.cshtml"
using surplus.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/tociex/dotnet/surplus/Views/Home/Index.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/tociex/dotnet/surplus/Views/Home/Index.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e78832e0a790bff929106275776e0be7577f2f31", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83911b61fd40ce9fd8e0b59b3250bbff6f19a9bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<materialsurplus.Models.Materialsurplus>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "scan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-large btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/home/tociex/dotnet/surplus/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n      <h5>REKAPITULASI HARIAN GUDANG SURPLUS</h5>\r\n<div class=\"row col-md-12\">\r\n<div class=\"box box-info col-md-12\" style=\"margin-bottom:1em\">\r\n\r\n  <div class=\"box-body\">\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e78832e0a790bff929106275776e0be7577f2f314911", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n      <div class=\"col-xs-7\">\r\n        <div class=\"input-group input-daterange\">\r\n          <input type=\"date\" class=\"form-control\"");
                BeginWriteAttribute("value", "  value=\"", 551, "\"", 598, 1);
#nullable restore
#line 19 "/home/tociex/dotnet/surplus/Views/Home/Index.cshtml"
WriteAttributeValue("", 560, DateTime.Today.ToString("dd/mm/yyyy"), 560, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n          <div class=\"input-group-addon\">to</div>\r\n          <input type=\"date\" class=\"form-control\"");
                BeginWriteAttribute("value", "  value=\"", 702, "\"", 749, 1);
#nullable restore
#line 21 "/home/tociex/dotnet/surplus/Views/Home/Index.cshtml"
WriteAttributeValue("", 711, DateTime.Today.ToString("dd/mm/yyyy"), 711, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n         </div>\r\n      </div>\r\n      \r\n      <div class=\"col-xs-5\">\r\n        <button type=\"submit\" class=\"btn btn-large btn-primary\"><i class=\"glyphicon glyphicon-search\"></i> Filter</button>\r\n         ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e78832e0a790bff929106275776e0be7577f2f316398", async() => {
                    WriteLiteral("<i class=\"glyphicon glyphicon-barcode\"></i> Scan");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n      </div>\r\n    </div>\r\n  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
  </div>
  <!-- /.box-body -->
</div>


   <div class=""col-md-12 bg-white border rounded p-2 mb-4"">

   
          <script src=""https://code.highcharts.com/highcharts.js""></script>
          <script src=""https://code.highcharts.com/modules/data.js""></script>
          <script src=""https://code.highcharts.com/modules/exporting.js""></script>
          <script src=""https://code.highcharts.com/modules/accessibility.js""></script>

          <figure class=""highcharts-figure"">
            <div id=""container""></div>

            <table id=""datatable"" style=""display:none"">
              <thead>
                <tr>
                  <th></th>
                  <th>NILAI PEMANFAATAN</th>
                  <th>NILAI STOCK</th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <th>Januari</th>
                  <td>3</td>
                  <td>4</td>
                </tr>
                <tr>
                  <th>Februari</th>
    ");
            WriteLiteral(@"              <td>2</td>
                  <td>0</td>
                </tr>
                <tr>
                  <th>Maret</th>
                  <td>5</td>
                  <td>11</td>
                </tr>
                <tr>
                  <th>April</th>
                  <td>1</td>
                  <td>1</td>
                </tr>
                <tr>
                  <th>Mei</th>
                  <td>2</td>
                  <td>4</td>
                </tr>
              </tbody>
            </table>
          </figure>

          <script>
              
              Highcharts.chart('container', {
            data: {
              table: 'datatable'
            },
            chart: {
              type: 'column'
            },
            title: {
              text: 'NILAI STOCK DAN PEMANFAATAN'
            },
            yAxis: {
              allowDecimals: false,
              title: {
                text: 'Units'
              }
            },
  ");
            WriteLiteral(@"          credits: {
              enabled: false
            },
            tooltip: {
              formatter: function () {
                return '<b>' + this.series.name + '</b><br/>' +
                  this.point.y + ' ' + this.point.name.toLowerCase();
              }
            }
          });
          </script>
    </div>


    <div class=""col-md-12 bg-white border rounded p-2 mb-4"">
         <h6><center>NILAI PEMANFAATAN OLEH USER</center></h6>
        <div class=""table-responsive"">
          <table class=""table table-striped table-bordered dataTable "">
            <caption>List of users</caption>
            <thead>
              <tr>
                <th scope=""col"" rowspan = ""2"">Area</th>
                <th scope=""col"" colspan = ""2"" >Bulan Ini</th>
                <th scope=""col"" colspan = ""2"">Total</th>

              </tr>
              <tr>
                <th scope=""col"">Price</th>
                <th scope=""col"" >Jml Item</th>
                <th scope=""col"">N");
            WriteLiteral("ilai</th>\r\n               \r\n\r\n              </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 138 "/home/tociex/dotnet/surplus/Views/Home/Index.cshtml"
               foreach (var item in  ViewBag.Materials) {
                 var price = 0;
        
                foreach (var item2 in Model.Where(s => s.Material_no == item.Material_no).ToList())
                {                
                        
                        price = int.Parse(item2.Nilai);
                        
                }   

                var result = (int.Parse(item.Qty) * price);


#line default
#line hidden
#nullable disable
            WriteLiteral("              <tr>\r\n                <th>");
#nullable restore
#line 151 "/home/tociex/dotnet/surplus/Views/Home/Index.cshtml"
               Write(item.Area);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 152 "/home/tociex/dotnet/surplus/Views/Home/Index.cshtml"
               Write(String.Format(CultureInfo.CreateSpecificCulture("id-ID"), " {0:C}\n", price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 153 "/home/tociex/dotnet/surplus/Views/Home/Index.cshtml"
               Write(item.Qty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 154 "/home/tociex/dotnet/surplus/Views/Home/Index.cshtml"
               Write(String.Format(CultureInfo.CreateSpecificCulture("id-ID"), " {0:C}\n", result));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                \r\n              </tr>\r\n");
#nullable restore
#line 157 "/home/tociex/dotnet/surplus/Views/Home/Index.cshtml"

               }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"              
            </tbody>
          </table>
        </div>  
    </div>


    
    <div class=""col-md-8 bg-white border rounded p-2 mb-4"">
     
          
        
        <div class=""row"">
            <div class=""col-md-6 bg-white""> 
               <!--<h6><center>NILAI STOCK PERKATEGORI</center></h6>-->
               <div id=""container_donut""></div>
                <script>
                    
                    

var colors = Highcharts.getOptions().colors,
  categories = [
    ""Chrome"",
    
  ],
  data = [
    {
      ""y"": 100,
      //""color"": colors[2],
      ""color"": ""white"",
      ""drilldown"": {
        ""name"": ""Chemical"",
        ""categories"": [
          ""Civil v65.0"",
          ""Civil v64.0"",
//          ""Chrome v63.0"",
          ""Civil v62.0"",
          ""Civil v61.0"",
          ""Civil v60.0"",
          ""Civil v59.0"",
          ""Civil v58.0"",
          ""Civil v57.0"",
          ""Civil v56.0"",
          ""Civil v55.0"",
          ""Civil v54.0""");
            WriteLiteral(@",
          ""Civil v51.0"",
          ""Civil v49.0"",
          ""Civil v48.0"",
          ""Civil v47.0"",
          ""Civil v43.0"",
          ""Civil v29.0""
        ],
        ""data"": [
          0.1,
          1.3,
//          53.02,
          1.4,
          0.88,
          0.56,
          0.45,
          0.49,
          0.32,
          0.29,
          0.79,
          0.18,
          0.13,
          2.16,
          0.13,
          0.11,
          0.17,
          0.26
        ]
      }
    },
    
  ],
  browserData = [],
  versionsData = [],
  i,
  j,
  dataLen = data.length,
  drillDataLen,
  brightness;


// Build the data arrays
for (i = 0; i < dataLen; i += 1) {

  // add browser data
  browserData.push({
    name: categories[i],
    y: data[i].y,
    color: data[i].color
  });

  // add version data
  drillDataLen = data[i].drilldown.data.length;
  for (j = 0; j < drillDataLen; j += 1) {
    brightness = 0.2 - (j / drillDataLen) / 5;
    versionsData.push");
            WriteLiteral(@"({
      name: data[i].drilldown.categories[j],
      y: data[i].drilldown.data[j],
      //color: Highcharts.Color(data[i].color).brighten(brightness).get()
    });
  }
}

// Create the chart
Highcharts.chart('container_donut', {
  chart: {
    type: 'pie'
  },
  title: {
    text: 'NILAI STOCK PERKATEGORI'
  },
  subtitle: {
    text: ''
  },
  credits: {
    enabled: false
  },
  yAxis: {
    title: {
      text: 'Total percent market share'
    }
  },
  plotOptions: {
    pie: {
      shadow: false,
      center: ['50%', '50%']
    }
  },
  tooltip: {
    valueSuffix: '%'
  },
  series: [{
    name: 'Browsers',
    data: browserData,
    size: '30%',
    dataLabels: {
      formatter: function () {
        return this.y > 5 ? this.point.name : null;
      },
      color: 'red',
      distance: -30
    }
  }, {
    name: 'Versions',
    data: versionsData,
    size: '80%',
    innerSize: '79%',
    dataLabels: {
      formatter: function () {
        //");
            WriteLiteral(@" display only if larger than 1
        return this.y > 1 ? '<b>' + this.point.name + ':</b> ' +
          this.y + '%' : null;
      }
    },
    id: 'versions'
  }],
  responsive: {
    rules: [{
      condition: {
        maxWidth: 400
      },
      chartOptions: {
        series: [{
          id: 'versions',
          dataLabels: {
            enabled: false
          }
        }]
      }
    }]
  }
});
                </script>
            </div>
            <div class=""col-md-6 bg-white"">
                 <!--<h6><center>TOTAL STOCK ITEM</center></h6>-->
                 <div id=""container_stok""></div>
                 
                 <script>
                     
                     Highcharts.chart('container_stok', {
  chart: {
    type: 'bar'
  },
  title: {
    text: 'TOTAL STOCK ITEM'
  },
   credits: {
    enabled: false
  },
  xAxis: {
    categories: ['Chemical', 'Civil', 'Electrical', 'Stationary', 'Instrument'],
    title: {
      text: null
  ");
            WriteLiteral(@"  }
  },
  yAxis: {
    min: 0,
    title: {
      text: 'Total (millions)',
      align: 'high'
    },
    labels: {
      overflow: 'justify'
    }
  },
  tooltip: {
    valueSuffix: ' millions'
  },
  plotOptions: {
    bar: {
      dataLabels: {
        enabled: true
      }
    }
  },
  legend: {
    layout: 'vertical',
    align: 'right',
    verticalAlign: 'top',
    x: -40,
    y: 80,
    floating: true,
    borderWidth: 1,
    backgroundColor:
      Highcharts.defaultOptions.legend.backgroundColor || '#FFFFFF',
    shadow: true
  },
  credits: {
    enabled: false
  },
  series: [{
    name: 'Year 1800',
    data: [107, 31, 635, 203, 2]
  }, {
    name: 'Year 1900',
    data: [133, 156, 947, 408, 6]
  }, {
    name: 'Year 2000',
    data: [814, 841, 3714, 727, 31]
  }, {
    name: 'Year 2016',
    data: [1216, 1001, 4436, 738, 40]
  }]
});
                 </script>
            </div>
        </div>
    </div>
    <div class=""col-md-4 bg-white bo");
            WriteLiteral(@"rder rounded p-2 mb-4"">
      
     <div class=""col-md-12""><br>
         <h6><center>Utilitas Gudang Surplus</center></h6>
         <div id=""container_rank""></div>
          <script>
              
              Highcharts.chart('container_rank', {
  chart: {
    plotBackgroundColor: null,
    plotBorderWidth: 0,
    plotShadow: false
  },
  credits: {
    enabled: false
  },
  title: {
    text: '91%',
    align: 'center',
    verticalAlign: 'middle',
    y: 60
  },
  tooltip: {
    pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
  },
  accessibility: {
    point: {
      valueSuffix: '%'
    }
  },
  plotOptions: {
    pie: {
      dataLabels: {
        enabled: true,
        distance: -50,
        style: {
          fontWeight: 'bold',
          color: 'white'
        }
      },
      startAngle: -90,
      endAngle: 90,
      center: ['50%', '75%'],
      size: '110%'
    }
  },
  series: [{
    type: 'pie',
    name: 'Lantai',
    innerSize: '");
            WriteLiteral(@"50%',
    data: [
      ['Lantai', 58.9],
     
      ['', 3.42],
      {
        name: 'Other',
        y: 7.61,
        dataLabels: {
          enabled: false
        }
      }
    ]
  }]
});
          </script>
          
          
<!--              <div id=""container_rank1""></div>-->
<!--          <script>-->
              
<!--              Highcharts.chart('container_rank1', {-->
<!--  chart: {-->
<!--    plotBackgroundColor: null,-->
<!--    plotBorderWidth: 0,-->
<!--    plotShadow: false-->
<!--  },-->
<!--  credits: {-->
<!--    enabled: false-->
<!--  },-->
<!--  title: {-->
<!--    text: '91%',-->
<!--    align: 'center',-->
<!--    verticalAlign: 'middle',-->
<!--    y: 60-->
<!--  },-->
<!--  tooltip: {-->
<!--    pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'-->
<!--  },-->
<!--  accessibility: {-->
<!--    point: {-->
<!--      valueSuffix: '%'-->
<!--    }-->
<!--  },-->
<!--  plotOptions: {-->
<!--    pie: {-->
<!--      dataLabels");
            WriteLiteral(@": {-->
<!--        enabled: true,-->
<!--        distance: -50,-->
<!--        style: {-->
<!--          fontWeight: 'bold',-->
<!--          color: 'white'-->
<!--        }-->
<!--      },-->
<!--      startAngle: -90,-->
<!--      endAngle: 90,-->
<!--      center: ['50%', '75%'],-->
<!--      size: '110%'-->
<!--    }-->
<!--  },-->
<!--  series: [{-->
<!--    type: 'pie',-->
<!--    name: 'RAK',-->
<!--    innerSize: '50%',-->
<!--    data: [-->
<!--      ['Rak', 58.9],-->
     
<!--      ['', 3.42],-->
<!--      {-->
<!--        name: 'Other',-->
<!--        y: 7.61,-->
<!--        dataLabels: {-->
<!--          enabled: false-->
<!--        }-->
<!--      }-->
<!--    ]-->
<!--  }]-->
<!--});-->
<!--          </script>-->
     </div>
    </div>
   
  </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<materialsurplus.Models.Materialsurplus>> Html { get; private set; }
    }
}
#pragma warning restore 1591
