# WifiSurvey

> Professional WiFi site survey tool for IT professionals and network engineers

[![Download WifiSurvey](https://img.shields.io/badge/Download-Latest%20Release-blue?style=for-the-badge&logo=windows)](https://github.com/azullus/WifiSurvey/releases/latest)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)
[![.NET](https://img.shields.io/badge/.NET-8.0-purple)](https://dotnet.microsoft.com/)
[![Platform](https://img.shields.io/badge/Platform-Windows%2010%2F11-blue)](https://www.microsoft.com/windows)

---

## Overview

WifiSurvey is a .NET 8 Windows Forms application for conducting professional WiFi site surveys. Generate heatmaps, track signal strength, integrate floor plans, and export comprehensive coverage data.

**Perfect for:**
- IT professionals deploying wireless networks
- Network engineers optimizing WiFi coverage
- Facilities managers planning office layouts
- MSPs providing WiFi assessment services

---

## Features

### WiFi Scanning & Analysis
- ✅ Real-time WiFi network detection
- ✅ Signal strength monitoring (RSSI in dBm)
- ✅ Network details (SSID, BSSID, channel, security)
- ✅ Multi-band support (2.4 GHz and 5 GHz)

### Site Survey Tools
- 🗺️ Floor plan integration (PNG, JPG, BMP)
- 📍 Click-to-place measurement points
- 🌡️ Heatmap visualization with color-coded coverage
- 📊 Coverage statistics (Excellent/Good/Fair/Weak/Poor)

### Data Management
- 💾 Project save/load (JSON format)
- 📤 CSV export for analysis
- 🖼️ Embedded floor plans in project files
- 🔄 Auto-save support

### Professional Features
- 🎯 Target SSID filtering
- 📈 Signal quality metrics
- 📡 Channel analysis
- 📋 Comprehensive statistics

---

## Quick Start

### Download Pre-built Installer

[![Download WifiSurvey v1.0.0](https://img.shields.io/badge/Download-v1.0.0%20(64%20MB)-blue?style=for-the-badge&logo=windows)](https://github.com/azullus/WifiSurvey/releases/download/v1.0.0/WifiSurvey-v1.0.0-win-x64.zip)

**Latest Release:** v1.0.0
**Platform:** Windows 10/11 64-bit
**Size:** 64 MB (self-contained, no .NET required)

### Installation

#### Method 1: Automated Installation (Recommended)
```batch
1. Extract WifiSurvey-v1.0.0-win-x64.zip
2. Right-click Install.bat → Run as administrator
3. Launch from Start Menu or Desktop shortcut
```

#### Method 2: Portable Mode
```batch
1. Extract WifiSurvey-v1.0.0-win-x64.zip
2. Right-click WifiSurvey.exe → Run as administrator
3. No installation required
```

⚠️ **Administrator privileges required** for WiFi adapter access

### First Site Survey

1. **Launch WifiSurvey** (as administrator)
2. **Load floor plan** → File → Open Floor Plan
3. **Click on floor plan** to place measurement points
4. **View heatmap** → Generate coverage visualization
5. **Save project** → File → Save Survey
6. **Export data** → File → Export to CSV

---

## System Requirements

### Minimum
- **OS:** Windows 10 64-bit (1809+) or Windows 11
- **RAM:** 2 GB
- **Disk:** 100 MB
- **WiFi:** Wireless network adapter
- **Privileges:** Administrator rights required

### Recommended
- **OS:** Windows 11 64-bit
- **RAM:** 4 GB
- **WiFi:** Dual-band adapter (2.4/5 GHz)

---

## Why Administrator Privileges?

WifiSurvey uses the Windows Native WiFi API (`wlanapi.dll`) which requires elevated permissions to:
- Enumerate wireless network adapters
- Scan for available WiFi networks
- Read signal strength and network properties
- Access BSSID and channel information

**Workaround:** Configure shortcut to always run elevated:
1. Right-click shortcut → Properties
2. Advanced → Check "Run as administrator"
3. Apply → OK

---

## Documentation

- **README.txt** - Full application guide
- **QUICKSTART.txt** - Step-by-step tutorial
- **RELEASE-NOTES.txt** - Version changelog
- **[Issue Tracker](https://github.com/azullus/WifiSurvey/issues)** - Report bugs or request features

---

## Use Cases

### Office WiFi Deployment
Plan access point placement before installation. Import office floor plan, conduct survey, generate heatmap showing optimal AP locations.

### Coverage Verification
Validate WiFi coverage after deployment. Document signal strength across all areas, identify dead zones, export data for client reports.

### Troubleshooting
Diagnose connectivity issues. Measure signal strength in problem areas, identify channel interference, analyze network congestion.

### Network Optimization
Optimize existing WiFi networks. Compare before/after measurements, adjust AP placement, fine-tune channel assignments.

---

## Technical Specifications

### Architecture
- **Framework:** .NET 8.0 Windows Forms
- **Deployment:** Self-contained single-file
- **Platform:** Windows x64
- **WiFi API:** Windows Native WiFi (wlanapi.dll)

### Performance
- **Memory:** < 150 MB typical usage
- **CPU:** < 5% during scanning
- **Startup:** < 2 seconds
- **Scan interval:** 1-2 seconds per refresh

### File Formats
- **Projects:** JSON (.wifisurvey)
- **Export:** CSV (comma-separated values)
- **Floor plans:** PNG, JPG, BMP

---

## Building from Source

WifiSurvey source code is available in this repository. Also available in the [cosmicbytez-ops-toolkit](https://github.com/azullus/cosmicbytez-ops-toolkit) monorepo.

### Prerequisites
- .NET 8.0 SDK
- Visual Studio 2022 or JetBrains Rider
- Windows 10/11 development machine

### Build Commands
```bash
# Clone this repository
git clone https://github.com/azullus/WifiSurvey.git
cd WifiSurvey

# Restore dependencies
dotnet restore WifiSurvey.csproj

# Build Release
dotnet build WifiSurvey.csproj --configuration Release

# Run tests
dotnet test WifiSurvey.Tests/WifiSurvey.Tests.csproj

# Publish self-contained executable
dotnet publish WifiSurvey.csproj \
  --configuration Release \
  --runtime win-x64 \
  --self-contained true \
  -p:PublishSingleFile=true
```

---

## Troubleshooting

### "No WiFi adapters found"
- **Cause:** No wireless adapter detected or running without admin rights
- **Solution:** Right-click → Run as administrator

### "Access denied" error
- **Cause:** Insufficient privileges to access WiFi API
- **Solution:** Right-click → Run as administrator

### Heatmap not generating
- **Cause:** No floor plan loaded or no measurement points placed
- **Solution:** File → Open Floor Plan, then click on plan to add measurements

### Signal strength shows 0 dBm
- **Cause:** WiFi adapter not active or in airplane mode
- **Solution:** Enable WiFi adapter in Windows settings

### Application crashes on startup
- **Cause:** Windows version too old (pre-1809)
- **Solution:** Update to Windows 10 1809 or later

---

## FAQ

**Q: Does WifiSurvey work on macOS or Linux?**
A: No, WifiSurvey uses Windows Native WiFi API (wlanapi.dll) which is Windows-only.

**Q: Can I use WifiSurvey without installing .NET?**
A: Yes! The installer includes .NET 8.0 runtime (self-contained deployment).

**Q: Can I save my survey projects?**
A: Yes, File → Save Survey creates a .wifisurvey JSON file with all measurements and embedded floor plan.

**Q: Can I export data to Excel?**
A: Export to CSV, which Excel can open directly (File → Export to CSV).

**Q: Does WifiSurvey capture WiFi packets?**
A: No, WifiSurvey performs signal surveys only (RSSI measurements). It does not capture packets.

**Q: Can I survey multiple floors?**
A: Create separate survey projects for each floor, each with its own floor plan.

**Q: Is administrator access always required?**
A: Yes, Windows WiFi APIs require elevation. This is a Windows security requirement.

---

## Related Projects

- **[CosmicPing](https://github.com/azullus/CosmicPing)** - Network ping utility with real-time latency charting and packet loss tracking
- **[cosmicbytez-ops-toolkit](https://github.com/azullus/cosmicbytez-ops-toolkit)** - Complete IT operations toolkit with PowerShell automation and C# utilities

---

## Support & Feedback

**Found a bug?** [Report an issue](https://github.com/azullus/WifiSurvey/issues/new)
**Feature request?** [Submit an idea](https://github.com/azullus/WifiSurvey/issues/new)
**Questions?** Check documentation or open a discussion

---

## License

WifiSurvey is released under the **MIT License**

Copyright (c) 2026 CosmicBytez IT Operations

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

---

## Credits

**Developed by:** CosmicBytez IT Operations Team
**Built with:** .NET 8, C#, Windows Forms
**Special thanks:** Open source community, .NET development team

---

**⭐ Star this repository if you find WifiSurvey useful!**

**📢 Share with your network engineering colleagues!**
