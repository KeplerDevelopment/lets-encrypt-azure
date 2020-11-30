// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Apimanagement
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Diagnostic.
    /// </summary>
    public static partial class DiagnosticExtensions
    {
            /// <summary>
            /// Lists all diagnostics of the API Management service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='filter'>
            /// |   Field     |     Usage     |     Supported operators     |     Supported
            /// functions
            /// |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;|
            /// name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith,
            /// endswith | &lt;/br&gt;
            /// </param>
            /// <param name='top'>
            /// Number of records to return.
            /// </param>
            /// <param name='skip'>
            /// Number of records to skip.
            /// </param>
            public static DiagnosticCollection ListByService(this IDiagnostic operations, string resourceGroupName, string serviceName, string filter = default(string), int? top = default(int?), int? skip = default(int?))
            {
                return operations.ListByServiceAsync(resourceGroupName, serviceName, filter, top, skip).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all diagnostics of the API Management service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='filter'>
            /// |   Field     |     Usage     |     Supported operators     |     Supported
            /// functions
            /// |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;|
            /// name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith,
            /// endswith | &lt;/br&gt;
            /// </param>
            /// <param name='top'>
            /// Number of records to return.
            /// </param>
            /// <param name='skip'>
            /// Number of records to skip.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DiagnosticCollection> ListByServiceAsync(this IDiagnostic operations, string resourceGroupName, string serviceName, string filter = default(string), int? top = default(int?), int? skip = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceWithHttpMessagesAsync(resourceGroupName, serviceName, filter, top, skip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the entity state (Etag) version of the Diagnostic specified by its
            /// identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='diagnosticId'>
            /// Diagnostic identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            public static DiagnosticGetEntityTagHeaders GetEntityTag(this IDiagnostic operations, string resourceGroupName, string serviceName, string diagnosticId)
            {
                return operations.GetEntityTagAsync(resourceGroupName, serviceName, diagnosticId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the entity state (Etag) version of the Diagnostic specified by its
            /// identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='diagnosticId'>
            /// Diagnostic identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DiagnosticGetEntityTagHeaders> GetEntityTagAsync(this IDiagnostic operations, string resourceGroupName, string serviceName, string diagnosticId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEntityTagWithHttpMessagesAsync(resourceGroupName, serviceName, diagnosticId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Gets the details of the Diagnostic specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='diagnosticId'>
            /// Diagnostic identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            public static DiagnosticContract Get(this IDiagnostic operations, string resourceGroupName, string serviceName, string diagnosticId)
            {
                return operations.GetAsync(resourceGroupName, serviceName, diagnosticId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the details of the Diagnostic specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='diagnosticId'>
            /// Diagnostic identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DiagnosticContract> GetAsync(this IDiagnostic operations, string resourceGroupName, string serviceName, string diagnosticId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, diagnosticId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new Diagnostic or updates an existing one.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='diagnosticId'>
            /// Diagnostic identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='parameters'>
            /// Create parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. Not required when creating an entity, but required when
            /// updating an entity.
            /// </param>
            public static DiagnosticContract CreateOrUpdate(this IDiagnostic operations, string resourceGroupName, string serviceName, string diagnosticId, DiagnosticContract parameters, string ifMatch = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, diagnosticId, parameters, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Diagnostic or updates an existing one.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='diagnosticId'>
            /// Diagnostic identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='parameters'>
            /// Create parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. Not required when creating an entity, but required when
            /// updating an entity.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DiagnosticContract> CreateOrUpdateAsync(this IDiagnostic operations, string resourceGroupName, string serviceName, string diagnosticId, DiagnosticContract parameters, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, diagnosticId, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the details of the Diagnostic specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='diagnosticId'>
            /// Diagnostic identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='parameters'>
            /// Diagnostic Update parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static void Update(this IDiagnostic operations, string resourceGroupName, string serviceName, string diagnosticId, DiagnosticContract parameters, string ifMatch)
            {
                operations.UpdateAsync(resourceGroupName, serviceName, diagnosticId, parameters, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the details of the Diagnostic specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='diagnosticId'>
            /// Diagnostic identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='parameters'>
            /// Diagnostic Update parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IDiagnostic operations, string resourceGroupName, string serviceName, string diagnosticId, DiagnosticContract parameters, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serviceName, diagnosticId, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deletes the specified Diagnostic.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='diagnosticId'>
            /// Diagnostic identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static void Delete(this IDiagnostic operations, string resourceGroupName, string serviceName, string diagnosticId, string ifMatch)
            {
                operations.DeleteAsync(resourceGroupName, serviceName, diagnosticId, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified Diagnostic.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='diagnosticId'>
            /// Diagnostic identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDiagnostic operations, string resourceGroupName, string serviceName, string diagnosticId, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, diagnosticId, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
