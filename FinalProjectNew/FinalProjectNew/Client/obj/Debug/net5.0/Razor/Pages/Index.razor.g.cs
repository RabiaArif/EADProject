#pragma checksum "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff1122529ed5a19228b46a85d28a6f4580204641"
// <auto-generated/>
#pragma warning disable 1591
namespace FinalProjectNew.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\_Imports.razor"
using FinalProjectNew.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\_Imports.razor"
using FinalProjectNew.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\_Imports.razor"
using FinalProjectNew.Client.Controls;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", " SearchContainer");
            __builder.OpenComponent<FinalProjectNew.Client.Controls.SearchContainer>(2);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n<br>\r\n    \r\n    ");
            __builder.OpenComponent<FinalProjectNew.Client.Controls.FeaturedJobs>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n<br>\r\n    ");
            __builder.OpenComponent<FinalProjectNew.Client.Controls.PurchaseSection>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n    \r\n");
            __builder.AddMarkupContent(8, "<style>\r\n        .SearchContainer {\r\n            background-image: url(\"/bg-intro-1.jpg\");\r\n            background-size: 100% 100%;\r\n\r\n            padding:70px;\r\n        }\r\n</style>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
