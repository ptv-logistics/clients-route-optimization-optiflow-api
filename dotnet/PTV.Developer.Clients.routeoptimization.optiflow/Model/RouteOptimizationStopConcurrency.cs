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
    /// If stop concurrency is specified, each stop at the location must be assigned to a vehicle slot. Two stops may be assigned to the same vehicle slot if the duration between the end of the last appointment of the first stop and the start of the first appointment of the other stop is at least the specified minimum buffer duration, in which case they are not considered concurrent stops. Assigning at least one stop to a slot incurs a cost, encouraging reduction of the maximum number of concurrent stops at the location. If there is no minimum buffer duration, stops where the first appointment starts at the same time as the last ends do not need to be assigned to a vehicle slot. When omitted, stops at this location will not be assigned to a vehicle slot.
    /// </summary>
    [DataContract(Name = "StopConcurrency")]
    public partial class RouteOptimizationStopConcurrency : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteOptimizationStopConcurrency" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RouteOptimizationStopConcurrency() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteOptimizationStopConcurrency" /> class.
        /// </summary>
        /// <param name="vehicleSlots">A list of available vehicle slots..</param>
        /// <param name="violationCostPerExtraSlot">The additional cost incurred for using an extra vehicle slot beyond the available ones. This must be greater than or equal to the cost of each vehicle slot. (required).</param>
        /// <param name="minimumBufferDuration">The minimum duration [s] between the end of the last appointment of a stop and the start of the first appointment of another stop assigned to the same vehicle slot. (default to 0).</param>
        public RouteOptimizationStopConcurrency(List<RouteOptimizationVehicleSlot> vehicleSlots = default(List<RouteOptimizationVehicleSlot>), double? violationCostPerExtraSlot = default(double?), int? minimumBufferDuration = 0)
        {
            // to ensure "violationCostPerExtraSlot" is required (not null)
            if (violationCostPerExtraSlot == null)
            {
                throw new ArgumentNullException("violationCostPerExtraSlot is a required property for RouteOptimizationStopConcurrency and cannot be null");
            }
            this.ViolationCostPerExtraSlot = violationCostPerExtraSlot;
            this.VehicleSlots = vehicleSlots;
            // use default value if no "minimumBufferDuration" provided
            this.MinimumBufferDuration = minimumBufferDuration ?? 0;
        }

        /// <summary>
        /// A list of available vehicle slots.
        /// </summary>
        /// <value>A list of available vehicle slots.</value>
        [DataMember(Name = "vehicleSlots", EmitDefaultValue = false)]
        public List<RouteOptimizationVehicleSlot> VehicleSlots { get; set; }

        /// <summary>
        /// The additional cost incurred for using an extra vehicle slot beyond the available ones. This must be greater than or equal to the cost of each vehicle slot.
        /// </summary>
        /// <value>The additional cost incurred for using an extra vehicle slot beyond the available ones. This must be greater than or equal to the cost of each vehicle slot.</value>
        /// <example>250</example>
        [DataMember(Name = "violationCostPerExtraSlot", IsRequired = true, EmitDefaultValue = true)]
        public double? ViolationCostPerExtraSlot { get; set; }

        /// <summary>
        /// The minimum duration [s] between the end of the last appointment of a stop and the start of the first appointment of another stop assigned to the same vehicle slot.
        /// </summary>
        /// <value>The minimum duration [s] between the end of the last appointment of a stop and the start of the first appointment of another stop assigned to the same vehicle slot.</value>
        /// <example>1800</example>
        [DataMember(Name = "minimumBufferDuration", EmitDefaultValue = true)]
        public int? MinimumBufferDuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RouteOptimizationStopConcurrency {\n");
            sb.Append("  VehicleSlots: ").Append(VehicleSlots).Append("\n");
            sb.Append("  ViolationCostPerExtraSlot: ").Append(ViolationCostPerExtraSlot).Append("\n");
            sb.Append("  MinimumBufferDuration: ").Append(MinimumBufferDuration).Append("\n");
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
            // ViolationCostPerExtraSlot (double?) minimum
            if (this.ViolationCostPerExtraSlot < (double?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ViolationCostPerExtraSlot, must be a value greater than or equal to 0.", new [] { "ViolationCostPerExtraSlot" });
            }

            // MinimumBufferDuration (int?) minimum
            if (this.MinimumBufferDuration < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinimumBufferDuration, must be a value greater than or equal to 0.", new [] { "MinimumBufferDuration" });
            }

            yield break;
        }
    }

}
