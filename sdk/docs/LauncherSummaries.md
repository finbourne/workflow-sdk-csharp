# Finbourne.Workflow.Sdk.Model.LauncherSummaries
Sentences that say what a Launcher does, meant to be shown to a person.              These are rendered on read from the stored Launcher details. They are never stored and never accepted on a write, so the same Launcher always reads back the same summaries

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schedule** | **string** | A sentence that says when the Launcher starts a run, for example \&quot;At 09:00 every weekday, London time\&quot;.              Null for an Event Launcher, which has no schedule | [optional] 
**Fields** | **Dictionary&lt;string, string&gt;** | A sentence for each field of the root task the Launcher fills, keyed by the field name on the root task definition. Empty when the Launcher fills no fields | [optional] 

```csharp
using Finbourne.Workflow.Sdk.Model;
using System;

string schedule = "example schedule";
Dictionary<string, string> fields = new Dictionary<string, string>();

LauncherSummaries launcherSummariesInstance = new LauncherSummaries(
    schedule: schedule,
    fields: fields);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
