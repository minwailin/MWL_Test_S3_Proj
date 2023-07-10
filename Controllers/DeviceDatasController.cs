using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MWL_Test_S3_Proj.Data;
using MWL_Test_S3_Proj.Model;
using MWL_Test_S3_Proj.ViewModel;
using System.Text.RegularExpressions;

namespace MWL_Test_S3_Proj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceDatasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<DeviceDatasController> _logger;
        public DeviceDatasController(ApplicationDbContext context , ILogger<DeviceDatasController> logger)
        {
            _context = context;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult GetDatas()
        {
            _logger.LogInformation("Executing Get action...");
            return Ok(_context.deviceDatas.ToList());
        }

        [HttpPost("AddDeviceData")]
        public async Task<IActionResult> AddOperatorDetail(DeviceDataVM deviceDataVM)
        {
            _logger.LogInformation("Executing Post action to add DeviceData. and ID_"+deviceDataVM.DeviceId);
            try
            {
                var DData = new DeviceData()
                {
                    DeviceId = deviceDataVM.DeviceId,
                    DeviceType = deviceDataVM.DeviceType,
                    DeviceName = deviceDataVM.DeviceName,
                    GroupId = deviceDataVM.GroupId,
                    DataType = deviceDataVM.DataType,
                    Temperature = deviceDataVM.Data.Temperature,
                    Humidity = deviceDataVM.Data.Humidity,
                    Occupancy = deviceDataVM.Data.Occupancy,
                    Timestamp = deviceDataVM.Timestamp
                };

                _context.deviceDatas.Add(DData);
                await _context.SaveChangesAsync();
                return Ok();
                _logger.LogInformation("Success Post action to add DeviceData and ID_"+deviceDataVM.DeviceId);
            }
            catch (Exception ex)
            {
                return BadRequest("An error occurred while adding the device data. Error: " + ex.Message);
                _logger.LogError(" Post action to add DeviceData has error "+ex.Message);
            }
        }
    }
}
