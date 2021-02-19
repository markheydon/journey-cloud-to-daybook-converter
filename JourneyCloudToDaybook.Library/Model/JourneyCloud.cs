using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JourneyCloudToDaybook.Library.Model
{
    public class Weather
    {
        [JsonPropertyName("place")]
        public string Place { get; set; }

        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("degree_c")]
        public int DegreeC { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

    public class JourneyCloud
    {
        [JsonPropertyName("photos")]
        public List<string> Photos { get; set; }

        [JsonPropertyName("lat")]
        public double Latitude { get; set; }

        [JsonPropertyName("music_title")]
        public string MusicTitle { get; set; }

        [JsonPropertyName("date_modified")]
        public long DateModified { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("weather")]
        public Weather Weather { get; set; }

        [JsonPropertyName("date_journal")]
        public long DateJournal { get; set; }

        [JsonPropertyName("preview_text")]
        public string PreviewText { get; set; }

        [JsonPropertyName("mood")]
        public int Mood { get; set; }

        [JsonPropertyName("sentiment")]
        public int Sentiment { get; set; }

        [JsonPropertyName("lon")]
        public double Longitude { get; set; }

        [JsonPropertyName("music_artist")]
        public string MusicArtist { get; set; }

        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("id")]
        public string ID { get; set; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonPropertyName("favourite")]
        public bool Favourite { get; set; }

        [JsonPropertyName("folder")]
        public string Folder { get; set; }
    }
}