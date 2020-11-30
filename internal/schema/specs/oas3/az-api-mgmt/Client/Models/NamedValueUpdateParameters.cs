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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// NamedValue update Parameters.
    /// </summary>
    [JsonTransformation]
    public partial class NamedValueUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the NamedValueUpdateParameters class.
        /// </summary>
        public NamedValueUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NamedValueUpdateParameters class.
        /// </summary>
        /// <param name="tags">Optional tags that when provided can be used to
        /// filter the NamedValue list.</param>
        /// <param name="secret">Determines whether the value is a secret and
        /// should be encrypted or not. Default value is false.</param>
        /// <param name="displayName">Unique name of NamedValue. It may contain
        /// only letters, digits, period, dash, and underscore
        /// characters.</param>
        /// <param name="value">Value of the NamedValue. Can contain policy
        /// expressions. It may not be empty or consist only of
        /// whitespace.</param>
        public NamedValueUpdateParameters(IList<string> tags = default(IList<string>), bool? secret = default(bool?), string displayName = default(string), string value = default(string))
        {
            Tags = tags;
            Secret = secret;
            DisplayName = displayName;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets optional tags that when provided can be used to filter
        /// the NamedValue list.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tags")]
        public IList<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets determines whether the value is a secret and should be
        /// encrypted or not. Default value is false.
        /// </summary>
        [JsonProperty(PropertyName = "properties.secret")]
        public bool? Secret { get; set; }

        /// <summary>
        /// Gets or sets unique name of NamedValue. It may contain only
        /// letters, digits, period, dash, and underscore characters.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets value of the NamedValue. Can contain policy
        /// expressions. It may not be empty or consist only of whitespace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.value")]
        public string Value { get; set; }

    }
}
