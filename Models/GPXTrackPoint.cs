using System;
namespace StravaGPXReaderLib.Models
{
    /// <summary>
    /// Class that define the longitude and latitude properties with additional opttional details.
    /// </summary>
    public class GPXTrackPoint
    {
        public GPXTrackPoint(GPXCoordinates coordinates, DateTime timestamp, double? elevation = null, int? heartrate = null)
        {
            Coordinates = coordinates;
            Timestamp = timestamp;
            Elevation = elevation;
            HeartRate = heartrate;
        }

        public GPXCoordinates Coordinates { get; set; }
        public DateTime? Timestamp { get; set; }
        // Elevation is assumed to be in meters
        public Double? Elevation { get; set; }
        public int? HeartRate { get; set; }
    }
}
