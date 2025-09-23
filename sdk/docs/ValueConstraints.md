# Finbourne.Workflow.Sdk.Model.ValueConstraints
Constraints that should be applied to a Tasks fields

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConstraintType** | **string** | Whether the constraint is a suggestion or should be enforced via validation (e.g. Suggested, Validated) | 
**ValueSourceType** | **string** | The source of the acceptable values (e.g. AcceptableValues) | 
**AcceptableValues** | **List&lt;Object&gt;** | The acceptable values for the field | 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string constraintType = "constraintType";
string valueSourceType = "valueSourceType";
List<Object> acceptableValues = new List<Object>();

ValueConstraints valueConstraintsInstance = new ValueConstraints(
    constraintType: constraintType,
    valueSourceType: valueSourceType,
    acceptableValues: acceptableValues);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
