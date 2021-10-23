#pragma checksum "/home/tociex/dotnet/surplus/Views/Home/Resize.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "626b17c01185048847975cf5f6b03a7e6da74733"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Resize), @"mvc.1.0.view", @"/Views/Home/Resize.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"626b17c01185048847975cf5f6b03a7e6da74733", @"/Views/Home/Resize.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83911b61fd40ce9fd8e0b59b3250bbff6f19a9bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Resize : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/tociex/dotnet/surplus/Views/Home/Resize.cshtml"
  
    ViewData["Title"] = "Resize";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>");
#nullable restore
#line 4 "/home/tociex/dotnet/surplus/Views/Home/Resize.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

<div class=""row"">
    <div class=""col-md-4"">
            <input type=""file"" id=""uploader"" class=""form-control""><br/>
            <button onclick='resize()' class=""btn btn-primary"">Resize</button><br/><br/>
            <img id=""image"">

    </div>
</div>
<script>
    function resize(){
  //define the width to resize e.g 600px
  var resize_width = 600;//without px

  //get the image selected
  var item = document.querySelector('#uploader').files[0];

  //create a FileReader
  var reader = new FileReader();

  //image turned to base64-encoded Data URI.
  reader.readAsDataURL(item);
  reader.name = item.name;//get the image's name
  reader.size = item.size; //get the image's size
  reader.onload = function(event) {
    var img = new Image();//create a image
    img.src = event.target.result;//result is base64-encoded Data URI
    img.name = event.target.name;//set name (optional)
    img.size = event.target.size;//set size (optional)
    img.onload = function(el) {
      var elem = document.createElement('");
            WriteLiteral(@"canvas');//create a canvas

      //scale the image to 600 (width) and keep aspect ratio
      var scaleFactor = resize_width / el.target.width;
      elem.width = resize_width;
      elem.height = el.target.height * scaleFactor;

      //draw in canvas
      var ctx = elem.getContext('2d');
      ctx.drawImage(el.target, 0, 0, elem.width, elem.height);

      //get the base64-encoded Data URI from the resize image
      var srcEncoded = ctx.canvas.toDataURL('image/png', 1);

      //assign it to thumb src
      document.querySelector('#image').src = srcEncoded;

      /*Now you can send ""srcEncoded"" to the server and
      convert it to a png o jpg. Also can send
      ""el.target.name"" that is the file's name.*/
      
      /*Also if you want to download tha image use this*/
      /*
      var a = document.createElement(""a""); //Create <a>
      a.href =  srcEncoded; //set srcEncoded as src
      a.download = ""myimage.png""; //set a name for the file
      a.click();
      
      */


    }
  }
}
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
