
# NWU Tech Trends Telemetry Management API

## Overview

This project implements a CRUD RESTful API for managing telemetry data related to automation executions at NWU Tech Trends. The API allows users to track time savings associated with automation, grouped by project and client.

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

## Usage

- To log a new telemetry entry, send a POST request with the required data.
- Use GET requests to retrieve telemetry data for analysis.
- Update or delete entries as necessary using PATCH or DELETE requests.

## Contribution

Changes made will be shown regularly on the README

## License

This project is licensed under the MIT License. See the LICENSE file for more details.
