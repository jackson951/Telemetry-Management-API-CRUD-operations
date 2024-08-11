
# NWU Tech Trends Telemetry Management API

## Overview

This project is designed to help NWU Tech Trends track and manage the time and cost savings achieved through automation solutions. By developing a CRUD RESTful API, the system will manage telemetry data, providing insights into savings grouped by project and client. This API will facilitate efficient data handling and reporting, ensuring stakeholders can easily access and analyze the impact of automation.


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

- Authentication is set up to restrict access.
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

1. **Access the API:**
   - Use a tool like Postman to send requests to the API endpoints.

2. **Interact with Telemetry Data:**
   - Retrieve data: Use GET requests to view telemetry entries.
   - Create data: Use POST requests to add new entries.
   - Update data: Use PATCH requests to modify entries.
   - Delete data: Use DELETE requests to remove entries.

3. **Analyze Savings:**
   - Use the `/GetSavingsByProject` and `/GetSavingsByClient` endpoints to generate reports.
     

## Reference List

1. Microsoft. (2023). Microsoft Azure Documentation. Available at: https://learn.microsoft.com/en-us/azure/ [Accessed 8 Aug. 2024].
2. Microsoft. (2023). ASP.NET Core Documentation. Available at: https://learn.microsoft.com/en-us/aspnet/core/ [Accessed 7 Aug. 2024].
3. W3Schools. (2023). SQL Tutorial. Available at: https://www.w3schools.com/sql/ [Accessed 8 Aug. 2024].
4. Microsoft Learn. (2024). Use Identity to secure a Web API backend for SPAs. Microsoft Learn. https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity-api-authorization?view=aspnetcore-8.0&viewFallbackFrom=aspnetcore-8.0%2F%2Fwrite
