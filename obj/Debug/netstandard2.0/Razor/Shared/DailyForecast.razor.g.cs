#pragma checksum "/home/jonoe/ForecastApp/Shared/DailyForecast.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba233332f4a18e4fdd4f87f9917de1c95ecf1b0d"
// <auto-generated/>
#pragma warning disable 1591
namespace ForecastApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/home/jonoe/ForecastApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "/home/jonoe/ForecastApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "/home/jonoe/ForecastApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "/home/jonoe/ForecastApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "/home/jonoe/ForecastApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "/home/jonoe/ForecastApp/_Imports.razor"
using ForecastApp;

#line default
#line hidden
#line 7 "/home/jonoe/ForecastApp/_Imports.razor"
using ForecastApp.Shared;

#line default
#line hidden
    public partial class DailyForecast : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card text-center");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-header");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddContent(6, 
#line 3 "/home/jonoe/ForecastApp/Shared/DailyForecast.razor"
         Date

#line default
#line hidden
            );
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "src", 
#line 6 "/home/jonoe/ForecastApp/Shared/DailyForecast.razor"
                   IconUrl

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "h4");
            __builder.AddAttribute(16, "class", "card-title");
            __builder.AddContent(17, 
#line 7 "/home/jonoe/ForecastApp/Shared/DailyForecast.razor"
                                Description

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "b");
            __builder.AddContent(20, 
#line 8 "/home/jonoe/ForecastApp/Shared/DailyForecast.razor"
             (int)HighTemp

#line default
#line hidden
            );
            __builder.AddContent(21, " F°");
            __builder.CloseElement();
            __builder.AddContent(22, " / ");
            __builder.AddContent(23, 
#line 8 "/home/jonoe/ForecastApp/Shared/DailyForecast.razor"
                                           (int)LowTemp

#line default
#line hidden
            );
            __builder.AddMarkupContent(24, " F&deg;\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 13 "/home/jonoe/ForecastApp/Shared/DailyForecast.razor"
 
    [Parameter]
    public long Seconds { get; set; }

    [Parameter]
    public double HighTemp { get; set; }

    [Parameter]
    public double LowTemp { get; set; }

    [Parameter]
    public string Description { get; set; }

    [Parameter]
    public string Icon { get; set; }

    private string Date;
    private string IconUrl;

    protected override void OnInitialized()
    {
        Date = DateTimeOffset
            .FromUnixTimeSeconds(Seconds)
            .LocalDateTime
            .ToLongDateString();
        IconUrl = $"https://openweathermap.org/img/wn/{Icon}@2x.png";
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
