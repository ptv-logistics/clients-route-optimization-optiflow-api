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
import com.ptvgroup.developer.client.routeoptimization.optiflow.model.RouteOptimizationRouteEnd;
import com.ptvgroup.developer.client.routeoptimization.optiflow.model.RouteOptimizationRouteMetrics;
import com.ptvgroup.developer.client.routeoptimization.optiflow.model.RouteOptimizationRouteStart;
import com.ptvgroup.developer.client.routeoptimization.optiflow.model.RouteOptimizationStop;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


/**
 * A route is a sequence of tasks assigned to a vehicle.
 */
@JsonPropertyOrder({
  RouteOptimizationRoute.JSON_PROPERTY_VEHICLE_ID,
  RouteOptimizationRoute.JSON_PROPERTY_START,
  RouteOptimizationRoute.JSON_PROPERTY_STOPS,
  RouteOptimizationRoute.JSON_PROPERTY_END,
  RouteOptimizationRoute.JSON_PROPERTY_METRICS
})
@jakarta.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2025-07-09T08:40:59.150506716Z[Etc/UTC]", comments = "Generator version: 7.5.0")
public class RouteOptimizationRoute {
  public static final String JSON_PROPERTY_VEHICLE_ID = "vehicleId";
  private String vehicleId;

  public static final String JSON_PROPERTY_START = "start";
  private RouteOptimizationRouteStart start;

  public static final String JSON_PROPERTY_STOPS = "stops";
  private List<RouteOptimizationStop> stops = new ArrayList<>();

  public static final String JSON_PROPERTY_END = "end";
  private RouteOptimizationRouteEnd end;

  public static final String JSON_PROPERTY_METRICS = "metrics";
  private RouteOptimizationRouteMetrics metrics;

  public RouteOptimizationRoute() { 
  }

  public RouteOptimizationRoute vehicleId(String vehicleId) {
    this.vehicleId = vehicleId;
    return this;
  }

   /**
   * The unique identifier of the vehicle assigned to the route.
   * @return vehicleId
  **/
  @jakarta.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_VEHICLE_ID)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public String getVehicleId() {
    return vehicleId;
  }


  @JsonProperty(JSON_PROPERTY_VEHICLE_ID)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setVehicleId(String vehicleId) {
    this.vehicleId = vehicleId;
  }


  public RouteOptimizationRoute start(RouteOptimizationRouteStart start) {
    this.start = start;
    return this;
  }

   /**
   * Get start
   * @return start
  **/
  @jakarta.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_START)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public RouteOptimizationRouteStart getStart() {
    return start;
  }


  @JsonProperty(JSON_PROPERTY_START)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setStart(RouteOptimizationRouteStart start) {
    this.start = start;
  }


  public RouteOptimizationRoute stops(List<RouteOptimizationStop> stops) {
    this.stops = stops;
    return this;
  }

  public RouteOptimizationRoute addStopsItem(RouteOptimizationStop stopsItem) {
    if (this.stops == null) {
      this.stops = new ArrayList<>();
    }
    this.stops.add(stopsItem);
    return this;
  }

   /**
   * The list of stops scheduled on the route. A stop describes the visit of a location on a route where one or more tasks are scheduled. Its approach describes how to reach the location from the previous location visited on the route. Consecutive tasks are grouped to an appointment if they are assigned to the same time slot. Consecutive appointments are grouped as a stop if they are scheduled at the same location.
   * @return stops
  **/
  @jakarta.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_STOPS)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public List<RouteOptimizationStop> getStops() {
    return stops;
  }


  @JsonProperty(JSON_PROPERTY_STOPS)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setStops(List<RouteOptimizationStop> stops) {
    this.stops = stops;
  }


  public RouteOptimizationRoute end(RouteOptimizationRouteEnd end) {
    this.end = end;
    return this;
  }

   /**
   * Get end
   * @return end
  **/
  @jakarta.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_END)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public RouteOptimizationRouteEnd getEnd() {
    return end;
  }


  @JsonProperty(JSON_PROPERTY_END)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setEnd(RouteOptimizationRouteEnd end) {
    this.end = end;
  }


  public RouteOptimizationRoute metrics(RouteOptimizationRouteMetrics metrics) {
    this.metrics = metrics;
    return this;
  }

   /**
   * Get metrics
   * @return metrics
  **/
  @jakarta.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_METRICS)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public RouteOptimizationRouteMetrics getMetrics() {
    return metrics;
  }


  @JsonProperty(JSON_PROPERTY_METRICS)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setMetrics(RouteOptimizationRouteMetrics metrics) {
    this.metrics = metrics;
  }


  /**
   * Return true if this Route object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RouteOptimizationRoute route = (RouteOptimizationRoute) o;
    return Objects.equals(this.vehicleId, route.vehicleId) &&
        Objects.equals(this.start, route.start) &&
        Objects.equals(this.stops, route.stops) &&
        Objects.equals(this.end, route.end) &&
        Objects.equals(this.metrics, route.metrics);
  }

  @Override
  public int hashCode() {
    return Objects.hash(vehicleId, start, stops, end, metrics);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RouteOptimizationRoute {\n");
    sb.append("    vehicleId: ").append(toIndentedString(vehicleId)).append("\n");
    sb.append("    start: ").append(toIndentedString(start)).append("\n");
    sb.append("    stops: ").append(toIndentedString(stops)).append("\n");
    sb.append("    end: ").append(toIndentedString(end)).append("\n");
    sb.append("    metrics: ").append(toIndentedString(metrics)).append("\n");
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

    // add `vehicleId` to the URL query string
    if (getVehicleId() != null) {
      joiner.add(String.format("%svehicleId%s=%s", prefix, suffix, URLEncoder.encode(String.valueOf(getVehicleId()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `start` to the URL query string
    if (getStart() != null) {
      joiner.add(getStart().toUrlQueryString(prefix + "start" + suffix));
    }

    // add `stops` to the URL query string
    if (getStops() != null) {
      for (int i = 0; i < getStops().size(); i++) {
        if (getStops().get(i) != null) {
          joiner.add(getStops().get(i).toUrlQueryString(String.format("%sstops%s%s", prefix, suffix,
          "".equals(suffix) ? "" : String.format("%s%d%s", containerPrefix, i, containerSuffix))));
        }
      }
    }

    // add `end` to the URL query string
    if (getEnd() != null) {
      joiner.add(getEnd().toUrlQueryString(prefix + "end" + suffix));
    }

    // add `metrics` to the URL query string
    if (getMetrics() != null) {
      joiner.add(getMetrics().toUrlQueryString(prefix + "metrics" + suffix));
    }

    return joiner.toString();
  }
}

