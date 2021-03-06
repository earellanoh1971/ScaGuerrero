#pragma checksum "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Pages\Ventas\ListadoVentas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ef1c4bc33563acdfef5a4baa48fea4ea19f04e8"
// <auto-generated/>
#pragma warning disable 1591
namespace ScaGuerrero.Client.Pages.Ventas
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
#line 2 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Pages\Ventas\ListadoVentas.razor"
using ScaGuerrero.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listadoVentas")]
    public partial class ListadoVentas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Pages\Ventas\ListadoVentas.razor"
  
    string[] encabezadoTabla = { "Folio","Fecha", "Estado","Cliente", "Total" };
    string[] camposMostrar = { "Folio", "Fecha", "Status","Cliente", "Total" };
    string[] estilos = { "text-left", "text-left", "text-left", "text-left", "text-right text-bold" };

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<ScaGuerrero.Client.Shared.Listado>(2);
                __builder2.AddAttribute(3, "titulo", "Venta");
                __builder2.AddAttribute(4, "encabezados", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 16 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Pages\Ventas\ListadoVentas.razor"
                             encabezadoTabla

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "campos", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 17 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Pages\Ventas\ListadoVentas.razor"
                        camposMostrar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "clases", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 18 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Pages\Ventas\ListadoVentas.razor"
                        estilos

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "lista", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object[]>(
#nullable restore
#line 19 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Pages\Ventas\ListadoVentas.razor"
                       listaVentas

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "tipo", "text");
                __builder2.AddAttribute(9, "eventEliminar", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 20 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Pages\Ventas\ListadoVentas.razor"
                                EliminarVenta

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(10, "eventBusqueda", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 21 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Pages\Ventas\ListadoVentas.razor"
                                BusquedaVenta

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "boton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Pages\Ventas\ListadoVentas.razor"
                       false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Editar", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Pages\Ventas\ListadoVentas.razor"
                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Eliminar", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Pages\Ventas\ListadoVentas.razor"
                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "Agregar", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Pages\Ventas\ListadoVentas.razor"
                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "rutaEditar", "editarVenta");
                __builder2.AddAttribute(16, "rutaAgregar", "agregarVenta");
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(17, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 30 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Pages\Ventas\ListadoVentas.razor"
          
            Navigate.NavigateTo("/");
        

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Pages\Ventas\ListadoVentas.razor"
       
    private VentasVM[] listaVentas;
    protected override async Task OnInitializedAsync()
    {
        listaVentas = await http.GetFromJsonAsync<VentasVM[]>("api/Ventas/Get");
    }

    public async Task BusquedaVenta(string data)
    {
        listaVentas = await http.GetFromJsonAsync<VentasVM[]>("api/Ventas/Filtrar/" + data);
    }

    public async Task EliminarVenta(string data)
    {
        int resultado = await http.GetFromJsonAsync<int>("api/Ventas/Eliminar/" + data);
        if (resultado == 1)
        {
            listaVentas = await http.GetFromJsonAsync<VentasVM[]>("api/Ventas/Get");
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
