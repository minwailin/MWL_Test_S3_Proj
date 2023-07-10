using System.ComponentModel.DataAnnotations;

namespace MWL_Test_S3_Proj.Model
{
    public class DeviceData
    {
        [Key]
        public string DeviceId { get; set; }
        public string DeviceType { get; set; }
        public string DeviceName { get; set; }
        public string GroupId { get; set; }
        public string DataType { get; set; }
        public int? Temperature { get; set; }
        public int? Humidity { get; set; }
        public bool? Occupancy { get; set; }
        public long Timestamp { get; set; }

        //
    }
}
