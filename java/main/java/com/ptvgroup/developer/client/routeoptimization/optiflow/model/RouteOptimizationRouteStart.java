/*
 * Route Optimization OptiFlow
 * With the Route Optimization OptiFlow service you can schedule and optimize the routes of your fleet.
 *
 * The version of the OpenAPI document: 1.17
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package com.ptvgroup.developer.client.routeoptimization.optiflow.model;

import java.net.URLEncoder;
import java.nio.charset.StandardCharsets;
import java.util.StringJoiner;
import java.util.Objects;
import java.util.Map;
import java.util.HashMap;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonTypeName;
import com.fasterxml.jackson.annotation.JsonValue;
import java.time.OffsetDateTime;
import java.util.Arrays;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


/**
 * A description of the location and time the route starts.
 */
@JsonPropertyOrder({
  RouteOptimizationRouteStart.JSON_PROPERTY_LOCATION_ID,
  RouteOptimizationRouteStart.JSON_PROPERTY_START,
  RouteOptimizationRouteStart.JSON_PROPERTY_DURATION,
  RouteOptimizationRouteStart.JSON_PROPERTY_DEPARTURE
})
@jakarta.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2025-07-09T08:40:59.150506716Z[Etc/UTC]", comments = "Generator version: 7.5.0")
public class RouteOptimizationRouteStart {
  public static final String JSON_PROPERTY_LOCATION_ID = "locationId";
  private String locationId;

  public static final String JSON_PROPERTY_START = "start";
  private OffsetDateTime start;

  public static final String JSON_PROPERTY_DURATION = "duration";
  private Integer duration;

  public static final String JSON_PROPERTY_DEPARTURE = "departure";
  private OffsetDateTime departure;

  public RouteOptimizationRouteStart() { 
  }

  public RouteOptimizationRouteStart locationId(String locationId) {
    this.locationId = locationId;
    return this;
  }

   /**
   * The unique identifier of the start location of the route. This is the start location of the assigned vehicle.
   * @return locationId
  **/
  @jakarta.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_LOCATION_ID)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public String getLocationId() {
    return locationId;
  }


  @JsonProperty(JSON_PROPERTY_LOCATION_ID)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setLocationId(String locationId) {
    this.locationId = locationId;
  }


  public RouteOptimizationRouteStart start(OffsetDateTime start) {
    this.start = start;
    return this;
  }

   /**
   * The point in time when the route starts. Formatted according to [RFC 3339, section 5.6](https://tools.ietf.org/html/rfc3339#section-5.6).
   * @return start
  **/
  @jakarta.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_START)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public OffsetDateTime getStart() {
    return start;
  }


  @JsonProperty(JSON_PROPERTY_START)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setStart(OffsetDateTime start) {
    this.start = start;
  }


  public RouteOptimizationRouteStart duration(Integer duration) {
    this.duration = duration;
    return this;
  }

   /**
   * The duration [s] between the start of the route and the departure at the start location.
   * minimum: 0
   * @return duration
  **/
  @jakarta.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_DURATION)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public Integer getDuration() {
    return duration;
  }


  @JsonProperty(JSON_PROPERTY_DURATION)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setDuration(Integer duration) {
    this.duration = duration;
  }


  public RouteOptimizationRouteStart departure(OffsetDateTime departure) {
    this.departure = departure;
    return this;
  }

   /**
   * The point in time when the vehicle departs at its start location. Formatted according to [RFC 3339, section 5.6](https://tools.ietf.org/html/rfc3339#section-5.6).
   * @return departure
  **/
  @jakarta.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_DEPARTURE)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public OffsetDateTime getDeparture() {
    return departure;
  }


  @JsonProperty(JSON_PROPERTY_DEPARTURE)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setDeparture(OffsetDateTime departure) {
    this.departure = departure;
  }


  /**
   * Return true if this RouteStart object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RouteOptimizationRouteStart routeStart = (RouteOptimizationRouteStart) o;
    return Objects.equals(this.locationId, routeStart.locationId) &&
        Objects.equals(this.start, routeStart.start) &&
        Objects.equals(this.duration, routeStart.duration) &&
        Objects.equals(this.departure, routeStart.departure);
  }

  @Override
  public int hashCode() {
    return Objects.hash(locationId, start, duration, departure);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RouteOptimizationRouteStart {\n");
    sb.append("    locationId: ").append(toIndentedString(locationId)).append("\n");
    sb.append("    start: ").append(toIndentedString(start)).append("\n");
    sb.append("    duration: ").append(toIndentedString(duration)).append("\n");
    sb.append("    departure: ").append(toIndentedString(departure)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

  /**
   * Convert the instance into URL query string.
   *
   * @return URL query string
   */
  public String toUrlQueryString() {
    return toUrlQueryString(null);
  }

  /**
   * Convert the instance into URL query string.
   *
   * @param prefix prefix of the query string
   * @return URL query string
   */
  public String toUrlQueryString(String prefix) {
    String suffix = "";
    String containerSuffix = "";
    String containerPrefix = "";
    if (prefix == null) {
      // style=form, explode=true, e.g. /pet?name=cat&type=manx
      prefix = "";
    } else {
      // deepObject style e.g. /pet?id[name]=cat&id[type]=manx
      prefix = prefix + "[";
      suffix = "]";
      containerSuffix = "]";
      containerPrefix = "[";
    }

    StringJoiner joiner = new StringJoiner("&");

    // add `locationId` to the URL query string
    if (getLocationId() != null) {
      joiner.add(String.format("%slocationId%s=%s", prefix, suffix, URLEncoder.encode(String.valueOf(getLocationId()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `start` to the URL query string
    if (getStart() != null) {
      joiner.add(String.format("%sstart%s=%s", prefix, suffix, URLEncoder.encode(String.valueOf(getStart()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `duration` to the URL query string
    if (getDuration() != null) {
      joiner.add(String.format("%sduration%s=%s", prefix, suffix, URLEncoder.encode(String.valueOf(getDuration()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `departure` to the URL query string
    if (getDeparture() != null) {
      joiner.add(String.format("%sdeparture%s=%s", prefix, suffix, URLEncoder.encode(String.valueOf(getDeparture()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    return joiner.toString();
  }
}

