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
import com.ptvgroup.developer.client.routeoptimization.optiflow.model.RouteOptimizationOrderLoadingIncompatibilityConstraint;
import com.ptvgroup.developer.client.routeoptimization.optiflow.model.RouteOptimizationRespectedOrderSequence;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


/**
 * Describes constraints on the way orders can be scheduled together on routes.
 */
@JsonPropertyOrder({
  RouteOptimizationOrderConstraints.JSON_PROPERTY_RESPECTED_SEQUENCES,
  RouteOptimizationOrderConstraints.JSON_PROPERTY_LOADING_INCOMPATIBILITIES
})
@jakarta.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2025-07-09T08:40:59.150506716Z[Etc/UTC]", comments = "Generator version: 7.5.0")
public class RouteOptimizationOrderConstraints {
  public static final String JSON_PROPERTY_RESPECTED_SEQUENCES = "respectedSequences";
  private List<RouteOptimizationRespectedOrderSequence> respectedSequences = new ArrayList<>();

  public static final String JSON_PROPERTY_LOADING_INCOMPATIBILITIES = "loadingIncompatibilities";
  private List<RouteOptimizationOrderLoadingIncompatibilityConstraint> loadingIncompatibilities = new ArrayList<>();

  public RouteOptimizationOrderConstraints() { 
  }

  public RouteOptimizationOrderConstraints respectedSequences(List<RouteOptimizationRespectedOrderSequence> respectedSequences) {
    this.respectedSequences = respectedSequences;
    return this;
  }

  public RouteOptimizationOrderConstraints addRespectedSequencesItem(RouteOptimizationRespectedOrderSequence respectedSequencesItem) {
    if (this.respectedSequences == null) {
      this.respectedSequences = new ArrayList<>();
    }
    this.respectedSequences.add(respectedSequencesItem);
    return this;
  }

   /**
   * A list of sequences that must be respected when scheduling routes. Orders belonging to a category that occurs earlier in the sequence must be delivered in the route before an order belonging to a category later in the sequence can be picked up.
   * @return respectedSequences
  **/
  @jakarta.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_RESPECTED_SEQUENCES)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public List<RouteOptimizationRespectedOrderSequence> getRespectedSequences() {
    return respectedSequences;
  }


  @JsonProperty(JSON_PROPERTY_RESPECTED_SEQUENCES)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setRespectedSequences(List<RouteOptimizationRespectedOrderSequence> respectedSequences) {
    this.respectedSequences = respectedSequences;
  }


  public RouteOptimizationOrderConstraints loadingIncompatibilities(List<RouteOptimizationOrderLoadingIncompatibilityConstraint> loadingIncompatibilities) {
    this.loadingIncompatibilities = loadingIncompatibilities;
    return this;
  }

  public RouteOptimizationOrderConstraints addLoadingIncompatibilitiesItem(RouteOptimizationOrderLoadingIncompatibilityConstraint loadingIncompatibilitiesItem) {
    if (this.loadingIncompatibilities == null) {
      this.loadingIncompatibilities = new ArrayList<>();
    }
    this.loadingIncompatibilities.add(loadingIncompatibilitiesItem);
    return this;
  }

   /**
   * A list of constraints that prevent orders to be loaded or unloaded while other orders are loaded in the vehicle.
   * @return loadingIncompatibilities
  **/
  @jakarta.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_LOADING_INCOMPATIBILITIES)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public List<RouteOptimizationOrderLoadingIncompatibilityConstraint> getLoadingIncompatibilities() {
    return loadingIncompatibilities;
  }


  @JsonProperty(JSON_PROPERTY_LOADING_INCOMPATIBILITIES)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setLoadingIncompatibilities(List<RouteOptimizationOrderLoadingIncompatibilityConstraint> loadingIncompatibilities) {
    this.loadingIncompatibilities = loadingIncompatibilities;
  }


  /**
   * Return true if this OrderConstraints object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RouteOptimizationOrderConstraints orderConstraints = (RouteOptimizationOrderConstraints) o;
    return Objects.equals(this.respectedSequences, orderConstraints.respectedSequences) &&
        Objects.equals(this.loadingIncompatibilities, orderConstraints.loadingIncompatibilities);
  }

  @Override
  public int hashCode() {
    return Objects.hash(respectedSequences, loadingIncompatibilities);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RouteOptimizationOrderConstraints {\n");
    sb.append("    respectedSequences: ").append(toIndentedString(respectedSequences)).append("\n");
    sb.append("    loadingIncompatibilities: ").append(toIndentedString(loadingIncompatibilities)).append("\n");
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

    // add `respectedSequences` to the URL query string
    if (getRespectedSequences() != null) {
      for (int i = 0; i < getRespectedSequences().size(); i++) {
        if (getRespectedSequences().get(i) != null) {
          joiner.add(getRespectedSequences().get(i).toUrlQueryString(String.format("%srespectedSequences%s%s", prefix, suffix,
          "".equals(suffix) ? "" : String.format("%s%d%s", containerPrefix, i, containerSuffix))));
        }
      }
    }

    // add `loadingIncompatibilities` to the URL query string
    if (getLoadingIncompatibilities() != null) {
      for (int i = 0; i < getLoadingIncompatibilities().size(); i++) {
        if (getLoadingIncompatibilities().get(i) != null) {
          joiner.add(getLoadingIncompatibilities().get(i).toUrlQueryString(String.format("%sloadingIncompatibilities%s%s", prefix, suffix,
          "".equals(suffix) ? "" : String.format("%s%d%s", containerPrefix, i, containerSuffix))));
        }
      }
    }

    return joiner.toString();
  }
}

