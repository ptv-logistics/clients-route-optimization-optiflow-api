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
    /// A vehicle that can be used to schedule routes. The optimization can only assign a single route to a vehicle while respecting the properties and constraints of the vehicle.
    /// </summary>
    [DataContract(Name = "Vehicle")]
    public partial class RouteOptimizationVehicle : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteOptimizationVehicle" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RouteOptimizationVehicle() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteOptimizationVehicle" /> class.
        /// </summary>
        /// <param name="id">A unique identifier of the vehicle. (required).</param>
        /// <param name="start">start (required).</param>
        /// <param name="end">end (required).</param>
        /// <param name="routing">routing (required).</param>
        /// <param name="costs">costs (required).</param>
        /// <param name="preferences">preferences.</param>
        /// <param name="breaks">breaks.</param>
        /// <param name="compartments">A list of compartments available for loading orders. Orders placed into the same compartment must follow the compartment&#39;s loading strategy, which may impose restrictions on the unloading sequence. If orders are loaded into separate compartments, no restrictions apply to the unloading sequence. When unspecified or empty, the vehicle is assumed to have a single compartment with loading strategy &#x60;NONE&#x60;..</param>
        /// <param name="constraints">constraints.</param>
        /// <param name="categories">A list of categories the vehicle belongs to that can be used to describe constraints or rules..</param>
        public RouteOptimizationVehicle(string id = default(string), RouteOptimizationVehicleStart start = default(RouteOptimizationVehicleStart), RouteOptimizationVehicleEnd end = default(RouteOptimizationVehicleEnd), RouteOptimizationVehicleRouting routing = default(RouteOptimizationVehicleRouting), RouteOptimizationVehicleCosts costs = default(RouteOptimizationVehicleCosts), RouteOptimizationVehiclePreferences preferences = default(RouteOptimizationVehiclePreferences), RouteOptimizationBreakSettings breaks = default(RouteOptimizationBreakSettings), List<RouteOptimizationCompartment> compartments = default(List<RouteOptimizationCompartment>), RouteOptimizationVehicleConstraints constraints = default(RouteOptimizationVehicleConstraints), List<string> categories = default(List<string>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for RouteOptimizationVehicle and cannot be null");
            }
            this.Id = id;
            // to ensure "start" is required (not null)
            if (start == null)
            {
                throw new ArgumentNullException("start is a required property for RouteOptimizationVehicle and cannot be null");
            }
            this.Start = start;
            // to ensure "end" is required (not null)
            if (end == null)
            {
                throw new ArgumentNullException("end is a required property for RouteOptimizationVehicle and cannot be null");
            }
            this.End = end;
            // to ensure "routing" is required (not null)
            if (routing == null)
            {
                throw new ArgumentNullException("routing is a required property for RouteOptimizationVehicle and cannot be null");
            }
            this.Routing = routing;
            // to ensure "costs" is required (not null)
            if (costs == null)
            {
                throw new ArgumentNullException("costs is a required property for RouteOptimizationVehicle and cannot be null");
            }
            this.Costs = costs;
            this.Preferences = preferences;
            this.Breaks = breaks;
            this.Compartments = compartments;
            this.Constraints = constraints;
            this.Categories = categories;
        }

        /// <summary>
        /// A unique identifier of the vehicle.
        /// </summary>
        /// <value>A unique identifier of the vehicle.</value>
        /// <example>VEHICLE-123</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name = "start", IsRequired = true, EmitDefaultValue = true)]
        public RouteOptimizationVehicleStart Start { get; set; }

        /// <summary>
        /// Gets or Sets End
        /// </summary>
        [DataMember(Name = "end", IsRequired = true, EmitDefaultValue = true)]
        public RouteOptimizationVehicleEnd End { get; set; }

        /// <summary>
        /// Gets or Sets Routing
        /// </summary>
        [DataMember(Name = "routing", IsRequired = true, EmitDefaultValue = true)]
        public RouteOptimizationVehicleRouting Routing { get; set; }

        /// <summary>
        /// Gets or Sets Costs
        /// </summary>
        [DataMember(Name = "costs", IsRequired = true, EmitDefaultValue = true)]
        public RouteOptimizationVehicleCosts Costs { get; set; }

        /// <summary>
        /// Gets or Sets Preferences
        /// </summary>
        [DataMember(Name = "preferences", EmitDefaultValue = false)]
        public RouteOptimizationVehiclePreferences Preferences { get; set; }

        /// <summary>
        /// Gets or Sets Breaks
        /// </summary>
        [DataMember(Name = "breaks", EmitDefaultValue = false)]
        public RouteOptimizationBreakSettings Breaks { get; set; }

        /// <summary>
        /// A list of compartments available for loading orders. Orders placed into the same compartment must follow the compartment&#39;s loading strategy, which may impose restrictions on the unloading sequence. If orders are loaded into separate compartments, no restrictions apply to the unloading sequence. When unspecified or empty, the vehicle is assumed to have a single compartment with loading strategy &#x60;NONE&#x60;.
        /// </summary>
        /// <value>A list of compartments available for loading orders. Orders placed into the same compartment must follow the compartment&#39;s loading strategy, which may impose restrictions on the unloading sequence. If orders are loaded into separate compartments, no restrictions apply to the unloading sequence. When unspecified or empty, the vehicle is assumed to have a single compartment with loading strategy &#x60;NONE&#x60;.</value>
        [DataMember(Name = "compartments", EmitDefaultValue = false)]
        public List<RouteOptimizationCompartment> Compartments { get; set; }

        /// <summary>
        /// Gets or Sets Constraints
        /// </summary>
        [DataMember(Name = "constraints", EmitDefaultValue = false)]
        public RouteOptimizationVehicleConstraints Constraints { get; set; }

        /// <summary>
        /// A list of categories the vehicle belongs to that can be used to describe constraints or rules.
        /// </summary>
        /// <value>A list of categories the vehicle belongs to that can be used to describe constraints or rules.</value>
        /// <example>[&quot;COOLING&quot;,&quot;SMALL_TRUCK&quot;,&quot;FORK_LIFT&quot;,&quot;SINGLE_COMPARTMENT&quot;]</example>
        [DataMember(Name = "categories", EmitDefaultValue = false)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RouteOptimizationVehicle {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  Routing: ").Append(Routing).Append("\n");
            sb.Append("  Costs: ").Append(Costs).Append("\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
            sb.Append("  Breaks: ").Append(Breaks).Append("\n");
            sb.Append("  Compartments: ").Append(Compartments).Append("\n");
            sb.Append("  Constraints: ").Append(Constraints).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
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
            // Id (string) maxLength
            if (this.Id != null && this.Id.Length > 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be less than 36.", new [] { "Id" });
            }

            // Id (string) minLength
            if (this.Id != null && this.Id.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be greater than 1.", new [] { "Id" });
            }

            if (this.Id != null) {
                // Id (string) pattern
                Regex regexId = new Regex(@"^[a-zA-Z0-9_-]{1,36}$", RegexOptions.CultureInvariant);
                if (!regexId.Match(this.Id).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
                }
            }

            yield break;
        }
    }

}
