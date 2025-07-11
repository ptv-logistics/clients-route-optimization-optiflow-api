/* tslint:disable */
/* eslint-disable */
/**
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

import { mapValues } from '../runtime';
/**
 * Specifies an increased cost per stop if the number of stops of a route exceeds a threshold.
 * @export
 * @interface RouteOptimizationOverstopCost
 */
export interface RouteOptimizationOverstopCost {
    /**
     * The threshold for the route's number of stops above which the extra cost per stop applies.
     * @type {number}
     * @memberof RouteOptimizationOverstopCost
     */
    threshold: number;
    /**
     * Specifies the extra cost for every stop above the threshold.
     * @type {number}
     * @memberof RouteOptimizationOverstopCost
     */
    extraPerStop: number;
}

/**
 * Check if a given object implements the RouteOptimizationOverstopCost interface.
 */
export function instanceOfRouteOptimizationOverstopCost(value: object): boolean {
    if (!('threshold' in value)) return false;
    if (!('extraPerStop' in value)) return false;
    return true;
}

export function RouteOptimizationOverstopCostFromJSON(json: any): RouteOptimizationOverstopCost {
    return RouteOptimizationOverstopCostFromJSONTyped(json, false);
}

export function RouteOptimizationOverstopCostFromJSONTyped(json: any, ignoreDiscriminator: boolean): RouteOptimizationOverstopCost {
    if (json == null) {
        return json;
    }
    return {
        
        'threshold': json['threshold'],
        'extraPerStop': json['extraPerStop'],
    };
}

export function RouteOptimizationOverstopCostToJSON(value?: RouteOptimizationOverstopCost | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'threshold': value['threshold'],
        'extraPerStop': value['extraPerStop'],
    };
}

