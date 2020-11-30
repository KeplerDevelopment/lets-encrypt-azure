// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Apimanagement.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An API Version Set contains the common configuration for a set of API
    /// Versions relating
    /// </summary>
    public partial class ApiVersionSetContractDetails
    {
        /// <summary>
        /// Initializes a new instance of the ApiVersionSetContractDetails
        /// class.
        /// </summary>
        public ApiVersionSetContractDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiVersionSetContractDetails
        /// class.
        /// </summary>
        /// <param name="id">Identifier for existing API Version Set. Omit this
        /// value to create a new Version Set.</param>
        /// <param name="name">The display Name of the API Version Set.</param>
        /// <param name="description">Description of API Version Set.</param>
        /// <param name="versioningScheme">An value that determines where the
        /// API Version identifer will be located in a HTTP request. Possible
        /// values include: 'Segment', 'Query', 'Header'</param>
        /// <param name="versionQueryName">Name of query parameter that
        /// indicates the API Version if versioningScheme is set to
        /// `query`.</param>
        /// <param name="versionHeaderName">Name of HTTP header parameter that
        /// indicates the API Version if versioningScheme is set to
        /// `header`.</param>
        public ApiVersionSetContractDetails(string id = default(string), string name = default(string), string description = default(string), string versioningScheme = default(string), string versionQueryName = default(string), string versionHeaderName = default(string))
        {
            Id = id;
            Name = name;
            Description = description;
            VersioningScheme = versioningScheme;
            VersionQueryName = versionQueryName;
            VersionHeaderName = versionHeaderName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets identifier for existing API Version Set. Omit this
        /// value to create a new Version Set.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the display Name of the API Version Set.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets description of API Version Set.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets an value that determines where the API Version
        /// identifer will be located in a HTTP request. Possible values
        /// include: 'Segment', 'Query', 'Header'
        /// </summary>
        [JsonProperty(PropertyName = "versioningScheme")]
        public string VersioningScheme { get; set; }

        /// <summary>
        /// Gets or sets name of query parameter that indicates the API Version
        /// if versioningScheme is set to `query`.
        /// </summary>
        [JsonProperty(PropertyName = "versionQueryName")]
        public string VersionQueryName { get; set; }

        /// <summary>
        /// Gets or sets name of HTTP header parameter that indicates the API
        /// Version if versioningScheme is set to `header`.
        /// </summary>
        [JsonProperty(PropertyName = "versionHeaderName")]
        public string VersionHeaderName { get; set; }

    }
}
