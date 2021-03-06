// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ScaGuerrero.Client.Shared
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
    public partial class ListadoCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 133 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Shared\ListadoCard.razor"
       

    public string valor { get; set; }
    [Parameter] public string titulo { get; set; } = "";
    public int RegPag { get; set; } = 16;
    public string ValorEliminar { get; set; } = "";
    public bool conHover { get; set; } = true;
    [Parameter] public string[] encabezados { get; set; }
    [Parameter] public string[] campos { get; set; }
    [Parameter] public object[] lista { get; set; }
    [Parameter] public string tipo { get; set; } = "none";    
    [Parameter] public bool Editar { get; set; } = false;
    [Parameter] public bool Agregar { get; set; } = false;
    [Parameter] public bool Eliminar { get; set; } = false;
    [Parameter] public string rutaAgregar { get; set; } = "";
    [Parameter] public string rutaEditar { get; set; } = "";

    [Parameter]
    public EventCallback<string> eventBusqueda { get; set; }
    [Parameter]
    public EventCallback<string> eventEditar { get; set; }
    [Parameter]
    public EventCallback<string> eventEliminar { get; set; }
    [Parameter]
    public bool boton { get; set; } = true;

    public List<object> listaRetornar { get; set; }
    public int indiceVal { get; set; } = 1;

    public void CambiarRegistrosPagina(ChangeEventArgs e)
    {
        int vC = int.Parse(e.Value.ToString());
        RegPag = vC;
    }

    public int numeroPaginas()
    {
        int numeroBotones;
        int numeroRegistro = lista.Length;
        if (numeroRegistro % RegPag == 0)
        {
            numeroBotones = (numeroRegistro / RegPag);
        }
        else
        {
            numeroBotones = (numeroRegistro / RegPag) + 1;
        }
        return numeroBotones;


    }
    public void Paginar(int indicePag)
    {

        indiceVal = indicePag;
    }

    public void PaginarAnterior()
    {
        indiceVal = indiceVal - 1;
        if (indiceVal < 1) indiceVal = 1;
    }
    public void PaginarSiguiente()
    {
        int nPag = numeroPaginas();
        indiceVal = indiceVal + 1;

        if (indiceVal > nPag) indiceVal = nPag;
    }

    public void EditarReg(string data)
    {
        eventEditar.InvokeAsync(data);
    }

    public void EliminarReg(string data)
    {
        conHover= false;
        ValorEliminar = data;

    }

    public void EliminarDatos(string data)
    {
        conHover = true;
        eventEliminar.InvokeAsync(data);
    }

    public void activaHover()
    {
        conHover = true;
    }


    public void Busqueda()
    {
        valor = valor.ToUpper();
        eventBusqueda.InvokeAsync(valor);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
