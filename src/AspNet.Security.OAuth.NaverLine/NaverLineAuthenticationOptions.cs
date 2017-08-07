/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace AspNet.Security.OAuth.NaverLine
{
    /// <summary>
    /// Defines a set of options used by <see cref="NaverLineAuthenticationHandler"/>.
    /// </summary>
    public class NaverLineAuthenticationOptions : OAuthOptions
    {
        public NaverLineAuthenticationOptions()
        {
            AuthenticationScheme = NaverLineAuthenticationDefaults.AuthenticationScheme;
            DisplayName = NaverLineAuthenticationDefaults.DisplayName;
            ClaimsIssuer = NaverLineAuthenticationDefaults.Issuer;

            CallbackPath = new PathString(NaverLineAuthenticationDefaults.CallbackPath);

            AuthorizationEndpoint = NaverLineAuthenticationDefaults.AuthorizationEndpoint;
            TokenEndpoint = NaverLineAuthenticationDefaults.TokenEndpoint;
            UserInformationEndpoint = NaverLineAuthenticationDefaults.UserInformationEndpoint;
        }

        /// <summary>
        /// Gets the list of fields to retrieve from the user information endpoint.
        /// See https://developers.line.me/web-api/getting-user-profiles for more information.
        /// </summary>
        public ISet<string> Fields { get; } = new HashSet<string>
        {
            "userId",
            "displayName",
            "pictureUrl",
            "statusMessage"
        };
    }
}