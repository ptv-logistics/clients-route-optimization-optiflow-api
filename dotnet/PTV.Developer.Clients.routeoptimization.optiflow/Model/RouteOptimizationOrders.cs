/*
 * Route Optimization OptiFlow
 *
 * With the Route Optimization OptiFlow service you can schedule and optimize the routes of your fleet.
 *
 * The version of the OpenAPI document: 1.17
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = PTV.Developer.Clients.routeoptimization.optiflow.Client.OpenAPIDateConverter;

namespace PTV.Developer.Clients.routeoptimization.optiflow.Model
{
    /// <summary>
    /// A list of orders that should be scheduled by the optimization on the routes. When providing pickup-delivery orders, it is not possible to provide other order types. If pickup orders or delivery orders are provided, at least one depot must be provided where the pickup orders can be delivered to or the delivery orders can be picked up from. The unique identifiers of the orders must by unique across the three types.
    /// </summary>
    [DataContract(Name = "Orders")]
    public partial class RouteOptimizationOrders : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteOptimizationOrders" /> class.
        /// </summary>
        /// <param name="pickups">A list of orders that must be picked up from a specific location and transported to a depot. Please note that the upper bound on number of pickups is a technical limit. Check your individual price plan or contract to see which limits apply..</param>
        /// <param name="deliveries">A list of orders that must be delivered to a specific location and transported from a depot. Please note that the upper bound on number of deliveries is a technical limit. Check your individual price plan or contract to see which limits apply..</param>
        /// <param name="pickupDeliveries">A list of orders that must be picked up at a specific location and delivered to a specific location. Please note that the upper bound on number of pickup-deliveries is a technical limit. Check your individual price plan or contract to see which limits apply..</param>
        public RouteOptimizationOrders(List<RouteOptimizationPickupOrder> pickups = default(List<RouteOptimizationPickupOrder>), List<RouteOptimizationDeliveryOrder> deliveries = default(List<RouteOptimizationDeliveryOrder>), List<RouteOptimizationPickupDeliveryOrder> pickupDeliveries = default(List<RouteOptimizationPickupDeliveryOrder>))
        {
            this.Pickups = pickups;
            this.Deliveries = deliveries;
            this.PickupDeliveries = pickupDeliveries;
        }

        /// <summary>
        /// A list of orders that must be picked up from a specific location and transported to a depot. Please note that the upper bound on number of pickups is a technical limit. Check your individual price plan or contract to see which limits apply.
        /// </summary>
        /// <value>A list of orders that must be picked up from a specific location and transported to a depot. Please note that the upper bound on number of pickups is a technical limit. Check your individual price plan or contract to see which limits apply.</value>
        [DataMember(Name = "pickups", EmitDefaultValue = false)]
        public List<RouteOptimizationPickupOrder> Pickups { get; set; }

        /// <summary>
        /// A list of orders that must be delivered to a specific location and transported from a depot. Please note that the upper bound on number of deliveries is a technical limit. Check your individual price plan or contract to see which limits apply.
        /// </summary>
        /// <value>A list of orders that must be delivered to a specific location and transported from a depot. Please note that the upper bound on number of deliveries is a technical limit. Check your individual price plan or contract to see which limits apply.</value>
        [DataMember(Name = "deliveries", EmitDefaultValue = false)]
        public List<RouteOptimizationDeliveryOrder> Deliveries { get; set; }

        /// <summary>
        /// A list of orders that must be picked up at a specific location and delivered to a specific location. Please note that the upper bound on number of pickup-deliveries is a technical limit. Check your individual price plan or contract to see which limits apply.
        /// </summary>
        /// <value>A list of orders that must be picked up at a specific location and delivered to a specific location. Please note that the upper bound on number of pickup-deliveries is a technical limit. Check your individual price plan or contract to see which limits apply.</value>
        [DataMember(Name = "pickupDeliveries", EmitDefaultValue = false)]
        public List<RouteOptimizationPickupDeliveryOrder> PickupDeliveries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RouteOptimizationOrders {\n");
            sb.Append("  Pickups: ").Append(Pickups).Append("\n");
            sb.Append("  Deliveries: ").Append(Deliveries).Append("\n");
            sb.Append("  PickupDeliveries: ").Append(PickupDeliveries).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
