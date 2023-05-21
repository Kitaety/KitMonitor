# ErrorResponse

Didpanted when the request finoshed with error

| Property  | Type     | Description        |
| :-------- | :------- | :----------------- |
| Data      | `any`    | Contains information about an error. It can be `string`, `list of key-value pairs`, etc |
| ErrorType | `int   ` | Code of type error |

## JSON Example

```
{
  "ErrorType": 3,
  "Data": "Company with Id 1 was not found"
}
```
