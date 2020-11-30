// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Apimanagement.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Content type contract details.
    /// </summary>
    public partial class ContentItemContract : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ContentItemContract class.
        /// </summary>
        public ContentItemContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContentItemContract class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type for API Management
        /// resource.</param>
        /// <param name="properties">Properties of the content item.</param>
        public ContentItemContract(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, object> properties = default(IDictionary<string, object>))
            : base(id, name, type)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets properties of the content item.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, object> Properties { get; set; }

    }
}
