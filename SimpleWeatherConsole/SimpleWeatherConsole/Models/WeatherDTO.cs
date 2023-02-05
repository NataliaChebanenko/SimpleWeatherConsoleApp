using System;
using System.Text.Json.Serialization;

namespace SimpleWeatherConsole.Models
{
    public class Datum
    {
        [JsonPropertyName("app_temp")]
        public double AppTemp { get; set; }

        [JsonPropertyName("aqi")]
        public int Aqi { get; set; }

        [JsonPropertyName("city_name")]
        public string CityName { get; set; }

        [JsonPropertyName("clouds")]
        public int Clouds { get; set; }

        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        [JsonPropertyName("datetime")]
        public string Datetime { get; set; }

        [JsonPropertyName("dewpt")]
        public double Dewpt { get; set; }

        [JsonPropertyName("dhi")]
        public double Dhi { get; set; }

        [JsonPropertyName("dni")]
        public double Dni { get; set; }

        [JsonPropertyName("elev_angle")]
        public double ElevAngle { get; set; }

        [JsonPropertyName("ghi")]
        public double Ghi { get; set; }

        [JsonPropertyName("gust")]
        public double Gust { get; set; }

        [JsonPropertyName("h_angle")]
        public double HAngle { get; set; }

        [JsonPropertyName("lat")]
        public double Lat { get; set; }

        [JsonPropertyName("lon")]
        public double Lon { get; set; }

        [JsonPropertyName("ob_time")]
        public string ObTime { get; set; }

        [JsonPropertyName("pod")]
        public string Pod { get; set; }

        [JsonPropertyName("precip")]
        public double Precip { get; set; }

        [JsonPropertyName("pres")]
        public double Pres { get; set; }

        [JsonPropertyName("rh")]
        public int Rh { get; set; }

        [JsonPropertyName("slp")]
        public double Slp { get; set; }

        [JsonPropertyName("snow")]
        public int Snow { get; set; }

        [JsonPropertyName("solar_rad")]
        public double SolarRad { get; set; }

        [JsonPropertyName("sources")]
        public List<string> Sources { get; set; }

        [JsonPropertyName("state_code")]
        public string StateCode { get; set; }

        [JsonPropertyName("station")]
        public string Station { get; set; }

        [JsonPropertyName("sunrise")]
        public string Sunrise { get; set; }

        [JsonPropertyName("sunset")]
        public string Sunset { get; set; }

        [JsonPropertyName("temp")]
        public double Temp { get; set; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonPropertyName("ts")]
        public int Ts { get; set; }

        [JsonPropertyName("uv")]
        public double Uv { get; set; }

        [JsonPropertyName("vis")]
        public int Vis { get; set; }

        [JsonPropertyName("weather")]
        public Weather Weather { get; set; }

        [JsonPropertyName("wind_cdir")]
        public string WindCdir { get; set; }

        [JsonPropertyName("wind_cdir_full")]
        public string WindCdirFull { get; set; }

        [JsonPropertyName("wind_dir")]
        public int WindDir { get; set; }

        [JsonPropertyName("wind_spd")]
        public double WindSpd { get; set; }
    }

    public class WeatherDTO
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("data")]
        public Datum[] Data { get; set; }
    }

    public class Weather
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    }

}

