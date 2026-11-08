# Crop Yield Tracker - Agric Seasons

A C# Windows Forms desktop application for recording, managing, and visualizing crop yields across different farming seasons.

This project was built to replace manual paper-based record keeping for farmers and agricultural officers. It allows a user to capture crop data, store it in a Microsoft Access database, and visualize average yields to compare performance across crops and seasons.

## Table of Contents
- [Features](#features)
- [How It Works](#how-it-works)
- [Database Structure](#database-structure)
- [Tech Stack](#tech-stack)
- [Project Structure](#project-structure)
- [Installation & Setup](#installation--setup)
- [How To Use](#how-to-use)
- [Visualization](#visualization)
- [Future Improvements](#future-improvements)
- [Author](#author)

## Features

- **Add New Crop Records:** Capture a new crop with its season details
- **Save Records:** Save records directly to the Microsoft Access database
- **Delete Records:** Remove incorrect or outdated records
- **View All Records:** View all saved records in a DataGridView table
- **Data Binding:** Form fields are automatically bound to the database
- **Visualize Data:** Generate a chart to compare average yield per crop / season
- **Offline Desktop App:** No internet required, runs fully on Windows

## How It Works

1. The user opens the application and sees `Form1` with input fields on the left and a data table on the right.
2. The user clicks **Add New**, fills in the crop details, and clicks **Save**.
3. The data is written to the `seasons` table in `agric.accdb`.
4. The table on the right refreshes to show the new record.
5. The user clicks **Visualize** to see a chart of average yield.

## Database Structure

**Database File:** `agric.accdb` (Microsoft Access)
**Table:** `seasons`

| Field Name | Type | Description |
| :--- | :--- | :--- |
| `cropid` | Number / AutoNumber | Unique ID for each crop record |
| `crop_name` | Short Text | Name of the crop e.g. Maize, Wheat, Soyabean |
| `period_type` | Short Text | Type of period e.g. Season, Year, Quarter |
| `period_number` | Number | Period number e.g. Season 1, 2, 3 |
| `average_yield` | Number | Average yield recorded for that crop in that period |

The application uses a Typed DataSet (`agricDataSet.xsd`) to connect the Windows Form to the Access database.

## Tech Stack

- **Language:** C# (.NET Framework)
- **UI Framework:** Windows Forms (WinForms)
- **IDE:** Visual Studio
- **Database:** Microsoft Access (.accdb)
- **Data Access:** ADO.NET / Typed DataSet
- **Charting:** System.Windows.Forms.DataVisualization.Charting

## Project Structure


> **Note:** `bin/` and `obj/` folders are build outputs and should NOT be uploaded to GitHub. They are ignored via `.gitignore`.

## Installation & Setup

### Requirements
- Windows 10 / 11
- Visual Studio 2019 or later (with .NET desktop development workload)
- Microsoft Access Database Engine (for .accdb support)

### Steps
1. Clone the repository:
   ```bash
   git clone https://github.com/YOUR-USERNAME/crop-yield-tracker.git


Author - Commence Goredema