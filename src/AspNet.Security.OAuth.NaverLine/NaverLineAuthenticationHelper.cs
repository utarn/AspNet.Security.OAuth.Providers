/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using JetBrains.Annotations;
using Newtonsoft.Json.Linq;

namespace AspNet.Security.OAuth.NaverLine
{
    /// <summary>
    /// Contains static methods that allow to extract user's information from a <see cref="JObject"/>
    /// instance retrieved from NaverLine after a successful authentication process.
    /// </summary>
    public class NaverLineAuthenticationHelper
    {
       /// <summary>
        /// Gets the identifier corresponding to the authenticated user.
        /// </summary>
        public static string GetUserId([NotNull] JObject user) => user.Value<string>("userId");

        /// <summary>
        /// Gets the full name corresponding to the authenticated user.
        /// </summary>
        public static string GetDisplayName([NotNull] JObject user) => user.Value<string>("displayName");

        /// <summary>
        /// Gets the full name corresponding to the authenticated user.
        /// </summary>
        public static string GetPictureUrl([NotNull] JObject user) => user.Value<string>("pictureUrl");

        /// <summary>
        /// Gets the full name corresponding to the authenticated user.
        /// </summary>
        public static string GetStatusMessage([NotNull] JObject user) => user.Value<string>("statusMessage");
    }
}