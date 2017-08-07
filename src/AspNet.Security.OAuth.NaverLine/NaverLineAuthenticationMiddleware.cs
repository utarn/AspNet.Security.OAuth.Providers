/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using System;
using System.Text.Encodings.Web;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace AspNet.Security.OAuth.NaverLine
{
    public class NaverLineAuthenticationMiddleware : OAuthMiddleware<NaverLineAuthenticationOptions>
    {
        public NaverLineAuthenticationMiddleware(
            [NotNull] RequestDelegate next,
            [NotNull] IDataProtectionProvider dataProtectionProvider,
            [NotNull] ILoggerFactory loggerFactory,
            [NotNull] UrlEncoder encoder,
            [NotNull] IOptions<SharedAuthenticationOptions> sharedOptions,
            [NotNull] IOptions<NaverLineAuthenticationOptions> options)
            : base(next, dataProtectionProvider, loggerFactory, encoder, sharedOptions, options)
        {
            // if (Options.Fields.Count != 0 && !Options.UserInformationEndpoint.Contains("~"))
            // {
            //     throw new ArgumentException("The user information endpoint is improperly formatted. ", nameof(options));
            // }
        }

        protected override AuthenticationHandler<NaverLineAuthenticationOptions> CreateHandler()
        {
            return new NaverLineAuthenticationHandler(Backchannel);
        }
    }
}