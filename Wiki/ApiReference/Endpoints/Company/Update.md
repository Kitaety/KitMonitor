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

Type: `application/json`

ID of the updated company

### JSON Example

```
1
```
