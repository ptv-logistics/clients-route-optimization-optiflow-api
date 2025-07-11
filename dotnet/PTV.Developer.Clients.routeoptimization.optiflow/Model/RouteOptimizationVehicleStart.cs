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
    /// Describes the start of a route assigned to the vehicle.
    /// </summary>
    [DataContract(Name = "VehicleStart")]
    public partial class RouteOptimizationVehicleStart : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteOptimizationVehicleStart" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RouteOptimizationVehicleStart() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteOptimizationVehicleStart" /> class.
        /// </summary>
        /// <param name="locationId">The unique identifier of the location where a route assigned to the vehicle must start. (required).</param>
        /// <param name="earliestStartTime">The earliest point in time a route assigned to the vehicle may start. This must be not be later than the vehicle&#39;s latest end time. When used in conjunction with a latest start time, the earliest start time must not be later than the latest start time. Formatted according to [RFC 3339, section 5.6](https://tools.ietf.org/html/rfc3339#section-5.6). The date must not be before &#x60;1970-01-01T00:00:00+00:00&#x60; nor after &#x60;2037-12-31T23:59:59+00:00&#x60;. The date must provide an offset to UTC. (required).</param>
        /// <param name="latestStartTime">The latest point in time a route assigned to the vehicle may start. This must not be earlier than the vehicle&#39;s earliest start time nor later than the vehicle&#39;s earliest end time. Formatted according to [RFC 3339, section 5.6](https://tools.ietf.org/html/rfc3339#section-5.6). The date must not be before &#x60;1970-01-01T00:00:00+00:00&#x60; nor after &#x60;2037-12-31T23:59:59+00:00&#x60;. The date must provide an offset to UTC..</param>
        /// <param name="duration">Describes how long [s] it takes for the vehicle to depart at its start location after the route starts. (default to 0).</param>
        public RouteOptimizationVehicleStart(string locationId = default(string), DateTimeOffset? earliestStartTime = default(DateTimeOffset?), DateTimeOffset? latestStartTime = default(DateTimeOffset?), int? duration = 0)
        {
            // to ensure "locationId" is required (not null)
            if (locationId == null)
            {
                throw new ArgumentNullException("locationId is a required property for RouteOptimizationVehicleStart and cannot be null");
            }
            this.LocationId = locationId;
            // to ensure "earliestStartTime" is required (not null)
            if (earliestStartTime == null)
            {
                throw new ArgumentNullException("earliestStartTime is a required property for RouteOptimizationVehicleStart and cannot be null");
            }
            this.EarliestStartTime = earliestStartTime;
            this.LatestStartTime = latestStartTime;
            // use default value if no "duration" provided
            this.Duration = duration ?? 0;
        }

        /// <summary>
        /// The unique identifier of the location where a route assigned to the vehicle must start.
        /// </summary>
        /// <value>The unique identifier of the location where a route assigned to the vehicle must start.</value>
        /// <example>GHENT</example>
        [DataMember(Name = "locationId", IsRequired = true, EmitDefaultValue = true)]
        public string LocationId { get; set; }

        /// <summary>
        /// The earliest point in time a route assigned to the vehicle may start. This must be not be later than the vehicle&#39;s latest end time. When used in conjunction with a latest start time, the earliest start time must not be later than the latest start time. Formatted according to [RFC 3339, section 5.6](https://tools.ietf.org/html/rfc3339#section-5.6). The date must not be before &#x60;1970-01-01T00:00:00+00:00&#x60; nor after &#x60;2037-12-31T23:59:59+00:00&#x60;. The date must provide an offset to UTC.
        /// </summary>
        /// <value>The earliest point in time a route assigned to the vehicle may start. This must be not be later than the vehicle&#39;s latest end time. When used in conjunction with a latest start time, the earliest start time must not be later than the latest start time. Formatted according to [RFC 3339, section 5.6](https://tools.ietf.org/html/rfc3339#section-5.6). The date must not be before &#x60;1970-01-01T00:00:00+00:00&#x60; nor after &#x60;2037-12-31T23:59:59+00:00&#x60;. The date must provide an offset to UTC.</value>
        /// <example>2023-10-03T08:00Z</example>
        [DataMember(Name = "earliestStartTime", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset? EarliestStartTime { get; set; }

        /// <summary>
        /// The latest point in time a route assigned to the vehicle may start. This must not be earlier than the vehicle&#39;s earliest start time nor later than the vehicle&#39;s earliest end time. Formatted according to [RFC 3339, section 5.6](https://tools.ietf.org/html/rfc3339#section-5.6). The date must not be before &#x60;1970-01-01T00:00:00+00:00&#x60; nor after &#x60;2037-12-31T23:59:59+00:00&#x60;. The date must provide an offset to UTC.
        /// </summary>
        /// <value>The latest point in time a route assigned to the vehicle may start. This must not be earlier than the vehicle&#39;s earliest start time nor later than the vehicle&#39;s earliest end time. Formatted according to [RFC 3339, section 5.6](https://tools.ietf.org/html/rfc3339#section-5.6). The date must not be before &#x60;1970-01-01T00:00:00+00:00&#x60; nor after &#x60;2037-12-31T23:59:59+00:00&#x60;. The date must provide an offset to UTC.</value>
        /// <example>2023-10-03T09:00Z</example>
        [DataMember(Name = "latestStartTime", EmitDefaultValue = true)]
        public DateTimeOffset? LatestStartTime { get; set; }

        /// <summary>
        /// Describes how long [s] it takes for the vehicle to depart at its start location after the route starts.
        /// </summary>
        /// <value>Describes how long [s] it takes for the vehicle to depart at its start location after the route starts.</value>
        /// <example>1800</example>
        [DataMember(Name = "duration", EmitDefaultValue = true)]
        public int? Duration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RouteOptimizationVehicleStart {\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  EarliestStartTime: ").Append(EarliestStartTime).Append("\n");
            sb.Append("  LatestStartTime: ").Append(LatestStartTime).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
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
            // LocationId (string) maxLength
            if (this.LocationId != null && this.LocationId.Length > 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LocationId, length must be less than 36.", new [] { "LocationId" });
            }

            // LocationId (string) minLength
            if (this.LocationId != null && this.LocationId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LocationId, length must be greater than 1.", new [] { "LocationId" });
            }

            if (this.LocationId != null) {
                // LocationId (string) pattern
                Regex regexLocationId = new Regex(@"^[a-zA-Z0-9_-]{1,36}$", RegexOptions.CultureInvariant);
                if (!regexLocationId.Match(this.LocationId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LocationId, must match a pattern of " + regexLocationId, new [] { "LocationId" });
                }
            }

            // Duration (int?) minimum
            if (this.Duration < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Duration, must be a value greater than or equal to 0.", new [] { "Duration" });
            }

            yield break;
        }
    }

}
