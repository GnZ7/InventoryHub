# InventoryHub

## Prerequisites

- **.NET SDK 10**
If you don’t have the .NET SDK installed, you can download it from the official website:
https://dotnet.microsoft.com/download


## Configuration Notes
CORS is enabled in the API to allow requests from the Client.
Both the API and Client use the hardcoded localhost URLs declared in each appsettings.json, you may need to update them.

## How to Run the Project

This solution is composed of three projects:

- **InventoryHub.Api** – ASP.NET Core Web API (backend)
- **InventoryHub.Client** – Blazor WebAssembly (standalone frontend)
- **InventoryHub.Shared** – Shared entities

The API and the Client must be started **separately**.

This project automatically creates a local **SQLite** database, applies **Entity Framework Core migrations**, and seeds initial **products and categories** data.  
The seed data is defined in the `DbSeeder` class and runs automatically when the .Api project starts.
