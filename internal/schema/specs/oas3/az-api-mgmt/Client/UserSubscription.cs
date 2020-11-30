// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Apimanagement
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// UserSubscription operations.
    /// </summary>
    public partial class UserSubscription : IServiceOperations<APIGatewayManagement>, IUserSubscription
    {
        /// <summary>
        /// Initializes a new instance of the UserSubscription class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public UserSubscription(APIGatewayManagement client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException("client");
            }
            Client = client;
        }

        /// <summary>
        /// Gets a reference to the APIGatewayManagement
        /// </summary>
        public APIGatewayManagement Client { get; private set; }

        /// <summary>
        /// Lists the collection of subscriptions of the specified user.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='userId'>
        /// User identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        /// <param name='filter'>
        /// |   Field     |     Usage     |     Supported operators     |     Supported
        /// functions
        /// |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;|
        /// name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith,
        /// endswith | &lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt |
        /// substringof, contains, startswith, endswith | &lt;/br&gt;| stateComment |
        /// filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith,
        /// endswith | &lt;/br&gt;| ownerId | filter | ge, le, eq, ne, gt, lt |
        /// substringof, contains, startswith, endswith | &lt;/br&gt;| scope | filter |
        /// ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |
        /// &lt;/br&gt;| userId | filter | ge, le, eq, ne, gt, lt | substringof,
        /// contains, startswith, endswith | &lt;/br&gt;| productId | filter | ge, le,
        /// eq, ne, gt, lt | substringof, contains, startswith, endswith | &lt;/br&gt;
        /// </param>
        /// <param name='top'>
        /// Number of records to return.
        /// </param>
        /// <param name='skip'>
        /// Number of records to skip.
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<SubscriptionCollection>> ListWithHttpMessagesAsync(string resourceGroupName, string serviceName, string userId, string filter = default(string), int? top = default(int?), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (resourceGroupName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "resourceGroupName");
            }
            if (serviceName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "serviceName");
            }
            if (serviceName != null)
            {
                if (serviceName.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "serviceName", 50);
                }
                if (serviceName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "serviceName", 1);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(serviceName, "^[a-zA-Z](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "serviceName", "^[a-zA-Z](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?$");
                }
            }
            if (userId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "userId");
            }
            if (userId != null)
            {
                if (userId.Length > 80)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "userId", 80);
                }
                if (userId.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "userId", 1);
                }
            }
            if (top != null)
            {
                if (top < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "top", 1);
                }
            }
            if (skip != null)
            {
                if (skip < 0)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "skip", 0);
                }
            }
            if (Client.SubscriptionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "this.Client.SubscriptionId");
            }
            string apiVersion = "2019-12-01";
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("serviceName", serviceName);
                tracingParameters.Add("userId", userId);
                tracingParameters.Add("filter", filter);
                tracingParameters.Add("top", top);
                tracingParameters.Add("skip", skip);
                tracingParameters.Add("apiVersion", apiVersion);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "List", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/users/{userId}/subscriptions").ToString();
            _url = _url.Replace("{resourceGroupName}", System.Uri.EscapeDataString(resourceGroupName));
            _url = _url.Replace("{serviceName}", System.Uri.EscapeDataString(serviceName));
            _url = _url.Replace("{userId}", System.Uri.EscapeDataString(userId));
            _url = _url.Replace("{subscriptionId}", System.Uri.EscapeDataString(Client.SubscriptionId));
            List<string> _queryParameters = new List<string>();
            if (filter != null)
            {
                _queryParameters.Add(string.Format("$filter={0}", System.Uri.EscapeDataString(filter)));
            }
            if (top != null)
            {
                _queryParameters.Add(string.Format("$top={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(top, Client.SerializationSettings).Trim('"'))));
            }
            if (skip != null)
            {
                _queryParameters.Add(string.Format("$skip={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(skip, Client.SerializationSettings).Trim('"'))));
            }
            if (apiVersion != null)
            {
                _queryParameters.Add(string.Format("api-version={0}", System.Uri.EscapeDataString(apiVersion)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += "?" + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new ErrorResponseException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    ErrorResponse _errorBody =  Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<ErrorResponse>(_responseContent, Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<SubscriptionCollection>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<SubscriptionCollection>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}
