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
 * Describes which combination of orders and compartments have to be respected or excluded.
 * * `ORDER_REQUIRES_COMPARTMENT` - An order from the given order category can only be loaded into a compartment from the given compartment category.
 * * `COMPARTMENT_REQUIRES_ORDER` - A compartment from the given compartment category can only be used to load orders from the given order category.
 * * `FORBIDDEN_COMBINATION` - An order from the given order category cannot be loaded into a compartment from the given compartment category.
 * @export
 */
export const RouteOptimizationOrderCompartmentCombinationConstraintType = {
    ORDER_REQUIRES_COMPARTMENT: 'ORDER_REQUIRES_COMPARTMENT',
    COMPARTMENT_REQUIRES_ORDER: 'COMPARTMENT_REQUIRES_ORDER',
    FORBIDDEN_COMBINATION: 'FORBIDDEN_COMBINATION'
} as const;
export type RouteOptimizationOrderCompartmentCombinationConstraintType = typeof RouteOptimizationOrderCompartmentCombinationConstraintType[keyof typeof RouteOptimizationOrderCompartmentCombinationConstraintType];


export function instanceOfRouteOptimizationOrderCompartmentCombinationConstraintType(value: any): boolean {
    return Object.values(RouteOptimizationOrderCompartmentCombinationConstraintType).includes(value);
}

export function RouteOptimizationOrderCompartmentCombinationConstraintTypeFromJSON(json: any): RouteOptimizationOrderCompartmentCombinationConstraintType {
    return RouteOptimizationOrderCompartmentCombinationConstraintTypeFromJSONTyped(json, false);
}

export function RouteOptimizationOrderCompartmentCombinationConstraintTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): RouteOptimizationOrderCompartmentCombinationConstraintType {
    return json as RouteOptimizationOrderCompartmentCombinationConstraintType;
}

export function RouteOptimizationOrderCompartmentCombinationConstraintTypeToJSON(value?: RouteOptimizationOrderCompartmentCombinationConstraintType | null): any {
    return value as any;
}

