// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Apimanagement
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// OperationOperations operations.
    /// </summary>
    public partial interface IOperationOperations
    {
        /// <summary>
        /// Lists a collection of operations associated with tags.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='apiId'>
        /// API revision identifier. Must be unique in the current API
        /// Management service instance. Non-current revision has ;rev=n as a
        /// suffix where n is the revision number.
        /// </param>
        /// <param name='filter'>
        /// |   Field     |     Usage     |     Supported operators     |
        /// Supported functions
        /// |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;|
        /// name | filter | ge, le, eq, ne, gt, lt | substringof, contains,
        /// startswith, endswith | &lt;/br&gt;| displayName | filter | ge, le,
        /// eq, ne, gt, lt | substringof, contains, startswith, endswith |
        /// &lt;/br&gt;| apiName | filter | ge, le, eq, ne, gt, lt |
        /// substringof, contains, startswith, endswith | &lt;/br&gt;|
        /// description | filter | ge, le, eq, ne, gt, lt | substringof,
        /// contains, startswith, endswith | &lt;/br&gt;| method | filter | ge,
        /// le, eq, ne, gt, lt | substringof, contains, startswith, endswith |
        /// &lt;/br&gt;| urlTemplate | filter | ge, le, eq, ne, gt, lt |
        /// substringof, contains, startswith, endswith | &lt;/br&gt;
        /// </param>
        /// <param name='top'>
        /// Number of records to return.
        /// </param>
        /// <param name='skip'>
        /// Number of records to skip.
        /// </param>
        /// <param name='includeNotTaggedOperations'>
        /// Include not tagged Operations.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<TagResourceCollection>> ListByTagsWithHttpMessagesAsync(string resourceGroupName, string serviceName, string apiId, string filter = default(string), int? top = default(int?), int? skip = default(int?), bool? includeNotTaggedOperations = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
