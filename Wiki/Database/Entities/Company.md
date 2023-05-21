# Company

Contains information about the company


| Primary key | Property        | Type            | Allow Null | Description                                                     |
| :---------- | :-------------- | :-------------- | :--------- | :-------------------------------------------------------------- |
| Yes         | `Id`            | `bigint`        |            | Unique indentificator of Company. Autoincriment                 |
|             | `Name`          | `nvarchar(255)` |            | Name of Company. Max length 255                                 |

## Relationship

`one` Company can have `many` [MonitorSystems](./MonitorSystem.md)
