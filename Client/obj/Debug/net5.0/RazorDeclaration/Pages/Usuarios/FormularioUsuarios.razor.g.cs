// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ScaGuerrero.Client.Pages.Usuarios
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
#line 12 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Pages\Usuarios\FormularioUsuarios.razor"
using ScaGuerrero.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Pages\Usuarios\FormularioUsuarios.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Pages\Usuarios\FormularioUsuarios.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Pages\Usuarios\FormularioUsuarios.razor"
using System.Drawing.Imaging;

#line default
#line hidden
#nullable disable
    public partial class FormularioUsuarios : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 136 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Pages\Usuarios\FormularioUsuarios.razor"
       
    [Parameter]
    public string Titulo { get; set; }
    [Parameter]
    public bool InputPassword { get; set; } = false;
    [Parameter]
    public bool MostrarVerpassword { get; set; } = false;
    [Parameter]
    public UsuariosVM oUsuariosVM { get; set; } = new();
    public ImagenesVM oImagenesVM { get; set; } = new();
    public long maxFileSize = 640 * 480 * 15;
    [Parameter]
    public string imageDataUri { get; set; }
    public int IdImagen { get; set; }
    public string tipoMostrar { get; set; } = "password";
    public bool MostrarPassword { get; set; } = false;

    public async Task GuardarDatos()
    {
        bool res = await http.PostJsonAsync<bool>("api/Usuarios/Guardar", oUsuariosVM);
        if (res)
        {

            navigationManager.NavigateTo("/ListadoUsuarios");
        }
    }

    public void CambiaMostrar()
    {

        MostrarPassword = !MostrarPassword;
        tipoMostrar = MostrarPassword == true ? "text" : "password";
    }

    public async Task VerImagen(InputFileChangeEventArgs e)
    {
        var imageFile = await e.File.RequestImageFileAsync("image/*", 640, 480);

        using Stream fileStream = imageFile.OpenReadStream(maxFileSize);
        using MemoryStream ms = new();
        await fileStream.CopyToAsync(ms);

        imageDataUri = $"data:image/*;base64,{Convert.ToBase64String(ms.ToArray())}";
        oImagenesVM.Id = oUsuariosVM.IdImagen;
        oImagenesVM.BlobImagen = ms.ToArray();
        oUsuariosVM.IdImagen = await http.PostJsonAsync<int>("/api/Imagenes/Guardar", oImagenesVM);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
