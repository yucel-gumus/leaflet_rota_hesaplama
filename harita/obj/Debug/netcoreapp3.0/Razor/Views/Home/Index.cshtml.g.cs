#pragma checksum "C:\Users\yucel.gumus\Desktop\react\harita\harita\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "933a273db5c7b20d3dd07c011839cde20082b8252d647c7e76446b370cc322b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\yucel.gumus\Desktop\react\harita\harita\Views\_ViewImports.cshtml"
using harita;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yucel.gumus\Desktop\react\harita\harita\Views\_ViewImports.cshtml"
using harita.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"933a273db5c7b20d3dd07c011839cde20082b8252d647c7e76446b370cc322b7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"18308477e2f2b0127aad3e1ad155a34246db85405e142ba77edddc2f3f54d228", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
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
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "933a273db5c7b20d3dd07c011839cde20082b8252d647c7e76446b370cc322b73389", async() => {
                WriteLiteral(@"
    <title>En Kısa Yolu Bulma</title>
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""https://unpkg.com/leaflet@1.7.1/dist/leaflet.css"" />
    <link rel=""stylesheet"" href=""https://unpkg.com/leaflet-routing-machine@3.2.12/dist/leaflet-routing-machine.css"" />
    <script src=""https://unpkg.com/leaflet@1.7.1/dist/leaflet.js""></script>
    <script src=""https://unpkg.com/leaflet-routing-machine@3.2.12/dist/leaflet-routing-machine.js""></script>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "933a273db5c7b20d3dd07c011839cde20082b8252d647c7e76446b370cc322b74935", async() => {
                WriteLiteral(@"

    <div>
        <label for=""start"">Başlangıç Noktası:</label>
        <input type=""text"" id=""start"" />
    </div>
    <div>
        <label for=""end"">Hedef Noktası:</label>
        <input type=""text"" id=""end"" />
    </div>
    <div>
        <button onclick=""getCoordinates()"">Rota Hesapla</button>
    </div>

    <div id=""map"" style=""height: 500px;""></div>

    <script>
        var map = L.map('map').setView([41.090484, 28.9508949], 13);

        L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
            maxZoom: 19,
        }).addTo(map);

        function getCoordinates() {
            var locationInput = document.getElementById(""start"");
            var locationInput2 = document.getElementById(""end"");

            var address = locationInput.value;
            var address2 = locationInput2.value;

            if (address && address2) {
                var url = `https://nominatim.openstreetmap.org/search?q=${encodeURIComponent(address)}&format=json`;
 ");
                WriteLiteral(@"               var url2 = `https://nominatim.openstreetmap.org/search?q=${encodeURIComponent(address2)}&format=json`;

                fetch(url)
                    .then(response => response.json())
                    .then(data => {
                        if (data.length > 0) {
                            var lat = data[0].lat;
                            var lon = data[0].lon;
                            fetchCoordinates(lat, lon, url2);
                        } else {
                            alert(""Başlangıç konumu bulunamadı."");
                        }
                    })
                    .catch(error => {
                        console.error(""Hata:"", error);
                        alert(""Bir hata oluştu."");
                    });
            } else {
                alert(""Başlangıç ve hedef noktalarını girin."");
            }
        }

        function fetchCoordinates(startLat, startLon, url) {
            fetch(url)
                .then(response => respons");
                WriteLiteral(@"e.json())
                .then(data => {
                    if (data.length > 0) {
                        var endLat = data[0].lat;
                        var endLon = data[0].lon;
                        displayRoute(startLat, startLon, endLat, endLon);
                    } else {
                        alert(""Hedef konum bulunamadı."");
                    }
                })
                .catch(error => {
                    console.error(""Hata:"", error);
                    alert(""Bir hata oluştu."");
                });
        }

        function displayRoute(startLat, startLon, endLat, endLon) {
            var control = L.Routing.control({
                waypoints: [
                    L.latLng(startLat, startLon),
                    L.latLng(endLat, endLon)
                ],
                routeWhileDragging: true
            }).addTo(map);
        }
    </script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
