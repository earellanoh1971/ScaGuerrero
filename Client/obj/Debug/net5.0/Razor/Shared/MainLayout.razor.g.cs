#pragma checksum "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f358e09721f82e5c0789e98bb1dbba2228da6f94"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 3 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Shared\MainLayout.razor"
using ScaGuerrero.Client.Service;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-0wbnr6twct");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "main");
            __builder.AddAttribute(5, "b-0wbnr6twct");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "b-0wbnr6twct");
            __builder.OpenElement(8, "nav");
            __builder.AddAttribute(9, "class", "navbar navbar-expand-lg navbar-dark bg-dark fixed-bottom-top");
            __builder.AddAttribute(10, "b-0wbnr6twct");
            __builder.AddMarkupContent(11, "<a class=\"navbar-brand text-white\" b-0wbnr6twct>Guerrero Azteca</a>\r\n                ");
            __builder.AddMarkupContent(12, @"<button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarColor01"" aria-controls=""navbarColor01"" aria-expanded=""false"" aria-label=""Toggle navigation"" b-0wbnr6twct><span class=""navbar-toggler-icon"" b-0wbnr6twct></span></button>
                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "collapse navbar-collapse");
            __builder.AddAttribute(15, "id", "navbarColor01");
            __builder.AddAttribute(16, "b-0wbnr6twct");
            __builder.OpenElement(17, "ul");
            __builder.AddAttribute(18, "class", "navbar-nav mr-auto");
            __builder.AddAttribute(19, "b-0wbnr6twct");
            __builder.OpenElement(20, "li");
            __builder.AddAttribute(21, "class", "nav-item px-3");
            __builder.AddAttribute(22, "b-0wbnr6twct");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(23);
            __builder.AddAttribute(24, "class", "btn btn-outline-light btn-sm nav-link");
            __builder.AddAttribute(25, "href", "");
            __builder.AddAttribute(26, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 19 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Shared\MainLayout.razor"
                                                                                                  NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(28, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-0wbnr6twct></span> Inicio\r\n                            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(30);
            __builder.AddAttribute(31, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(32, "li");
                __builder2.AddAttribute(33, "class", "nav-item px-3");
                __builder2.AddAttribute(34, "b-0wbnr6twct");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(35);
                __builder2.AddAttribute(36, "class", "btn btn-outline-warning btn-sm nav-link");
                __builder2.AddAttribute(37, "href", "menu");
                __builder2.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(39, "<span class=\"oi oi-monitor\" aria-hidden=\"true\" b-0wbnr6twct></span> Sistema de Control Administrativo\r\n                                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "ul");
            __builder.AddAttribute(42, "class", "d-flex navbar-nav");
            __builder.AddAttribute(43, "b-0wbnr6twct");
            __builder.OpenElement(44, "li");
            __builder.AddAttribute(45, "class", "nav-item p-2 text-white");
            __builder.AddAttribute(46, "b-0wbnr6twct");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(47);
            __builder.AddAttribute(48, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(49, "a");
                __builder2.AddAttribute(50, "class", "btn btn-outline-danger btn-sm nav-link");
                __builder2.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Shared\MainLayout.razor"
                                                                                                logout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "b-0wbnr6twct");
                __builder2.AddMarkupContent(53, "Cerrar Sesión");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(54, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(55, "<a class=\"btn btn-outline-success btn-sm nav-link\" href=\"login\" b-0wbnr6twct>Iniciar Sesión</a>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n        ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "content px-4");
            __builder.AddAttribute(59, "b-0wbnr6twct");
            __builder.AddContent(60, 
#nullable restore
#line 54 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\Enrique Arellano\source\repos\ScaGuerrero\Client\Shared\MainLayout.razor"
      
    public void logout()
    {
        ((Autenticacion)auth).Logout();
        navigate.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider auth { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigate { get; set; }
    }
}
#pragma warning restore 1591