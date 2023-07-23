using DigiKala.WebAPI._03.Shared.Utils.HangFire;
using Hangfire;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DigiKala.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public HangfireConfig _hangfire { get; }

        public ValuesController(HangfireConfig hangfire)
        {
            _hangfire = hangfire;
        }


        [HttpGet("test")]
        public IActionResult getHangfire()
        {
            _hangfire.AddOrUpdate("ss", () => Console.WriteLine("sad"), Cron.Minutely());
            return Ok();
        }
    }
}
