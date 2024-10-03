
# OpenWeather

## Overview

**OpenWeather** is a weather forecasting web application that fetches real-time weather data from the OpenWeather API. It provides detailed weather information such as temperature, humidity, and weather conditions for cities across the globe.

This project is built using .NET Core, Blazor, and consumes the OpenWeather API to offer accurate weather insights in a clean and user-friendly interface.

---

## Features

- **Real-time Weather Data**: Get up-to-date weather information for any city.
- **API Integration**: Consumes OpenWeather API to provide accurate weather forecasting.
- **User-Friendly Interface**: Simple and intuitive interface for ease of use.
- **Responsive Design**: Works across devices, including desktops and mobiles.
- **Error Handling**: Displays helpful error messages for API and network issues.
- **Unit Conversion**: Displays temperature in Celsius.

---

## Table of Contents

- [Installation](#installation)
- [Usage](#usage)
- [Technologies Used](#technologies-used)
- [API Details](#api-details)
- [Code Structure](#code-structure)
- [Contributing](#contributing)
- [License](#license)

---

## Installation

To get started with the **OpenWeather** application on your local machine, follow these steps:

1. Clone the repository:
   ```bash
   git clone https://github.com/Divith123/OpenWeather.git
   ```
   
2. Navigate into the project directory:
   ```bash
   cd OpenWeather
   ```

3. Restore the required dependencies:
   ```bash
   dotnet restore
   ```

4. Build the project:
   ```bash
   dotnet build
   ```

5. Run the application:
   ```bash
   dotnet run
   ```

6. Open a browser and navigate to the following URL:
   ```
   https://localhost:5001
   ```

---

## Usage

Once you have the application running, you can view weather data by entering the name of any city. The application will display:

- City name
- Current temperature
- Weather description (e.g., clear sky, cloudy)
- Humidity percentage
- Wind speed

---

## Technologies Used

This project leverages the following technologies and libraries:

- **.NET Core 8.0**: Framework for building the web application.
- **Blazor WebAssembly**: For building interactive web UIs using C# instead of JavaScript.
- **OpenWeather API**: Provides real-time weather data.
- **C#**: Main programming language used.
- **HTTP Client**: To fetch data from external APIs.
- **Bootstrap 5**: For responsive and mobile-first design.

---

## API Details

The application uses the [OpenWeather API](https://openweathermap.org/api) to fetch current weather data.

- **Base URL**: `https://api.openweathermap.org/data/2.5/weather`
- **Request Method**: GET
- **Parameters**:
  - `q`: The city name (e.g., London).
  - `appid`: The API key for authentication.
  - `units`: Units of measurement. This project uses the metric system (`units=metric`).

For more detailed documentation on the API, visit the [OpenWeather API Documentation](https://openweathermap.org/current).

---

## Code Structure

Below is the structure of the major components in the project:

```
OpenClimate/
│
├── Pages/
│   ├── Weather.razor          # Main page displaying weather information
│   ├── Weather.razor.cs       # Code-behind file for API handling and data binding
│
├── wwwroot/
│   ├── css/                   # Static CSS files
│   ├── js/                    # Static JavaScript files (if applicable)
│   ├── service-worker.js      # Service worker for offline capability
│
├── App.razor                  # Main app entry point
├── Program.cs                 # Configures services and HTTP client
├── OpenClimate.csproj         # Project configuration file
└── README.md                  # Project documentation (you're reading it now)
```

---

## Contributing

Contributions to **OpenWeather** are welcome and encouraged! To contribute:

1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature/new-feature
   ```
3. Make your changes and commit them:
   ```bash
   git commit -m "Add new feature"
   ```
4. Push the changes to your fork:
   ```bash
   git push origin feature/new-feature
   ```
5. Create a pull request from your branch to the main repository.

Make sure your code follows the project's coding conventions and is properly documented.

---

## License

This project is licensed under the **MIT License**. See the [LICENSE](https://github.com/Divith123/OpenWeather/blob/main/LICENSE) file for more details.

---

## Contact

For any queries or issues related to this project, feel free to reach out to the repository owner via [GitHub](https://github.com/Divith123).

---

By following this guide, you should be able to set up, run, and even contribute to the OpenWeather project with ease.

