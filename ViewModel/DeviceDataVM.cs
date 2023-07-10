using MWL_Test_S3_Proj.Model;

namespace MWL_Test_S3_Proj.ViewModel
{
    public class DeviceDataVM
    {
        public string DeviceId { get; set; }
        public string DeviceType { get; set; }
        public string DeviceName { get; set; }
        public string GroupId { get; set; }
        public string DataType { get; set; }      
        public long Timestamp { get; set; }
        public Data_PayloadVM Data { get; set; }
    }
    public class Data_PayloadVM
    {
        public bool? FullPowerMode { get; set; }
        public bool? ActivePowerControl { get; set; }
        public int? FirmwareVersion { get; set; }
        public int? Temperature { get; set; }
        public int? Humidity { get; set; }
        public int? Version { get; set; }
        public string? MessageType { get; set; }
        public bool? Occupancy { get; set; }
        public int? StateChanged { get; set; }
    }
}
