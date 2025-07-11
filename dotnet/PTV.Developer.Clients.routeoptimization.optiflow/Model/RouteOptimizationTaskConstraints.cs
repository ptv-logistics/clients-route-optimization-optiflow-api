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
    /// Constraints on the way tasks can be scheduled together on routes.
    /// </summary>
    [DataContract(Name = "TaskConstraints")]
    public partial class RouteOptimizationTaskConstraints : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteOptimizationTaskConstraints" /> class.
        /// </summary>
        /// <param name="groups">A list of task groups. Tasks belonging to the same task group must be planned on the same route, or consecutively if they are on the same route, depending on the constraint defined in the task group..</param>
        /// <param name="respectedSequences">A list of sequences that must be respected when scheduling routes. Tasks belonging to a category that occurs earlier in the sequence must be scheduled on the route before a task belonging to a category later in the sequence..</param>
        /// <param name="forbiddenSequences">A list of sequences that are forbidden to be scheduled on a route. Tasks belonging to certain categories must not be scheduled before, or immediately before, tasks belonging to another specific category..</param>
        /// <param name="loadingIncompatibilities">A list of constraints that prevent tasks to be loaded or unloaded depending on which other orders are loaded in the vehicle..</param>
        public RouteOptimizationTaskConstraints(List<RouteOptimizationTaskGroup> groups = default(List<RouteOptimizationTaskGroup>), List<RouteOptimizationRespectedTaskSequence> respectedSequences = default(List<RouteOptimizationRespectedTaskSequence>), List<RouteOptimizationForbiddenTaskSequence> forbiddenSequences = default(List<RouteOptimizationForbiddenTaskSequence>), List<RouteOptimizationTaskLoadingIncompatibilityConstraint> loadingIncompatibilities = default(List<RouteOptimizationTaskLoadingIncompatibilityConstraint>))
        {
            this.Groups = groups;
            this.RespectedSequences = respectedSequences;
            this.ForbiddenSequences = forbiddenSequences;
            this.LoadingIncompatibilities = loadingIncompatibilities;
        }

        /// <summary>
        /// A list of task groups. Tasks belonging to the same task group must be planned on the same route, or consecutively if they are on the same route, depending on the constraint defined in the task group.
        /// </summary>
        /// <value>A list of task groups. Tasks belonging to the same task group must be planned on the same route, or consecutively if they are on the same route, depending on the constraint defined in the task group.</value>
        [DataMember(Name = "groups", EmitDefaultValue = false)]
        public List<RouteOptimizationTaskGroup> Groups { get; set; }

        /// <summary>
        /// A list of sequences that must be respected when scheduling routes. Tasks belonging to a category that occurs earlier in the sequence must be scheduled on the route before a task belonging to a category later in the sequence.
        /// </summary>
        /// <value>A list of sequences that must be respected when scheduling routes. Tasks belonging to a category that occurs earlier in the sequence must be scheduled on the route before a task belonging to a category later in the sequence.</value>
        [DataMember(Name = "respectedSequences", EmitDefaultValue = false)]
        public List<RouteOptimizationRespectedTaskSequence> RespectedSequences { get; set; }

        /// <summary>
        /// A list of sequences that are forbidden to be scheduled on a route. Tasks belonging to certain categories must not be scheduled before, or immediately before, tasks belonging to another specific category.
        /// </summary>
        /// <value>A list of sequences that are forbidden to be scheduled on a route. Tasks belonging to certain categories must not be scheduled before, or immediately before, tasks belonging to another specific category.</value>
        [DataMember(Name = "forbiddenSequences", EmitDefaultValue = false)]
        public List<RouteOptimizationForbiddenTaskSequence> ForbiddenSequences { get; set; }

        /// <summary>
        /// A list of constraints that prevent tasks to be loaded or unloaded depending on which other orders are loaded in the vehicle.
        /// </summary>
        /// <value>A list of constraints that prevent tasks to be loaded or unloaded depending on which other orders are loaded in the vehicle.</value>
        [DataMember(Name = "loadingIncompatibilities", EmitDefaultValue = false)]
        public List<RouteOptimizationTaskLoadingIncompatibilityConstraint> LoadingIncompatibilities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RouteOptimizationTaskConstraints {\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  RespectedSequences: ").Append(RespectedSequences).Append("\n");
            sb.Append("  ForbiddenSequences: ").Append(ForbiddenSequences).Append("\n");
            sb.Append("  LoadingIncompatibilities: ").Append(LoadingIncompatibilities).Append("\n");
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
