// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Apimanagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Sign-In settings for the Developer Portal.
    /// </summary>
    [JsonTransformation]
    public partial class PortalSigninSettings : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PortalSigninSettings class.
        /// </summary>
        public PortalSigninSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PortalSigninSettings class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type for API Management
        /// resource.</param>
        /// <param name="enabled">Redirect Anonymous users to the Sign-In
        /// page.</param>
        public PortalSigninSettings(string id = default(string), string name = default(string), string type = default(string), bool? enabled = default(bool?))
            : base(id, name, type)
        {
            Enabled = enabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets redirect Anonymous users to the Sign-In page.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool? Enabled { get; set; }

    }
}
