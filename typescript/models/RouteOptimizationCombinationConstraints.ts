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
import type { RouteOptimizationDepotVehicleCombinationConstraint } from './RouteOptimizationDepotVehicleCombinationConstraint';
import {
    RouteOptimizationDepotVehicleCombinationConstraintFromJSON,
    RouteOptimizationDepotVehicleCombinationConstraintFromJSONTyped,
    RouteOptimizationDepotVehicleCombinationConstraintToJSON,
} from './RouteOptimizationDepotVehicleCombinationConstraint';
import type { RouteOptimizationOrderCompartmentCombinationConstraint } from './RouteOptimizationOrderCompartmentCombinationConstraint';
import {
    RouteOptimizationOrderCompartmentCombinationConstraintFromJSON,
    RouteOptimizationOrderCompartmentCombinationConstraintFromJSONTyped,
    RouteOptimizationOrderCompartmentCombinationConstraintToJSON,
} from './RouteOptimizationOrderCompartmentCombinationConstraint';
import type { RouteOptimizationOrderVehicleCombinationConstraint } from './RouteOptimizationOrderVehicleCombinationConstraint';
import {
    RouteOptimizationOrderVehicleCombinationConstraintFromJSON,
    RouteOptimizationOrderVehicleCombinationConstraintFromJSONTyped,
    RouteOptimizationOrderVehicleCombinationConstraintToJSON,
} from './RouteOptimizationOrderVehicleCombinationConstraint';

/**
 * Describes constraints on combinations of orders, vehicles and depots.
 * @export
 * @interface RouteOptimizationCombinationConstraints
 */
export interface RouteOptimizationCombinationConstraints {
    /**
     * A list of constraints on combinations of orders and compartments.
     * @type {Array<RouteOptimizationOrderCompartmentCombinationConstraint>}
     * @memberof RouteOptimizationCombinationConstraints
     */
    orderCompartment?: Array<RouteOptimizationOrderCompartmentCombinationConstraint>;
    /**
     * A list of constraints on combinations of orders and vehicles.
     * @type {Array<RouteOptimizationOrderVehicleCombinationConstraint>}
     * @memberof RouteOptimizationCombinationConstraints
     */
    orderVehicle?: Array<RouteOptimizationOrderVehicleCombinationConstraint>;
    /**
     * A list of constraints on combinations of depots and vehicles.
     * @type {Array<RouteOptimizationDepotVehicleCombinationConstraint>}
     * @memberof RouteOptimizationCombinationConstraints
     */
    depotVehicle?: Array<RouteOptimizationDepotVehicleCombinationConstraint>;
}

/**
 * Check if a given object implements the RouteOptimizationCombinationConstraints interface.
 */
export function instanceOfRouteOptimizationCombinationConstraints(value: object): boolean {
    return true;
}

export function RouteOptimizationCombinationConstraintsFromJSON(json: any): RouteOptimizationCombinationConstraints {
    return RouteOptimizationCombinationConstraintsFromJSONTyped(json, false);
}

export function RouteOptimizationCombinationConstraintsFromJSONTyped(json: any, ignoreDiscriminator: boolean): RouteOptimizationCombinationConstraints {
    if (json == null) {
        return json;
    }
    return {
        
        'orderCompartment': json['orderCompartment'] == null ? undefined : ((json['orderCompartment'] as Array<any>).map(RouteOptimizationOrderCompartmentCombinationConstraintFromJSON)),
        'orderVehicle': json['orderVehicle'] == null ? undefined : ((json['orderVehicle'] as Array<any>).map(RouteOptimizationOrderVehicleCombinationConstraintFromJSON)),
        'depotVehicle': json['depotVehicle'] == null ? undefined : ((json['depotVehicle'] as Array<any>).map(RouteOptimizationDepotVehicleCombinationConstraintFromJSON)),
    };
}

export function RouteOptimizationCombinationConstraintsToJSON(value?: RouteOptimizationCombinationConstraints | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'orderCompartment': value['orderCompartment'] == null ? undefined : ((value['orderCompartment'] as Array<any>).map(RouteOptimizationOrderCompartmentCombinationConstraintToJSON)),
        'orderVehicle': value['orderVehicle'] == null ? undefined : ((value['orderVehicle'] as Array<any>).map(RouteOptimizationOrderVehicleCombinationConstraintToJSON)),
        'depotVehicle': value['depotVehicle'] == null ? undefined : ((value['depotVehicle'] as Array<any>).map(RouteOptimizationDepotVehicleCombinationConstraintToJSON)),
    };
}

