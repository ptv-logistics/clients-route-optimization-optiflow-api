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
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


/**
 * A depot where pickup orders can be delivered to or delivery orders can be picked up from. When stopping at a depot, all pickup orders present in the vehicle are unloaded first. Afterwards delivery orders can be loaded in the vehicle, which must be delivered before stopping at the next depot. When providing pickup or delivery orders, at least one depot should be specified. When providing pickup-delivery orders, no tasks happen at the depot and depots must be omitted.
 */
@JsonPropertyOrder({
  RouteOptimizationDepot.JSON_PROPERTY_ID,
  RouteOptimizationDepot.JSON_PROPERTY_LOCATION_ID,
  RouteOptimizationDepot.JSON_PROPERTY_TIME_SLOT_IDS,
  RouteOptimizationDepot.JSON_PROPERTY_CATEGORIES
})
@jakarta.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2025-07-09T08:40:59.150506716Z[Etc/UTC]", comments = "Generator version: 7.5.0")
public class RouteOptimizationDepot {
  public static final String JSON_PROPERTY_ID = "id";
  private String id;

  public static final String JSON_PROPERTY_LOCATION_ID = "locationId";
  private String locationId;

  public static final String JSON_PROPERTY_TIME_SLOT_IDS = "timeSlotIds";
  private List<String> timeSlotIds = new ArrayList<>();

  public static final String JSON_PROPERTY_CATEGORIES = "categories";
  private List<String> categories = new ArrayList<>();

  public RouteOptimizationDepot() { 
  }

  public RouteOptimizationDepot id(String id) {
    this.id = id;
    return this;
  }

   /**
   * A unique identifier of the depot.
   * @return id
  **/
  @jakarta.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_ID)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public String getId() {
    return id;
  }


  @JsonProperty(JSON_PROPERTY_ID)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setId(String id) {
    this.id = id;
  }


  public RouteOptimizationDepot locationId(String locationId) {
    this.locationId = locationId;
    return this;
  }

   /**
   * The unique identifier of the location where the depot is situated.
   * @return locationId
  **/
  @jakarta.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_LOCATION_ID)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public String getLocationId() {
    return locationId;
  }


  @JsonProperty(JSON_PROPERTY_LOCATION_ID)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setLocationId(String locationId) {
    this.locationId = locationId;
  }


  public RouteOptimizationDepot timeSlotIds(List<String> timeSlotIds) {
    this.timeSlotIds = timeSlotIds;
    return this;
  }

  public RouteOptimizationDepot addTimeSlotIdsItem(String timeSlotIdsItem) {
    if (this.timeSlotIds == null) {
      this.timeSlotIds = new ArrayList<>();
    }
    this.timeSlotIds.add(timeSlotIdsItem);
    return this;
  }

   /**
   * A list of unique identifiers of the time slots of the depot location that can be used to execute tasks at this depot. When empty all time slots can be used. If more than 50 time slots are specified for the depot location, the list must not be empty.
   * @return timeSlotIds
  **/
  @jakarta.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_TIME_SLOT_IDS)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public List<String> getTimeSlotIds() {
    return timeSlotIds;
  }


  @JsonProperty(JSON_PROPERTY_TIME_SLOT_IDS)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setTimeSlotIds(List<String> timeSlotIds) {
    this.timeSlotIds = timeSlotIds;
  }


  public RouteOptimizationDepot categories(List<String> categories) {
    this.categories = categories;
    return this;
  }

  public RouteOptimizationDepot addCategoriesItem(String categoriesItem) {
    if (this.categories == null) {
      this.categories = new ArrayList<>();
    }
    this.categories.add(categoriesItem);
    return this;
  }

   /**
   * A list of categories the depot belongs to that can be used to describe constraints or rules.
   * @return categories
  **/
  @jakarta.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_CATEGORIES)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public List<String> getCategories() {
    return categories;
  }


  @JsonProperty(JSON_PROPERTY_CATEGORIES)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setCategories(List<String> categories) {
    this.categories = categories;
  }


  /**
   * Return true if this Depot object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RouteOptimizationDepot depot = (RouteOptimizationDepot) o;
    return Objects.equals(this.id, depot.id) &&
        Objects.equals(this.locationId, depot.locationId) &&
        Objects.equals(this.timeSlotIds, depot.timeSlotIds) &&
        Objects.equals(this.categories, depot.categories);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, locationId, timeSlotIds, categories);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RouteOptimizationDepot {\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    locationId: ").append(toIndentedString(locationId)).append("\n");
    sb.append("    timeSlotIds: ").append(toIndentedString(timeSlotIds)).append("\n");
    sb.append("    categories: ").append(toIndentedString(categories)).append("\n");
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

    // add `id` to the URL query string
    if (getId() != null) {
      joiner.add(String.format("%sid%s=%s", prefix, suffix, URLEncoder.encode(String.valueOf(getId()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `locationId` to the URL query string
    if (getLocationId() != null) {
      joiner.add(String.format("%slocationId%s=%s", prefix, suffix, URLEncoder.encode(String.valueOf(getLocationId()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `timeSlotIds` to the URL query string
    if (getTimeSlotIds() != null) {
      for (int i = 0; i < getTimeSlotIds().size(); i++) {
        joiner.add(String.format("%stimeSlotIds%s%s=%s", prefix, suffix,
            "".equals(suffix) ? "" : String.format("%s%d%s", containerPrefix, i, containerSuffix),
            URLEncoder.encode(String.valueOf(getTimeSlotIds().get(i)), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
      }
    }

    // add `categories` to the URL query string
    if (getCategories() != null) {
      for (int i = 0; i < getCategories().size(); i++) {
        joiner.add(String.format("%scategories%s%s=%s", prefix, suffix,
            "".equals(suffix) ? "" : String.format("%s%d%s", containerPrefix, i, containerSuffix),
            URLEncoder.encode(String.valueOf(getCategories().get(i)), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
      }
    }

    return joiner.toString();
  }
}

