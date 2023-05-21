# Update Company Endpoint

## URL

```
  PUT /api/Company
```

## Request

Type: `application/json`

Model: [UpdateCompanyRequest](../../Models/Requests/UpdateCompanyRequest.md)

### JSON Example

```
{
  "data": {
    "id" : "ID of Company"
    "name" : "Name Of Company"
  }
}
```

## Response

### OK

Code: 200

Type: `application/json`

Model: [ValueResponse](../Models/Responses/ValueResponse.md)

Data: ID of the updated company

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

Model: [ErrorResponse](../Models/Responses/ErrorResponse.md)

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
