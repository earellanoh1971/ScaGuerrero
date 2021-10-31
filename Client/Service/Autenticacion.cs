﻿using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ScaGuerrero.Client.Service
{
    public class Autenticacion : AuthenticationStateProvider
    {
        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            var user = new ClaimsPrincipal(identity);
            return Task.FromResult(new AuthenticationState(user));
        }

        public void Entrar(string IdUsuario)
        {
            var identity = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.Name,IdUsuario)
            }, "auth");

            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged( Task.FromResult(new AuthenticationState(user)));
        }

        public void Logout()
        {
            var identity = new ClaimsIdentity();
            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
    }
}
