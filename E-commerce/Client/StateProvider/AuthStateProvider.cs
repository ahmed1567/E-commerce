﻿using Microsoft.AspNetCore.Components.Authorization;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlazorProducts.Client;

public class AuthStateProvider : AuthenticationStateProvider
{
    public async override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
			await Task.Delay(1500);
			var claims = new List<Claim>
			{
				new Claim(ClaimTypes.Name, "John Doe"),
				new Claim(ClaimTypes.Role, "Admin")
			};
			var anonymous = new ClaimsIdentity();
        return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonymous)));
    }
}
