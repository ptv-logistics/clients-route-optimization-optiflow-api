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
    /// A specific location where goods have to be picked up or delivered, or where vehicles are located.
    /// </summary>
    [DataContract(Name = "Location")]
    public partial class RouteOptimizationLocation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteOptimizationLocation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RouteOptimizationLocation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteOptimizationLocation" /> class.
        /// </summary>
        /// <param name="id">A unique identifier of the location. (required).</param>
        /// <param name="latitude">The latitude value of the location in degrees (WGS84/EPSG:4326) from south to north. (required).</param>
        /// <param name="longitude">The longitude value of the location in degrees (WGS84/EPSG:4326) from west to east. (required).</param>
        /// <param name="matchSideOfStreet">Requires the vehicle to approach from the side of the street where the location is situated. This prevents the driver from needing to cross the street. (default to false).</param>
        /// <param name="stopProperties">stopProperties.</param>
        /// <param name="categories">A list of categories the location belongs to that can be used to describe constraints or rules..</param>
        public RouteOptimizationLocation(string id = default(string), double? latitude = default(double?), double? longitude = default(double?), bool? matchSideOfStreet = false, RouteOptimizationStopProperties stopProperties = default(RouteOptimizationStopProperties), List<string> categories = default(List<string>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for RouteOptimizationLocation and cannot be null");
            }
            this.Id = id;
            // to ensure "latitude" is required (not null)
            if (latitude == null)
            {
                throw new ArgumentNullException("latitude is a required property for RouteOptimizationLocation and cannot be null");
            }
            this.Latitude = latitude;
            // to ensure "longitude" is required (not null)
            if (longitude == null)
            {
                throw new ArgumentNullException("longitude is a required property for RouteOptimizationLocation and cannot be null");
            }
            this.Longitude = longitude;
            // use default value if no "matchSideOfStreet" provided
            this.MatchSideOfStreet = matchSideOfStreet ?? false;
            this.StopProperties = stopProperties;
            this.Categories = categories;
        }

        /// <summary>
        /// A unique identifier of the location.
        /// </summary>
        /// <value>A unique identifier of the location.</value>
        /// <example>LOCATION-123</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The latitude value of the location in degrees (WGS84/EPSG:4326) from south to north.
        /// </summary>
        /// <value>The latitude value of the location in degrees (WGS84/EPSG:4326) from south to north.</value>
        /// <example>50.95136607213874</example>
        [DataMember(Name = "latitude", IsRequired = true, EmitDefaultValue = true)]
        public double? Latitude { get; set; }

        /// <summary>
        /// The longitude value of the location in degrees (WGS84/EPSG:4326) from west to east.
        /// </summary>
        /// <value>The longitude value of the location in degrees (WGS84/EPSG:4326) from west to east.</value>
        /// <example>3.8068358460359364</example>
        [DataMember(Name = "longitude", IsRequired = true, EmitDefaultValue = true)]
        public double? Longitude { get; set; }

        /// <summary>
        /// Requires the vehicle to approach from the side of the street where the location is situated. This prevents the driver from needing to cross the street.
        /// </summary>
        /// <value>Requires the vehicle to approach from the side of the street where the location is situated. This prevents the driver from needing to cross the street.</value>
        [DataMember(Name = "matchSideOfStreet", EmitDefaultValue = true)]
        public bool? MatchSideOfStreet { get; set; }

        /// <summary>
        /// Gets or Sets StopProperties
        /// </summary>
        [DataMember(Name = "stopProperties", EmitDefaultValue = false)]
        public RouteOptimizationStopProperties StopProperties { get; set; }

        /// <summary>
        /// A list of categories the location belongs to that can be used to describe constraints or rules.
        /// </summary>
        /// <value>A list of categories the location belongs to that can be used to describe constraints or rules.</value>
        /// <example>[&quot;GERMANY&quot;]</example>
        [DataMember(Name = "categories", EmitDefaultValue = false)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RouteOptimizationLocation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  MatchSideOfStreet: ").Append(MatchSideOfStreet).Append("\n");
            sb.Append("  StopProperties: ").Append(StopProperties).Append("\n");
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

            // Latitude (double?) maximum
            if (this.Latitude > (double?)90)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Latitude, must be a value less than or equal to 90.", new [] { "Latitude" });
            }

            // Latitude (double?) minimum
            if (this.Latitude < (double?)-90)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Latitude, must be a value greater than or equal to -90.", new [] { "Latitude" });
            }

            // Longitude (double?) maximum
            if (this.Longitude > (double?)180)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Longitude, must be a value less than or equal to 180.", new [] { "Longitude" });
            }

            // Longitude (double?) minimum
            if (this.Longitude < (double?)-180)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Longitude, must be a value greater than or equal to -180.", new [] { "Longitude" });
            }

            yield break;
        }
    }

}
