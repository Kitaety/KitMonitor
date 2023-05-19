# Indicator

Contains information about the measured parameter


| Property           | Type            | Allow Null | Description                                                      |
| :----------------- | :-------------- | :--------- | :--------------------------------------------------------------- |
| `Id`               | `bigint`        |            | Unique indentificator of Indicator. Autoincriment                |
| `Type`             | `int`           |            | Type of the measured parameter. Can be one of `0`. `1`, `2`, `3` |
| `IdMonitorSystem ` | `bigint`        |            | Indentificator of MonitorSystem                                  |

### Type

| Code | Name              |
| :--- | :---------------- |
| `0`  | Temperature       |
| `1`  | PH                |
| `2`  | TDS               |
| `3`  | Water flow        |


## Relationship

`one` Indicator should have `one` [MonitorSystem](./MonitorSystem.md)

`one` Indicator can have `many` [IndicatorLogs](./IndicatorLog.md)
