// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ScaGuerrero.Client.Pages.Diapositivas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\_Imports.razor"
using ScaGuerrero.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\_Imports.razor"
using ScaGuerrero.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Pages\Diapositivas\ListadoDiapositivas.razor"
using ScaGuerrero.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listadoDiapositivas")]
    public partial class ListadoDiapositivas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Pages\Diapositivas\ListadoDiapositivas.razor"
       
    public string message { get; set; }
    [CascadingParameter]
    private Task<AuthenticationState> auth { get; set; }
    private DiapositivasVM[] listaDiapositivas;
    protected override async Task OnInitializedAsync()
    {
        var authuser = await auth;
        var user = authuser.User;
        if (user.Identity.IsAuthenticated)
        {
            listaDiapositivas = await http.GetFromJsonAsync<DiapositivasVM[]>("api/Diapositivas/Get");
        }        
    }

    public async Task BusquedaDiapositivas(string data)
    {
        listaDiapositivas = await http.GetFromJsonAsync<DiapositivasVM[]>("api/Diapositivas/Filtrar/" + data);
    }

    public async Task EliminarDiapositiva(string data)
    {
        int resultado = await http.GetFromJsonAsync<int>("api/Diapositivas/Eliminar/" + data);
        if (resultado == 1)
        {
            listaDiapositivas = await http.GetFromJsonAsync<DiapositivasVM[]>("api/Diapositivas/Get");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigate { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
