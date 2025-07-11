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


/**
 * Describes which combination of depots and vehicles have to be respected or excluded.
 * * `DEPOT_REQUIRES_VEHICLE` - A depot from the given depot category can only be visited bya vehicle from the given vehicle category.
 * * `VEHICLE_REQUIRES_DEPOT` - A vehicle from the given vehicle category can only visit depots from the given depot category.
 * * `FORBIDDEN_COMBINATION` - A depot from the given depot category cannot be visited by a vehicle from the given vehicle category.
 * @export
 */
export const RouteOptimizationDepotVehicleCombinationConstraintType = {
    DEPOT_REQUIRES_VEHICLE: 'DEPOT_REQUIRES_VEHICLE',
    VEHICLE_REQUIRES_DEPOT: 'VEHICLE_REQUIRES_DEPOT',
    FORBIDDEN_COMBINATION: 'FORBIDDEN_COMBINATION'
} as const;
export type RouteOptimizationDepotVehicleCombinationConstraintType = typeof RouteOptimizationDepotVehicleCombinationConstraintType[keyof typeof RouteOptimizationDepotVehicleCombinationConstraintType];


export function instanceOfRouteOptimizationDepotVehicleCombinationConstraintType(value: any): boolean {
    return Object.values(RouteOptimizationDepotVehicleCombinationConstraintType).includes(value);
}

export function RouteOptimizationDepotVehicleCombinationConstraintTypeFromJSON(json: any): RouteOptimizationDepotVehicleCombinationConstraintType {
    return RouteOptimizationDepotVehicleCombinationConstraintTypeFromJSONTyped(json, false);
}

export function RouteOptimizationDepotVehicleCombinationConstraintTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): RouteOptimizationDepotVehicleCombinationConstraintType {
    return json as RouteOptimizationDepotVehicleCombinationConstraintType;
}

export function RouteOptimizationDepotVehicleCombinationConstraintTypeToJSON(value?: RouteOptimizationDepotVehicleCombinationConstraintType | null): any {
    return value as any;
}

