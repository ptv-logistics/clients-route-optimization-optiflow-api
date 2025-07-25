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
 * Describes a vehicle slot that can be assigned stops.
 * @export
 * @interface RouteOptimizationVehicleSlot
 */
export interface RouteOptimizationVehicleSlot {
    /**
     * The cost incurred when assigning at least one stop to this vehicle slot.
     * @type {number}
     * @memberof RouteOptimizationVehicleSlot
     */
    cost?: number;
}

/**
 * Check if a given object implements the RouteOptimizationVehicleSlot interface.
 */
export function instanceOfRouteOptimizationVehicleSlot(value: object): boolean {
    return true;
}

export function RouteOptimizationVehicleSlotFromJSON(json: any): RouteOptimizationVehicleSlot {
    return RouteOptimizationVehicleSlotFromJSONTyped(json, false);
}

export function RouteOptimizationVehicleSlotFromJSONTyped(json: any, ignoreDiscriminator: boolean): RouteOptimizationVehicleSlot {
    if (json == null) {
        return json;
    }
    return {
        
        'cost': json['cost'] == null ? undefined : json['cost'],
    };
}

export function RouteOptimizationVehicleSlotToJSON(value?: RouteOptimizationVehicleSlot | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'cost': value['cost'],
    };
}

