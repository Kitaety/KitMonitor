# Create Company Endpoint

## URL

```
  POST /api/Company
```

## Request

Type: `application/json`

Model: [CreateCompanyRequest](../../Models/Requests/CreateCompanyRequest.md)

### JSON Example

```
{
  "data": {
    "name" : "Name Of Company"
  }
}
```

***

## Response


### OK

Code: 200

Type: `application/json`

Model: [ValueResponse](../Models/Responses/ValueResponse.md)

Data: ID of the created company

### JSON Example

```
{
  "data" 1
}
```

***

### Invalid Data of Reqquest 

Code: 400

Type: `application/json`

Model: [ValidationErrorResponse](../Models/Responses/ErrorResponse.md)

Data: list of key-value pairs

**Key** — field name (if the key is empty, then the message applies to the entire request)

**Value** — list of error massages

### JSON Example

```
{
  "": [
    "Invalid request data"
  ],
  "Name" : [
    "Name cannot be empty",
    ...
  ]
}
```

***
