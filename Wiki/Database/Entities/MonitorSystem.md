# MonitorSystem

Contains information about the company


| Primary key | Property        | Type            | Allow Null | Description                                                     |
| :---------- | :-------------- | :-------------- | :--------- | :-------------------------------------------------------------- |
|      *      | `Id`            | `bigint`        |            | Unique indentificator of Monitor System. Autoincriment          |
|             | `Name`          | `nvarchar(255)` |            | Name of Monitor System. Max length 255                          |
|             | `Status`        | `int`           |            | Status of Monitor System. Can be one of `0`. `1`, `2`           |
|             | `CompanyId `    | `bigint`        |            | Indentificator of Company                                       |

### Status

| Code | Name              |
| :--- | :---------------- |
| `0`  | Disconnected      |
| `1`  | Connected         |
| `2`  | Error             |

## Relationship

`one` MonitorSystem should have `one` [Company](./Company.md)

`one` MonitorSystem can have `many` [Indicators](./Indicator.md)
