using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

public static class EndpointExtensions
{
    public static IEndpointConventionBuilder MapSignOutEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapPost("/account/logout", async (SignInManager<IdentityUser> signInManager, ClaimsPrincipal user) =>
        {
            if (signInManager.IsSignedIn(user))
            {
                await signInManager.SignOutAsync();
            }
            return Results.Redirect("/");
        }).DisableAntiforgery();
    }
}