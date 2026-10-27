# Service Controller

A Windows Forms control panel for viewing and controlling Windows
services.

## What it does

- Lists every installed service with its display name, real service
  name and type.
- Starts or stops the selected service.
- Refreshes the list on demand.

## Tech

- Visual Basic .NET (Windows Forms)
- `System.ServiceProcess.ServiceController`

## Building

Open the `.sln` file in Visual Studio and build it. The project was
upgraded to the Visual Studio 2005 format (.NET Framework 2.0) and targets
Windows only.

The solution file is `Service Control.sln`.

## License

Licensed under the Apache License 2.0. See [LICENSE](LICENSE).
