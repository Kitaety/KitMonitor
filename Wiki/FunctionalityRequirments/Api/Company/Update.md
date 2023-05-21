# Update Company

User should send [Update Company Request](../../../ApiReference/Endpoints/Company/Update.md) to update ifromation about Company

## **Validation:**

1. **Id** - cannot be empty.
	- If Id is empty the system should return response with a status code 400 and the message `'Id' must not be empty.`
	- If the system can't find Company by Id the system should return response with a status code 400 and the message `Company with Id {Id} was not found`

2. **Name** - cannot be empty, max length 255
	- If Name is empty the system should return response with a status code 400 and the message `'Name' must not be empty`
	- If the Name length biggest than 255 the system should return response with a status code 400 and the message  `The length of 'Name' must be 255 characters or fewer. You entered {current_length} characters`
