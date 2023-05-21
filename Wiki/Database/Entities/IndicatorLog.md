# IndicatorLog

Contains information about the value of the measured parameter

| Primary key | Property           | Type            | Allow Null | Description                                                      |
| :---------- | :----------------- | :-------------- | :--------- | :--------------------------------------------------------------- |
| Yes         | `Id`               | `bigint`        |            | Unique indentificator of IndicatorLog. Autoincriment             |
|             | `TimeStamp`        | `datetime2`     |            | Date and time getting the value of the measured parameter        |
|             | `Value`            | `decimal(15,4)` |            | Value of the measured parameter                                  |
|             | `IndicatorId `     | `bigint`        |            | Indentificator of Indicator                                      |

## Relationship

`one` Indicator should have `one` [Indicator](./Indicator.md)
