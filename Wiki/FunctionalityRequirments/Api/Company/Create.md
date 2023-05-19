# Create Company

User should send [Create Company Request](../../../ApiReference/Endpoints/Company/Create.md) to create a new Company

## **Validation:**

1. Name - can't be empty, max length 255
	- If Name is empty the system should return response with a status code `400` and the message `'Name' must not be empty.`
	- If the Name length biggest than 255 the system should return response with a status code `400` and the message `The length of 'Name' must be 255 characters or fewer. You entered {current_length} characters.`
