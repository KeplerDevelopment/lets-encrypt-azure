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
    /// Paged NamedValue list representation.
    /// </summary>
    public partial class NamedValueCollection
    {
        /// <summary>
        /// Initializes a new instance of the NamedValueCollection class.
        /// </summary>
        public NamedValueCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NamedValueCollection class.
        /// </summary>
        /// <param name="value">Page values.</param>
        /// <param name="nextLink">Next page link if any.</param>
        public NamedValueCollection(IList<NamedValueContract> value = default(IList<NamedValueContract>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets page values.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<NamedValueContract> Value { get; set; }

        /// <summary>
        /// Gets or sets next page link if any.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
