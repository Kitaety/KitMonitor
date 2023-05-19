# CreateCompanyRequest


| Property  | Type            | Required | Description                         |
| :-------- | :-------------- | :------- | :---------------------------------- |
| `Data`    | `ClientCompany` | YES      | Company object with information     |


### ClientCompany ([describtion](../Entities/ClientCompany.md))

| Property  | Type           | Required | Description                         |
| :-------- | :------------- | :------- | :---------------------------------- |
| `Name`    | `string`       | YES      | Name of Company. Maximum length 255 |



## JSON Example

```
{
  "data": {
    "name" : "Name Of Company"
  }
}
```
