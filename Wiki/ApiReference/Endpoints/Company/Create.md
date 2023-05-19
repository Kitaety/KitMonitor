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

ID of the created company

### JSON Example

```
1
```

***

### Invalid Data of Reqquest 

Code: 400

Type: `application/json`

Сontains a list of key-value pairs



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
