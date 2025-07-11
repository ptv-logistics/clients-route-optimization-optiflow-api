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
import com.ptvgroup.developer.client.routeoptimization.optiflow.model.RouteOptimizationOrderCompartmentCombinationConstraintType;
import java.util.Arrays;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


/**
 * A constraint on the combination of orders and compartments belonging to a certain category.
 */
@JsonPropertyOrder({
  RouteOptimizationOrderCompartmentCombinationConstraint.JSON_PROPERTY_TYPE,
  RouteOptimizationOrderCompartmentCombinationConstraint.JSON_PROPERTY_ORDER_CATEGORY,
  RouteOptimizationOrderCompartmentCombinationConstraint.JSON_PROPERTY_COMPARTMENT_CATEGORY
})
@jakarta.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2025-07-09T08:40:59.150506716Z[Etc/UTC]", comments = "Generator version: 7.5.0")
public class RouteOptimizationOrderCompartmentCombinationConstraint {
  public static final String JSON_PROPERTY_TYPE = "type";
  private RouteOptimizationOrderCompartmentCombinationConstraintType type;

  public static final String JSON_PROPERTY_ORDER_CATEGORY = "orderCategory";
  private String orderCategory;

  public static final String JSON_PROPERTY_COMPARTMENT_CATEGORY = "compartmentCategory";
  private String compartmentCategory;

  public RouteOptimizationOrderCompartmentCombinationConstraint() { 
  }

  public RouteOptimizationOrderCompartmentCombinationConstraint type(RouteOptimizationOrderCompartmentCombinationConstraintType type) {
    this.type = type;
    return this;
  }

   /**
   * Get type
   * @return type
  **/
  @jakarta.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_TYPE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public RouteOptimizationOrderCompartmentCombinationConstraintType getType() {
    return type;
  }


  @JsonProperty(JSON_PROPERTY_TYPE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setType(RouteOptimizationOrderCompartmentCombinationConstraintType type) {
    this.type = type;
  }


  public RouteOptimizationOrderCompartmentCombinationConstraint orderCategory(String orderCategory) {
    this.orderCategory = orderCategory;
    return this;
  }

   /**
   * The category of orders to which the constraint applies. The constraint will be ignored when no order belongs to this category.
   * @return orderCategory
  **/
  @jakarta.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_ORDER_CATEGORY)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public String getOrderCategory() {
    return orderCategory;
  }


  @JsonProperty(JSON_PROPERTY_ORDER_CATEGORY)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setOrderCategory(String orderCategory) {
    this.orderCategory = orderCategory;
  }


  public RouteOptimizationOrderCompartmentCombinationConstraint compartmentCategory(String compartmentCategory) {
    this.compartmentCategory = compartmentCategory;
    return this;
  }

   /**
   * The category of compartments to which the constraint applies. The constraint will be ignored when no compartment belongs to this category.
   * @return compartmentCategory
  **/
  @jakarta.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_COMPARTMENT_CATEGORY)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public String getCompartmentCategory() {
    return compartmentCategory;
  }


  @JsonProperty(JSON_PROPERTY_COMPARTMENT_CATEGORY)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setCompartmentCategory(String compartmentCategory) {
    this.compartmentCategory = compartmentCategory;
  }


  /**
   * Return true if this OrderCompartmentCombinationConstraint object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RouteOptimizationOrderCompartmentCombinationConstraint orderCompartmentCombinationConstraint = (RouteOptimizationOrderCompartmentCombinationConstraint) o;
    return Objects.equals(this.type, orderCompartmentCombinationConstraint.type) &&
        Objects.equals(this.orderCategory, orderCompartmentCombinationConstraint.orderCategory) &&
        Objects.equals(this.compartmentCategory, orderCompartmentCombinationConstraint.compartmentCategory);
  }

  @Override
  public int hashCode() {
    return Objects.hash(type, orderCategory, compartmentCategory);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RouteOptimizationOrderCompartmentCombinationConstraint {\n");
    sb.append("    type: ").append(toIndentedString(type)).append("\n");
    sb.append("    orderCategory: ").append(toIndentedString(orderCategory)).append("\n");
    sb.append("    compartmentCategory: ").append(toIndentedString(compartmentCategory)).append("\n");
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

    // add `type` to the URL query string
    if (getType() != null) {
      joiner.add(String.format("%stype%s=%s", prefix, suffix, URLEncoder.encode(String.valueOf(getType()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `orderCategory` to the URL query string
    if (getOrderCategory() != null) {
      joiner.add(String.format("%sorderCategory%s=%s", prefix, suffix, URLEncoder.encode(String.valueOf(getOrderCategory()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `compartmentCategory` to the URL query string
    if (getCompartmentCategory() != null) {
      joiner.add(String.format("%scompartmentCategory%s=%s", prefix, suffix, URLEncoder.encode(String.valueOf(getCompartmentCategory()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    return joiner.toString();
  }
}

