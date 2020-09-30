using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            commandsContainer.Visible = false;
            graphPanel.Visible = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var location = locationTextBox.Text;
            if (locationTextBox.Text == String.Empty) return;

            var locationWoeid = getLocation(location);
            if (locationWoeid == null) return;

            var forecast = getForecast(locationWoeid.Value);
            uiManagement(forecast);
        }

        private long? getLocation(string location)
        {
            var result = API.Weather.GetLocationWoeid(location);
            if (result.Count() > 0)
            {
                if (result.Count() > 1)
                {
                    MessageBox.Show($"Many locations found! In this version I will pick the first one: {result.FirstOrDefault().Title}");
                }
                
                return result.FirstOrDefault().Woeid;
            }
            MessageBox.Show("Location not found! Please try another one");
            return null;
        }

        private ForecastResponse.Weather getForecast(long woeid)
        {
            return API.Weather.GetForecast(woeid);
        }

        private void uiManagement(ForecastResponse.Weather forecast)
        {
            commandsContainer.Visible = true;

            // Forecast tab
            renderForecast(forecast);

            // Graph tab
            renderGraph(forecast);
        }

        private void renderForecast(ForecastResponse.Weather forecast)
        {
            locationLabel.Text = $"{forecast.Title}, {forecast.Parent.Title}, {forecast.LattLong}";
            currentWeatherLabel.Text = forecast.ConsolidatedWeather.First().WeatherStateName;
            currentWindLabel.Text = $"Wind: {forecast.ConsolidatedWeather.First().WindSpeed.ToString("0.##")} mph";
            humidityLabel.Text = $"Humidity: {forecast.ConsolidatedWeather.First().Humidity.ToString("0.##")} %";
            pressureLabel.Text = $"Pressure: {forecast.ConsolidatedWeather.First().AirPressure.ToString("0.##")} bar";
            currentTemp.Text = $"{forecast.ConsolidatedWeather.First().TheTemp.ToString("0")}°C";
            currentWeatherImage.ImageLocation = API.Weather.GetImageURL(forecast.ConsolidatedWeather.First().WeatherStateAbbr);

            day1Label.Text = forecast.ConsolidatedWeather[1].ApplicableDate.ToString("MM/dd/yyyy");
            day1TempLabel.Text = forecast.ConsolidatedWeather[1].TheTemp.ToString("0");
            day1WeatherImage.ImageLocation = API.Weather.GetImageURL(forecast.ConsolidatedWeather[1].WeatherStateAbbr);

            day2Label.Text = forecast.ConsolidatedWeather[2].ApplicableDate.ToString("MM/dd/yyyy");
            day2TempLabel.Text = forecast.ConsolidatedWeather[2].TheTemp.ToString("0");
            day2WeatherImage.ImageLocation = API.Weather.GetImageURL(forecast.ConsolidatedWeather[2].WeatherStateAbbr);

            day3Label.Text = forecast.ConsolidatedWeather[3].ApplicableDate.ToString("MM/dd/yyyy");
            day3TempLabel.Text = forecast.ConsolidatedWeather[3].TheTemp.ToString("0");
            day3WeatherImage.ImageLocation = API.Weather.GetImageURL(forecast.ConsolidatedWeather[3].WeatherStateAbbr);

            day4Label.Text = forecast.ConsolidatedWeather[4].ApplicableDate.ToString("MM/dd/yyyy");
            day4TempLabel.Text = forecast.ConsolidatedWeather[4].TheTemp.ToString("0");
            day4WeatherImage.ImageLocation = API.Weather.GetImageURL(forecast.ConsolidatedWeather[4].WeatherStateAbbr);

            day5Label.Text = forecast.ConsolidatedWeather[5].ApplicableDate.ToString("MM/dd/yyyy");
            day5TempLabel.Text = forecast.ConsolidatedWeather[5].TheTemp.ToString("0");
            day5WeatherImage.ImageLocation = API.Weather.GetImageURL(forecast.ConsolidatedWeather[5].WeatherStateAbbr);
        }

        private void renderGraph(ForecastResponse.Weather forecast)
        {
            var canvas = new Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.Canvas();
            var datapoint = new Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.DataPoint(Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced._type.Bunifu_rangeColumn);


            foreach (var item in forecast.ConsolidatedWeather)
            {
                datapoint.addLabely(item.ApplicableDate.Date.ToString("MM/dd/yyyy"), 
                    new JArray(item.MinTemp,
                               item.MaxTemp));
            }
            canvas.addData(datapoint);
            datavizForecastGraph.Render(canvas);

        }

        private void forecastButton_Click(object sender, EventArgs e)
        {
            graphPanel.Visible = false;
            mainPanel.Visible = true;
        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            graphPanel.Visible = true;
            mainPanel.Visible = false;
        }
    }
}
