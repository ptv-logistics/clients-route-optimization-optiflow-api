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
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonValue;

/**
 * Describes the strategy for loading and unloading orders in the compartment. * &#x60;NONE&#x60; - There is no restriction on the sequence of loading or unloading. * &#x60;LAST_IN_FIRST_OUT&#x60; - The last order loaded must be the first to be unloaded.
 */
public enum RouteOptimizationCompartmentLoadingStrategy {
  
  NONE("NONE"),
  
  LAST_IN_FIRST_OUT("LAST_IN_FIRST_OUT");

  private String value;

  RouteOptimizationCompartmentLoadingStrategy(String value) {
    this.value = value;
  }

  @JsonValue
  public String getValue() {
    return value;
  }

  @Override
  public String toString() {
    return String.valueOf(value);
  }

  @JsonCreator
  public static RouteOptimizationCompartmentLoadingStrategy fromValue(String value) {
    for (RouteOptimizationCompartmentLoadingStrategy b : RouteOptimizationCompartmentLoadingStrategy.values()) {
      if (b.value.equals(value)) {
        return b;
      }
    }
    throw new IllegalArgumentException("Unexpected value '" + value + "'");
  }

  /**
   * Convert the instance into URL query string.
   *
   * @param prefix prefix of the query string
   * @return URL query string
   */
  public String toUrlQueryString(String prefix) {
    if (prefix == null) {
      prefix = "";
    }

    return String.format("%s=%s", prefix, this.toString());
  }

}

