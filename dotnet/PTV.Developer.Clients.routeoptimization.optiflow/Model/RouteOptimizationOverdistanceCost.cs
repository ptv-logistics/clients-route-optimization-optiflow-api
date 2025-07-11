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
    /// Specifies an increased cost per kilometer if the total distance of a route exceeds a threshold.
    /// </summary>
    [DataContract(Name = "OverdistanceCost")]
    public partial class RouteOptimizationOverdistanceCost : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteOptimizationOverdistanceCost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RouteOptimizationOverdistanceCost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteOptimizationOverdistanceCost" /> class.
        /// </summary>
        /// <param name="threshold">The threshold for the route&#39;s total distance [m] above which the extra cost per kilometer applies. (required).</param>
        /// <param name="extraPerKilometer">Specifies the extra cost for every kilometer above the threshold. (required).</param>
        public RouteOptimizationOverdistanceCost(int? threshold = default(int?), double? extraPerKilometer = default(double?))
        {
            // to ensure "threshold" is required (not null)
            if (threshold == null)
            {
                throw new ArgumentNullException("threshold is a required property for RouteOptimizationOverdistanceCost and cannot be null");
            }
            this.Threshold = threshold;
            // to ensure "extraPerKilometer" is required (not null)
            if (extraPerKilometer == null)
            {
                throw new ArgumentNullException("extraPerKilometer is a required property for RouteOptimizationOverdistanceCost and cannot be null");
            }
            this.ExtraPerKilometer = extraPerKilometer;
        }

        /// <summary>
        /// The threshold for the route&#39;s total distance [m] above which the extra cost per kilometer applies.
        /// </summary>
        /// <value>The threshold for the route&#39;s total distance [m] above which the extra cost per kilometer applies.</value>
        [DataMember(Name = "threshold", IsRequired = true, EmitDefaultValue = true)]
        public int? Threshold { get; set; }

        /// <summary>
        /// Specifies the extra cost for every kilometer above the threshold.
        /// </summary>
        /// <value>Specifies the extra cost for every kilometer above the threshold.</value>
        [DataMember(Name = "extraPerKilometer", IsRequired = true, EmitDefaultValue = true)]
        public double? ExtraPerKilometer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RouteOptimizationOverdistanceCost {\n");
            sb.Append("  Threshold: ").Append(Threshold).Append("\n");
            sb.Append("  ExtraPerKilometer: ").Append(ExtraPerKilometer).Append("\n");
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
            // Threshold (int?) minimum
            if (this.Threshold < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Threshold, must be a value greater than or equal to 0.", new [] { "Threshold" });
            }

            // ExtraPerKilometer (double?) minimum
            if (this.ExtraPerKilometer < (double?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExtraPerKilometer, must be a value greater than or equal to 0.", new [] { "ExtraPerKilometer" });
            }

            yield break;
        }
    }

}
