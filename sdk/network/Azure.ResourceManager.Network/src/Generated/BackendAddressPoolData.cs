// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the BackendAddressPool data model. </summary>
    public partial class BackendAddressPoolData : Models.SubResource
    {
        /// <summary> Initializes a new instance of BackendAddressPoolData. </summary>
        public BackendAddressPoolData()
        {
            TunnelInterfaces = new ChangeTrackingList<GatewayLoadBalancerTunnelInterface>();
            LoadBalancerBackendAddresses = new ChangeTrackingList<LoadBalancerBackendAddress>();
            BackendIPConfigurations = new ChangeTrackingList<NetworkInterfaceIPConfigurationData>();
            LoadBalancingRules = new ChangeTrackingList<WritableSubResource>();
            OutboundRules = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of BackendAddressPoolData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource that is unique within the set of backend address pools used by the load balancer. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="resourceType"> Type of the resource. </param>
        /// <param name="location"> The location of the backend address pool. </param>
        /// <param name="tunnelInterfaces"> An array of gateway load balancer tunnel interfaces. </param>
        /// <param name="loadBalancerBackendAddresses"> An array of backend addresses. </param>
        /// <param name="backendIPConfigurations"> An array of references to IP addresses defined in network interfaces. </param>
        /// <param name="loadBalancingRules"> An array of references to load balancing rules that use this backend address pool. </param>
        /// <param name="outboundRule"> A reference to an outbound rule that uses this backend address pool. </param>
        /// <param name="outboundRules"> An array of references to outbound rules that use this backend address pool. </param>
        /// <param name="provisioningState"> The provisioning state of the backend address pool resource. </param>
        internal BackendAddressPoolData(string id, string name, string etag, string resourceType, string location, IList<GatewayLoadBalancerTunnelInterface> tunnelInterfaces, IList<LoadBalancerBackendAddress> loadBalancerBackendAddresses, IReadOnlyList<NetworkInterfaceIPConfigurationData> backendIPConfigurations, IReadOnlyList<WritableSubResource> loadBalancingRules, WritableSubResource outboundRule, IReadOnlyList<WritableSubResource> outboundRules, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            ResourceType = resourceType;
            Location = location;
            TunnelInterfaces = tunnelInterfaces;
            LoadBalancerBackendAddresses = loadBalancerBackendAddresses;
            BackendIPConfigurations = backendIPConfigurations;
            LoadBalancingRules = loadBalancingRules;
            OutboundRule = outboundRule;
            OutboundRules = outboundRules;
            ProvisioningState = provisioningState;
        }

        /// <summary> The name of the resource that is unique within the set of backend address pools used by the load balancer. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Type of the resource. </summary>
        public string ResourceType { get; }
        /// <summary> The location of the backend address pool. </summary>
        public string Location { get; set; }
        /// <summary> An array of gateway load balancer tunnel interfaces. </summary>
        public IList<GatewayLoadBalancerTunnelInterface> TunnelInterfaces { get; }
        /// <summary> An array of backend addresses. </summary>
        public IList<LoadBalancerBackendAddress> LoadBalancerBackendAddresses { get; }
        /// <summary> An array of references to IP addresses defined in network interfaces. </summary>
        public IReadOnlyList<NetworkInterfaceIPConfigurationData> BackendIPConfigurations { get; }
        /// <summary> An array of references to load balancing rules that use this backend address pool. </summary>
        public IReadOnlyList<WritableSubResource> LoadBalancingRules { get; }
        /// <summary> A reference to an outbound rule that uses this backend address pool. </summary>
        internal WritableSubResource OutboundRule { get; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier OutboundRuleId
        {
            get => OutboundRule?.Id;
        }

        /// <summary> An array of references to outbound rules that use this backend address pool. </summary>
        public IReadOnlyList<WritableSubResource> OutboundRules { get; }
        /// <summary> The provisioning state of the backend address pool resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
