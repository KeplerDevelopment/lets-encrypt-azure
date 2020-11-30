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
    /// Gateway key regeneration request contract properties.
    /// </summary>
    public partial class GatewayKeyRegenerationRequestContract
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GatewayKeyRegenerationRequestContract class.
        /// </summary>
        public GatewayKeyRegenerationRequestContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GatewayKeyRegenerationRequestContract class.
        /// </summary>
        /// <param name="keyType">The Key being regenerated. Possible values
        /// include: 'primary', 'secondary'</param>
        public GatewayKeyRegenerationRequestContract(KeyType keyType)
        {
            KeyType = keyType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Key being regenerated. Possible values include:
        /// 'primary', 'secondary'
        /// </summary>
        [JsonProperty(PropertyName = "keyType")]
        public KeyType KeyType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
