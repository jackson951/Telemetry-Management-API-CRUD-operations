
# NWU Tech Trends Telemetry Management API

## Overview

This project is designed to help NWU Tech Trends track and manage the time and cost savings achieved through automation solutions. By developing a CRUD RESTful API, the system will manage telemetry data, providing insights into savings grouped by project and client. This API will facilitate efficient data handling and reporting, ensuring stakeholders can easily access and analyze the impact of automation.
**Here is the link to the API hosted on azure:** https://cmpg323project2-3999096620240810194825.azurewebsites.net


## Features

- **Create**: Log new telemetry entries.
- **Read**: Retrieve all telemetry entries or a specific entry by ID.
- **Update**: Modify existing telemetry entries.
- **Delete**: Remove telemetry entries from the database.


## API Endpoints

- **GET /api/telemetry**
  - Retrieves all telemetry entries.

- **GET /api/telemetry/{id}**
  - Retrieves a specific telemetry entry by ID.

- **POST /api/telemetry**
  - Creates a new telemetry entry.

- **PATCH /api/telemetry/{id}**
  - Updates an existing telemetry entry.

- **DELETE /api/telemetry/{id}**
  - Deletes a telemetry entry.

- **GET /api/telemetry/GetSavingsByProject**
  - Retrieves cumulative time and cost savings by project, filtered by Project ID and date range.

- **GET /api/telemetry/GetSavingsByClient**
  - Retrieves cumulative time and cost savings by client, filtered by Client ID and date range.
    

## Security

-Error Handling: Error messages do not reveal sensitive information and are handled in a way that avoids disclosing implementation details.
- No credentials are stored on GitHub.
  


## Postman API Testing for NWU Tech Trends Management System

In the development of the NWU Tech Trends Management System, Postman was instrumental in testing and validating the functionality of the API endpoints. Postman provided a user-friendly interface to send various HTTP requests and analyze the responses, ensuring that the API behaved as expected and met the project requirements effectively.

1. **Endpoint Testing**: Utilized Postman to send GET, POST, PATCH, and DELETE requests to different API endpoints to verify data retrieval, creation, updating, and deletion operations.

2. **Parameter Testing**: Tested API endpoints with different parameters to assess how the API handled various input scenarios.

3. **Response Validation**: Checked the responses received from the API against expected results to ensure the correctness of data returned.

4. **Authentication Testing**: Tested authentication mechanisms by including tokens or credentials in requests to authenticate and access protected endpoints.

5. **Error Handling Testing**: Sent invalid requests to test the API's error-handling capabilities and verified that appropriate error responses were returned.

Postman's features, such as collections, environments, and scripts, were utilized to streamline the testing process and maintain test suites for regression testing. The detailed test cases and results were organized within Postman, providing a comprehensive overview of the API's behavior during development.

By leveraging Postman for API testing, the NWU Tech Trends Management System's API was thoroughly validated, ensuring reliability and functionality before deployment.



## Usage

Follow these instructions to interact with the REST API using Postman.

## Setup

1. **Open Postman**: Ensure Postman is installed and running./Alternatively register an account here and continue:https://www.postman.com/
2. **Create a New Request**: Click on "New" and select "Request".

## Endpoints

### 1. Retrieve All Telemetry Entries
- **Method**: GET
- **URL**: `https://cmpg323project2-3999096620240810194825.azurewebsites.net/api/telemetry`
- **Description**: Fetches all telemetry entries.
- **Action**: Click "Send".

### 2. Retrieve Specific Telemetry Entry by ID
- **Method**: GET
- **URL**: `https://cmpg323project2-3999096620240810194825.azurewebsites.net/api/telemetry/{id}`
- **Description**: Replace `{id}` with the specific entry ID.
- **Action**: Click "Send".

### 3. Create a New Telemetry Entry
- **Method**: POST
- **URL**: `https://cmpg323project2-3999096620240810194825.azurewebsites.net/api/telemetry`
- **Body**: Choose "raw" and "JSON". Enter the JSON data for the new entry.
- **Action**: Click "Send".

### 4. Update an Existing Telemetry Entry
- **Method**: PATCH
- **URL**: `https://cmpg323project2-3999096620240810194825.azurewebsites.net/api/telemetry/{id}`
- **Description**: Replace `{id}` with the entry ID you want to update.
- **Body**: Choose "raw" and "JSON". Enter the updated JSON data.
- **Action**: Click "Send".

### 5. Delete a Telemetry Entry
- **Method**: DELETE
- **URL**: `https://cmpg323project2-3999096620240810194825.azurewebsites.net/api/telemetry/{id}`
- **Description**: Replace `{id}` with the entry ID you wish to delete.
- **Action**: Click "Send".

### 6. Get Savings by Project
- **Method**: GET
- **URL**: `https://cmpg323project2-3999096620240810194825.azurewebsites.net/api/telemetry/GetSavingsByProject`
- **Example**: `https://cmpg323project2-3999096620240810194825.azurewebsites.net/api/telemetry/GetSavingsByProject?projectId=12345&startDate=2024-08-01&endDate=2024-08-10`
- **Description**: Retrieves savings filtered by Project ID and date range.
- **Action**: Click "Send".

### 7. Get Savings by Client
- **Method**: GET
- **URL**: `https://cmpg323project2-3999096620240810194825.azurewebsites.net/api/telemetry/GetSavingsByClient`
- **Example**: `https://cmpg323project2-3999096620240810194825.azurewebsites.net/api/telemetry/GetSavingsByClient?clientId=12345&startDate=2024-08-01&endDate=2024-08-10`
- **Description**: Retrieves savings filtered by Client ID and date range
- **Action**: Click "Send".

## Additional Tips

- **Headers**: Add necessary headers, such as `Content-Type: application/json`.
- **Authentication**: If required, configure it in the "Authorization" tab.
- **Error Handling**: Check error messages or status codes for troubleshooting.

By following these steps, you can effectively interact with the API using Postman.**Data will be shown if only it is in the database hosted on azure.**
     

## Reference List

1. Microsoft. (2023). Microsoft Azure Documentation. Available at: https://learn.microsoft.com/en-us/azure/ [Accessed 8 Aug. 2024].
2. Microsoft. (2023). ASP.NET Core Documentation. Available at: https://learn.microsoft.com/en-us/aspnet/core/ [Accessed 7 Aug. 2024].
3. W3Schools. (2023). SQL Tutorial. Available at: https://www.w3schools.com/sql/ [Accessed 8 Aug. 2024].
4. Microsoft Learn. (2024). Use Identity to secure a Web API backend for SPAs. Microsoft Learn. https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity-api-authorization?view=aspnetcore-8.0&viewFallbackFrom=aspnetcore-8.0%2F%2Fwrite  [Accessed 11 Aug. 2024].
5. Saseendran, S. (2023). Authentication And Authorization In ASP.NET Core Web API With JSON Web Tokens. C# Corner. https://www.c-sharpcorner.com/article/authentication-and-authorization-in-asp-net-core-web-api-with-json-web-tokens/  [Accessed 11 Aug. 2024].
