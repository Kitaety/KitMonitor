# UpdateCompanyRequest


| Property  | Type            | Required | Description                         |
| :-------- | :-------------- | :------- | :---------------------------------- |
| `Data`    | `ClientCompany` | YES      | Company object with information     |


### ClientCompany ([describtion](../Entities/ClientCompany.md))

| Property  | Type           | Required | Description                         |
| :-------- | :------------- | :------- | :---------------------------------- |
| `Id`      | `long integer` | YES      | Unique indentificator of Company    |
| `Name`    | `string`       | YES      | Name of Company. Maximum length 255 |



## JSON Example

```
{
  "data": {
    "id" : 0
    "name" : "Name Of Company"
  }
}
```
