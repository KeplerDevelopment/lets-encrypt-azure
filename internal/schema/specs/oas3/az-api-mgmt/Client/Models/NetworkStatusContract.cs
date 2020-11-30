// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Apimanagement.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Network Status details.
    /// </summary>
    public partial class NetworkStatusContract
    {
        /// <summary>
        /// Initializes a new instance of the NetworkStatusContract class.
        /// </summary>
        public NetworkStatusContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkStatusContract class.
        /// </summary>
        /// <param name="dnsServers">Gets the list of DNS servers IPV4
        /// addresses.</param>
        /// <param name="connectivityStatus">Gets the list of Connectivity
        /// Status to the Resources on which the service depends upon.</param>
        public NetworkStatusContract(IList<string> dnsServers, IList<ConnectivityStatusContract> connectivityStatus)
        {
            DnsServers = dnsServers;
            ConnectivityStatus = connectivityStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the list of DNS servers IPV4 addresses.
        /// </summary>
        [JsonProperty(PropertyName = "dnsServers")]
        public IList<string> DnsServers { get; set; }

        /// <summary>
        /// Gets the list of Connectivity Status to the Resources on which the
        /// service depends upon.
        /// </summary>
        [JsonProperty(PropertyName = "connectivityStatus")]
        public IList<ConnectivityStatusContract> ConnectivityStatus { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DnsServers == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DnsServers");
            }
            if (ConnectivityStatus == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectivityStatus");
            }
            if (ConnectivityStatus != null)
            {
                foreach (var element in ConnectivityStatus)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
