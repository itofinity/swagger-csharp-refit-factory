/* 
 * Swagger Petstore
 *
 * This is a sample server Petstore server.  You can find out more about Swagger at [http://swagger.io](http://swagger.io) or on [irc.freenode.net, #swagger](http://swagger.io/irc/).  For this sample, you can use the api key `special-key` to test the authorization filters.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Refit;
using IO.Swagger.Api;

namespace IO.Swagger.Client
{
    /// <summary>
    /// API client is mainly responsible for making the HTTP call to the API backend.
    /// </summary>
    public partial class ApiClient
    {
        public ApiClient(HttpClient client)
        {
            PetApiClient = RestService.For<IPetApi>(client);

            StoreApiClient = RestService.For<IStoreApi>(client);

            UserApiClient = RestService.For<IUserApi>(client);

        }

        /// <param name="getSchemeAndToken"></param>
        public ApiClient(string url, Func<Task<Tuple<string, string>>> getSchemeAndToken) : this(new HttpClient(new AuthenticatedHttpClientHandler(getSchemeAndToken))
            {
            BaseAddress = new Uri(url)
            })
        {
        }

        /// <inheritdoc />
        public IPetApi PetApiClient { get; }

        /// <inheritdoc />
        public IStoreApi StoreApiClient { get; }

        /// <inheritdoc />
        public IUserApi UserApiClient { get; }


        public string Scheme { get; }

        public string Token { get; }

        private async Task<Tuple<string, string>> GetSchemeAndToken()
        {
            return new Tuple<string, string>(Scheme, Token);
        }
    }

    public class AuthenticatedHttpClientHandler : HttpClientHandler
    {
        private readonly Func<Task<Tuple<string, string>>> getSchemeAndToken;

        public AuthenticatedHttpClientHandler(Func<Task<Tuple<string, string>>> getSchemeAndToken)
        {
            this.getSchemeAndToken = getSchemeAndToken;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            // See if the request has an authorize header
            var auth = request.Headers.Authorization;
            var schemeAndToken = await getSchemeAndToken().ConfigureAwait(false);

            if (schemeAndToken != null)
            {
            request.Headers.Authorization = new AuthenticationHeaderValue(schemeAndToken.Item1, schemeAndToken.Item2);
            }


            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}