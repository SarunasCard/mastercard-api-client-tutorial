/* 
 * MDES for Merchants
 *
 * The MDES APIs are designed as RPC style stateless web services where each API endpoint represents an operation to be performed.  All request and response payloads are sent in the JSON (JavaScript Object Notation) data-interchange format. Each endpoint in the API specifies the HTTP Method used to access it. All strings in request and response objects are to be UTF-8 encoded.  Each API URI includes the major and minor version of API that it conforms to.  This will allow multiple concurrent versions of the API to be deployed simultaneously. <br> __Authentication__ Mastercard uses OAuth 1.0a with body hash extension for authenticating the API clients. This requires every request that you send to  Mastercard to be signed with an RSA private key. A private-public RSA key pair must be generated consisting of: <br> 1 . A private key for the OAuth signature for API requests. It is recommended to keep the private key in a password-protected or hardware keystore. <br> 2. A public key is shared with Mastercard during the project setup process through either a certificate signing request (CSR) or the API Key Generator. Mastercard will use the public key to verify the OAuth signature that is provided on every API call.<br>  An OAUTH1.0a signer library is available on [GitHub](https://github.com/Mastercard/oauth1-signer-java) <br>  __Encryption__<br>  All communications between Issuer web service and the Mastercard gateway is encrypted using TLS. <br> __Additional Encryption of Sensitive Data__ In addition to the OAuth authentication, when using MDES Digital Enablement Service, any PCI sensitive and all account holder Personally Identifiable Information (PII) data must be encrypted. This requirement applies to the API fields containing encryptedData. Sensitive data is encrypted using a symmetric session (one-time-use) key. The symmetric session key is then wrapped with an RSA Public Key supplied by Mastercard during API setup phase (the Customer Encryption Key). <br>  Java Client Encryption Library available on [GitHub](https://github.com/Mastercard/client-encryption-java) 
 *
 * The version of the OpenAPI document: 1.2.10
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using Acme.App.MastercardApi.Client.Client;
using Acme.App.MastercardApi.Client.Model;

namespace Acme.App.MastercardApi.Client.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUnsuspendApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Used to unsuspend one or more previously suspended Tokens. The API is limited to 10 Tokens per request.
        /// </summary>
        /// <remarks>
        /// This API is used to unsuspend one or more previously suspended Tokens. The API is limited to 10 Tokens per request. MDES will coordinate the unsuspension of the Tokens and notify any relevant parties that the Tokens have now been unsuspended. 
        /// </remarks>
        /// <exception cref="Acme.App.MastercardApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="unsuspendRequestSchema">Contains the details of the request message.  (optional)</param>
        /// <returns>UnSuspendResponseSchema</returns>
        UnSuspendResponseSchema CreateUnsuspend (UnSuspendRequestSchema unsuspendRequestSchema = default(UnSuspendRequestSchema));

        /// <summary>
        /// Used to unsuspend one or more previously suspended Tokens. The API is limited to 10 Tokens per request.
        /// </summary>
        /// <remarks>
        /// This API is used to unsuspend one or more previously suspended Tokens. The API is limited to 10 Tokens per request. MDES will coordinate the unsuspension of the Tokens and notify any relevant parties that the Tokens have now been unsuspended. 
        /// </remarks>
        /// <exception cref="Acme.App.MastercardApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="unsuspendRequestSchema">Contains the details of the request message.  (optional)</param>
        /// <returns>ApiResponse of UnSuspendResponseSchema</returns>
        ApiResponse<UnSuspendResponseSchema> CreateUnsuspendWithHttpInfo (UnSuspendRequestSchema unsuspendRequestSchema = default(UnSuspendRequestSchema));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Used to unsuspend one or more previously suspended Tokens. The API is limited to 10 Tokens per request.
        /// </summary>
        /// <remarks>
        /// This API is used to unsuspend one or more previously suspended Tokens. The API is limited to 10 Tokens per request. MDES will coordinate the unsuspension of the Tokens and notify any relevant parties that the Tokens have now been unsuspended. 
        /// </remarks>
        /// <exception cref="Acme.App.MastercardApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="unsuspendRequestSchema">Contains the details of the request message.  (optional)</param>
        /// <returns>Task of UnSuspendResponseSchema</returns>
        System.Threading.Tasks.Task<UnSuspendResponseSchema> CreateUnsuspendAsync (UnSuspendRequestSchema unsuspendRequestSchema = default(UnSuspendRequestSchema));

        /// <summary>
        /// Used to unsuspend one or more previously suspended Tokens. The API is limited to 10 Tokens per request.
        /// </summary>
        /// <remarks>
        /// This API is used to unsuspend one or more previously suspended Tokens. The API is limited to 10 Tokens per request. MDES will coordinate the unsuspension of the Tokens and notify any relevant parties that the Tokens have now been unsuspended. 
        /// </remarks>
        /// <exception cref="Acme.App.MastercardApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="unsuspendRequestSchema">Contains the details of the request message.  (optional)</param>
        /// <returns>Task of ApiResponse (UnSuspendResponseSchema)</returns>
        System.Threading.Tasks.Task<ApiResponse<UnSuspendResponseSchema>> CreateUnsuspendAsyncWithHttpInfo (UnSuspendRequestSchema unsuspendRequestSchema = default(UnSuspendRequestSchema));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UnsuspendApi : IUnsuspendApi
    {
        private Acme.App.MastercardApi.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnsuspendApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UnsuspendApi(String basePath)
        {
            this.Configuration = new Acme.App.MastercardApi.Client.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Acme.App.MastercardApi.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnsuspendApi"/> class
        /// </summary>
        /// <returns></returns>
        public UnsuspendApi()
        {
            this.Configuration = Acme.App.MastercardApi.Client.Client.Configuration.Default;

            ExceptionFactory = Acme.App.MastercardApi.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnsuspendApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UnsuspendApi(Acme.App.MastercardApi.Client.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Acme.App.MastercardApi.Client.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Acme.App.MastercardApi.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Acme.App.MastercardApi.Client.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Acme.App.MastercardApi.Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Used to unsuspend one or more previously suspended Tokens. The API is limited to 10 Tokens per request. This API is used to unsuspend one or more previously suspended Tokens. The API is limited to 10 Tokens per request. MDES will coordinate the unsuspension of the Tokens and notify any relevant parties that the Tokens have now been unsuspended. 
        /// </summary>
        /// <exception cref="Acme.App.MastercardApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="unsuspendRequestSchema">Contains the details of the request message.  (optional)</param>
        /// <returns>UnSuspendResponseSchema</returns>
        public UnSuspendResponseSchema CreateUnsuspend (UnSuspendRequestSchema unsuspendRequestSchema = default(UnSuspendRequestSchema))
        {
             ApiResponse<UnSuspendResponseSchema> localVarResponse = CreateUnsuspendWithHttpInfo(unsuspendRequestSchema);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Used to unsuspend one or more previously suspended Tokens. The API is limited to 10 Tokens per request. This API is used to unsuspend one or more previously suspended Tokens. The API is limited to 10 Tokens per request. MDES will coordinate the unsuspension of the Tokens and notify any relevant parties that the Tokens have now been unsuspended. 
        /// </summary>
        /// <exception cref="Acme.App.MastercardApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="unsuspendRequestSchema">Contains the details of the request message.  (optional)</param>
        /// <returns>ApiResponse of UnSuspendResponseSchema</returns>
        public ApiResponse<UnSuspendResponseSchema> CreateUnsuspendWithHttpInfo (UnSuspendRequestSchema unsuspendRequestSchema = default(UnSuspendRequestSchema))
        {

            var localVarPath = "./digitization/static/1/0/unsuspend";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (unsuspendRequestSchema != null && unsuspendRequestSchema.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(unsuspendRequestSchema); // http body (model) parameter
            }
            else
            {
                localVarPostBody = unsuspendRequestSchema; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateUnsuspend", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UnSuspendResponseSchema>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (UnSuspendResponseSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnSuspendResponseSchema)));
        }

        /// <summary>
        /// Used to unsuspend one or more previously suspended Tokens. The API is limited to 10 Tokens per request. This API is used to unsuspend one or more previously suspended Tokens. The API is limited to 10 Tokens per request. MDES will coordinate the unsuspension of the Tokens and notify any relevant parties that the Tokens have now been unsuspended. 
        /// </summary>
        /// <exception cref="Acme.App.MastercardApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="unsuspendRequestSchema">Contains the details of the request message.  (optional)</param>
        /// <returns>Task of UnSuspendResponseSchema</returns>
        public async System.Threading.Tasks.Task<UnSuspendResponseSchema> CreateUnsuspendAsync (UnSuspendRequestSchema unsuspendRequestSchema = default(UnSuspendRequestSchema))
        {
             ApiResponse<UnSuspendResponseSchema> localVarResponse = await CreateUnsuspendAsyncWithHttpInfo(unsuspendRequestSchema);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Used to unsuspend one or more previously suspended Tokens. The API is limited to 10 Tokens per request. This API is used to unsuspend one or more previously suspended Tokens. The API is limited to 10 Tokens per request. MDES will coordinate the unsuspension of the Tokens and notify any relevant parties that the Tokens have now been unsuspended. 
        /// </summary>
        /// <exception cref="Acme.App.MastercardApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="unsuspendRequestSchema">Contains the details of the request message.  (optional)</param>
        /// <returns>Task of ApiResponse (UnSuspendResponseSchema)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UnSuspendResponseSchema>> CreateUnsuspendAsyncWithHttpInfo (UnSuspendRequestSchema unsuspendRequestSchema = default(UnSuspendRequestSchema))
        {

            var localVarPath = "./digitization/static/1/0/unsuspend";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (unsuspendRequestSchema != null && unsuspendRequestSchema.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(unsuspendRequestSchema); // http body (model) parameter
            }
            else
            {
                localVarPostBody = unsuspendRequestSchema; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateUnsuspend", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UnSuspendResponseSchema>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (UnSuspendResponseSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnSuspendResponseSchema)));
        }

    }
}