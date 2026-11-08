# InventoryApp

InventoryApp is a simple console application for managing inventory, built with .NET.

> **Status:** early development. Currently the app prints a greeting, the OS version and the app version.

## Requirements

- [.NET SDK 10.0](https://dotnet.microsoft.com/download) or later

## Getting Started

```bash
# Clone the repository
git clone <repository-url>
cd InventoryApp

# Restore dependencies
dotnet restore

# Build
dotnet build

# Run
dotnet run
```

## Project Structure

```
InventoryApp/
├── InventoryApp.csproj   # Project file (net10.0, console app)
├── Program.cs            # Application entry point
└── src/                  # Application source code (to be added)
```

## Roadmap

- [ ] Define inventory item model
- [ ] Add, update and remove items
- [ ] List and search items
- [ ] Persist data (file or database)
- [ ] Unit tests

## License

To be defined.
