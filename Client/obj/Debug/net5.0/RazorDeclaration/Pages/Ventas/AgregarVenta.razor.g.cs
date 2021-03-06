// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Pages\Ventas\AgregarVenta.razor"
using ScaGuerrero.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/agregarVenta")]
    public partial class AgregarVenta : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 471 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Pages\Ventas\AgregarVenta.razor"
          
    private string cDomicilio1 { get; set; } = "";
    private string cDomicilio2 { get; set; } = "";
    private string cRfcCliente { get; set; } = "";
    private string cNombreCliente { get; set; } = "";
    private string cNombreCiclo { get; set; } = "";
    private string cNombreArticulo { get; set; } = "";
    private string cCodigo { get; set; } = "";
    private string cCantidad { get; set; } = "1";
    private string cPrecio { get; set; } = "0.00";

    private ClientesVM[] listaClientes;
    private ClientesVM cliente { get; set; }
    private CiclosVM[] listaCiclos;
    private CiclosVM ciclo { get; set; }
    private ArticulosVM[] listaArticulos;
    private ArticulosVM articulo { get; set; }

    protected override async Task OnInitializedAsync()
    {
        listaClientes = await http.GetFromJsonAsync<ClientesVM[]>("api/Ventas/ListarClientes");
        listaCiclos = await http.GetFromJsonAsync<CiclosVM[]>("api/Ventas/ListarCiclos");
        listaArticulos = await http.GetFromJsonAsync<ArticulosVM[]>("api/Ventas/ListarArticulos");
    }

    public async Task BusquedaCliente(string data)
    {
        listaClientes = await http.GetFromJsonAsync<ClientesVM[]>("api/Clientes/Filtrar/" + data);
    }
    public async Task SeleccionaCliente(string data)
    {
        cliente = await http.GetFromJsonAsync<ClientesVM>("api/Clientes/Buscar/" + data);
        cNombreCliente = cliente.Nombre;
        cRfcCliente = cliente.Rfc;
        if (cliente.Calle != "") cDomicilio1 = cliente.Calle.Trim();
        if (cliente.Numero != "") cDomicilio1 += "# " + cliente.Numero.Trim();
        if (cDomicilio1.Trim() != "") cDomicilio1 += ",";
        if (cliente.Colonia.Trim() != "") cDomicilio1 += "Col. " + cliente.Colonia.Trim();

        if (cliente.Localidad.Trim() != "") cDomicilio2 = cliente.Localidad.Trim();
        if (cDomicilio2.Trim() != "") cDomicilio2 = ",";
        if (cliente.Ciudad.Trim() != "") cDomicilio2 += cliente.Ciudad.Trim();
        if (cDomicilio2.Trim() != "") cDomicilio2 += ",";
        if (cliente.Estado.Trim() != "") cDomicilio2 += cliente.Estado.Trim();
    }
    public async Task SeleccionaCiclo(string data)
    {
        ciclo = await http.GetFromJsonAsync<CiclosVM>("api/Ciclos/Buscar/" + data);
        cNombreCiclo = ciclo.Nombre;
    }
    public async Task BusquedaCiclo(string data)
    {
        listaCiclos = await http.GetFromJsonAsync<CiclosVM[]>("api/Ciclos/Filtrar/" + data);
    }

    public async Task SeleccionaArticulo(string data)
    {
        articulo = await http.GetFromJsonAsync<ArticulosVM>("api/Articulos/Buscar/" + data);
        cNombreArticulo = articulo.Descripcion;
        cCodigo = articulo.Codigo;
        cPrecio = articulo.CPrecioPublico;
    }

    public async Task BusquedaArticulo(string data)
    {
        listaArticulos = await http.GetFromJsonAsync<ArticulosVM[]>("api/Articulos/Filtrar/" + data);
    }

    public async Task BusquedaCodigo(KeyboardEventArgs e)
    {
        if (e.Key == "Enter") {
            articulo = await http.GetFromJsonAsync<ArticulosVM>("api/Articulos/BuscarCodigo/" + cCodigo);
            if (articulo != null)
            {
                cNombreArticulo = articulo.Descripcion;
                cPrecio = articulo.CPrecioPublico;
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
