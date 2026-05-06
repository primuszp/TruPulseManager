# TruPulse Manager

A Windows desktop application for field data collection and management using the [Laser Technology TruPulse 360B](https://www.manualslib.com/products/Laser-Technology-Trupulse-360b-8935479.html) laser rangefinder. Developed by the **Institute of Geomatics and Civil Engineering, University of Sopron** for forestry road survey and terrain profiling workflows.

---

## Overview

TruPulse Manager connects to a TruPulse 360B device over a serial (RS-232/USB) port and automates the polar coordinate measurement workflow used in forest road surveys. The operator sets up a known station, measures target points with the laser rangefinder, and the application computes full 3D Cartesian coordinates in real time. Cross-sections can be defined and visualised on-screen, and all data can be exported for downstream processing.

---

## Features

| Category | Details |
|---|---|
| **Device connection** | Serial port configuration (baud rate, parity, stop bits, data bits), port auto-detection, live connection test |
| **Station setup** | Enter station coordinates (Easting, Northing, Elevation), instrument height; stored in the project |
| **Point measurement** | Slow (manual confirm) and Fast Store modes; automatic polar → Cartesian conversion; code and mark-height entry per point |
| **Cross-sections** | Define, insert and delete cross-sections; 2D elevation profile plotted with ZedGraph |
| **Map view** | Interactive 2D plan view with zoom in/out, zoom all, and pan |
| **Compass** | Real-time azimuth display from the TruPulse compass module |
| **Battery monitor** | Battery level indicator from device telemetry |
| **File I/O** | Native binary project files (`.trp`); plain-text import/export of point lists and station data |

---

## Coordinate Computation

The application uses the standard polar surveying formula:

```
HD  = SD · cos(α)
ΔZ  = hi − hr + SD · sin(α)

E_P = E_S + HD · sin(Az)
N_P = N_S + HD · cos(Az)
Z_P = Z_S + ΔZ
```

Where:

| Symbol | Meaning |
|---|---|
| SD | Slope Distance (measured by TruPulse, metres) |
| α | Vertical inclination angle (degrees, positive upward) |
| Az | Azimuth (degrees, 0° = North, 90° = East) |
| hi | Instrument height above station mark (metres) |
| hr | Target / reflector mark height (metres) |
| E_S, N_S, Z_S | Station coordinates |
| E_P, N_P, Z_P | Computed point coordinates |

Distance units received from the device (feet, yards, metres) are automatically converted to SI metres.

---

## Requirements

| Component | Minimum |
|---|---|
| OS | Windows 10 / 11 (x64) |
| Runtime | [.NET 8 Desktop Runtime](https://dotnet.microsoft.com/download/dotnet/8.0) |
| Hardware | TruPulse 360B connected via RS-232 serial port or USB-to-serial adapter |

---

## Building from Source

```bash
git clone https://github.com/your-org/TruPulseManager.git
cd TruPulseManager/source
dotnet build TruPulseManager.sln -c Release
```

The output binary is placed in:

```
source/TruPulseManager/bin/Release/net8.0-windows/TruPulseManager.exe
```

### NuGet dependencies

| Package | Purpose |
|---|---|
| `ZedGraph 5.1.7` | Cross-section elevation profile chart |
| `System.IO.Ports 9.0.5` | Serial port access on .NET 8 |

---

## Getting Started

1. Connect the TruPulse 360B to the PC via serial cable or USB adapter.
2. Launch `TruPulseManager.exe`.
3. Click **Serial Port** and select the correct COM port; click **Open** then **Test** to verify the connection.
4. Click **Station Setup** and enter the known station coordinates and instrument height.
5. Aim the TruPulse at a target and press **Measure** (or use a Fast Store button for rapid sequential shots).
6. Points appear immediately in the map view with computed coordinates.
7. Use **Cross Section** to assign points to a profile and view the 2D elevation graph.
8. Save the project via **File → Save** (`.trp` format) or export as tab-delimited text.

---

## Project File Format

Projects are saved as `.trp` binary files using .NET binary serialisation. The file stores:

- Project name and file path
- Station list with coordinates and instrument height
- All measured points with raw observations, computed coordinates, codes, timestamps and mark heights
- Cross-section definitions (section chainage and point index lists)
- Global settings (mark height, section delta, point ID counter)

---

## Device Reference

**Laser Technology TruPulse 360B**

- Range: up to 1000 m (reflectorless)
- Azimuth: 360° magnetic compass
- Inclination: ±90°
- Output: NMEA-style serial sentences at 4800–115200 baud
- Manual: [ManualsLib – TruPulse 360B](https://www.manualslib.com/products/Laser-Technology-Trupulse-360b-8935479.html)

The application parses `$PLTIT,HV,...` sentences containing horizontal distance, azimuth, inclination and slope distance fields.

---

## Repository Structure

```
source/
├── TruPulseManager.sln
└── TruPulseManager/
    ├── TruPulseManager.csproj   # SDK-style, net8.0-windows
    ├── Program.cs
    ├── Project.cs               # Project data model (static singleton)
    ├── Station.cs               # Survey station
    ├── MeasuredPoint.cs         # Observed point + coordinate calculation
    ├── HVMessage.cs             # TruPulse sentence parser
    ├── Vector.cs                # 3D vector math
    ├── CrossSection.cs          # Cross-section model
    ├── Interpreter.cs           # Serial sentence dispatcher
    ├── DrawingArea.cs           # 2D map canvas
    ├── FastStore.cs             # Rapid point storage panel
    ├── EditableBitmap.cs        # Bitmap drawing helper
    ├── forms/                   # WinForms UI
    └── TB/Instruments/          # SlidingScale control stub
```

---

## Developed by

**Institute of Geomatics and Civil Engineering**  
University of Sopron  
Sopron, Hungary  
[uni-sopron.hu](https://uni-sopron.hu)
