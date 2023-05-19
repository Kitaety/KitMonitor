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

## Response

Type: `application/json`

ID of the created company

### JSON Example

```
1
```
