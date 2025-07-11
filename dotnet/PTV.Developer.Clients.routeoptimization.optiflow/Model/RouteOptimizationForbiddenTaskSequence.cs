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
    /// Constrains tasks belonging a certain category to be executed before tasks belonging to another category on the route.
    /// </summary>
    [DataContract(Name = "ForbiddenTaskSequence")]
    public partial class RouteOptimizationForbiddenTaskSequence : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public RouteOptimizationForbiddenTaskSequenceType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteOptimizationForbiddenTaskSequence" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RouteOptimizationForbiddenTaskSequence() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteOptimizationForbiddenTaskSequence" /> class.
        /// </summary>
        /// <param name="firstTaskCategory">The category of tasks that cannot be scheduled on the route before a task with the second task category. The constraint will be ignored when no task belongs to this category. (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="secondTaskCategory">The category of the tasks that must not be preceded in the route by tasks belonging to the first task category. The constraint will be ignored when no task belongs to this category. (required).</param>
        /// <param name="vehicleCategory">The category of vehicles to which this constraint applies. When omitted the constraint applies to all vehicles. The constraint will be ignored when no vehicle belongs to this category..</param>
        public RouteOptimizationForbiddenTaskSequence(string firstTaskCategory = default(string), RouteOptimizationForbiddenTaskSequenceType type = default(RouteOptimizationForbiddenTaskSequenceType), string secondTaskCategory = default(string), string vehicleCategory = default(string))
        {
            // to ensure "firstTaskCategory" is required (not null)
            if (firstTaskCategory == null)
            {
                throw new ArgumentNullException("firstTaskCategory is a required property for RouteOptimizationForbiddenTaskSequence and cannot be null");
            }
            this.FirstTaskCategory = firstTaskCategory;
            this.Type = type;
            // to ensure "secondTaskCategory" is required (not null)
            if (secondTaskCategory == null)
            {
                throw new ArgumentNullException("secondTaskCategory is a required property for RouteOptimizationForbiddenTaskSequence and cannot be null");
            }
            this.SecondTaskCategory = secondTaskCategory;
            this.VehicleCategory = vehicleCategory;
        }

        /// <summary>
        /// The category of tasks that cannot be scheduled on the route before a task with the second task category. The constraint will be ignored when no task belongs to this category.
        /// </summary>
        /// <value>The category of tasks that cannot be scheduled on the route before a task with the second task category. The constraint will be ignored when no task belongs to this category.</value>
        /// <example>BLACK_PAINT</example>
        [DataMember(Name = "firstTaskCategory", IsRequired = true, EmitDefaultValue = true)]
        public string FirstTaskCategory { get; set; }

        /// <summary>
        /// The category of the tasks that must not be preceded in the route by tasks belonging to the first task category. The constraint will be ignored when no task belongs to this category.
        /// </summary>
        /// <value>The category of the tasks that must not be preceded in the route by tasks belonging to the first task category. The constraint will be ignored when no task belongs to this category.</value>
        /// <example>WHITE_PAINT</example>
        [DataMember(Name = "secondTaskCategory", IsRequired = true, EmitDefaultValue = true)]
        public string SecondTaskCategory { get; set; }

        /// <summary>
        /// The category of vehicles to which this constraint applies. When omitted the constraint applies to all vehicles. The constraint will be ignored when no vehicle belongs to this category.
        /// </summary>
        /// <value>The category of vehicles to which this constraint applies. When omitted the constraint applies to all vehicles. The constraint will be ignored when no vehicle belongs to this category.</value>
        /// <example>VAN</example>
        [DataMember(Name = "vehicleCategory", EmitDefaultValue = true)]
        public string VehicleCategory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RouteOptimizationForbiddenTaskSequence {\n");
            sb.Append("  FirstTaskCategory: ").Append(FirstTaskCategory).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SecondTaskCategory: ").Append(SecondTaskCategory).Append("\n");
            sb.Append("  VehicleCategory: ").Append(VehicleCategory).Append("\n");
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
            // FirstTaskCategory (string) maxLength
            if (this.FirstTaskCategory != null && this.FirstTaskCategory.Length > 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstTaskCategory, length must be less than 36.", new [] { "FirstTaskCategory" });
            }

            // FirstTaskCategory (string) minLength
            if (this.FirstTaskCategory != null && this.FirstTaskCategory.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstTaskCategory, length must be greater than 1.", new [] { "FirstTaskCategory" });
            }

            if (this.FirstTaskCategory != null) {
                // FirstTaskCategory (string) pattern
                Regex regexFirstTaskCategory = new Regex(@"^[a-zA-Z0-9_-]{1,36}$", RegexOptions.CultureInvariant);
                if (!regexFirstTaskCategory.Match(this.FirstTaskCategory).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstTaskCategory, must match a pattern of " + regexFirstTaskCategory, new [] { "FirstTaskCategory" });
                }
            }

            // SecondTaskCategory (string) maxLength
            if (this.SecondTaskCategory != null && this.SecondTaskCategory.Length > 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecondTaskCategory, length must be less than 36.", new [] { "SecondTaskCategory" });
            }

            // SecondTaskCategory (string) minLength
            if (this.SecondTaskCategory != null && this.SecondTaskCategory.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecondTaskCategory, length must be greater than 1.", new [] { "SecondTaskCategory" });
            }

            if (this.SecondTaskCategory != null) {
                // SecondTaskCategory (string) pattern
                Regex regexSecondTaskCategory = new Regex(@"^[a-zA-Z0-9_-]{1,36}$", RegexOptions.CultureInvariant);
                if (!regexSecondTaskCategory.Match(this.SecondTaskCategory).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecondTaskCategory, must match a pattern of " + regexSecondTaskCategory, new [] { "SecondTaskCategory" });
                }
            }

            // VehicleCategory (string) maxLength
            if (this.VehicleCategory != null && this.VehicleCategory.Length > 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VehicleCategory, length must be less than 36.", new [] { "VehicleCategory" });
            }

            // VehicleCategory (string) minLength
            if (this.VehicleCategory != null && this.VehicleCategory.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VehicleCategory, length must be greater than 1.", new [] { "VehicleCategory" });
            }

            if (this.VehicleCategory != null) {
                // VehicleCategory (string) pattern
                Regex regexVehicleCategory = new Regex(@"^[a-zA-Z0-9_-]{1,36}$", RegexOptions.CultureInvariant);
                if (!regexVehicleCategory.Match(this.VehicleCategory).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VehicleCategory, must match a pattern of " + regexVehicleCategory, new [] { "VehicleCategory" });
                }
            }

            yield break;
        }
    }

}
