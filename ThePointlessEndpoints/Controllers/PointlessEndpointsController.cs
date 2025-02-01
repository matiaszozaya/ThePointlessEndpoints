using Microsoft.AspNetCore.Mvc;

namespace ThePointlessEndpoints.Controllers
{
	[ApiController]
	public class PointlessEndpointsController : ControllerBase
	{
		[HttpGet("compareBooleans")]
		public IActionResult CompareBooleans([FromQuery] bool first, [FromQuery] bool second)
		{
			if (first == second)
				return Ok("They are equally pointless.");
			return Ok(first ? "First is bettter!" : "Second wins!");
		}

		[HttpGet("currentYear")]
		public IActionResult GetCurrentYear()
		{
			return Ok(DateTime.Now.Year);
		}

		[HttpGet("isEven")]
		public IActionResult IsEven([FromQuery] int number)
		{
			return Ok(number % 2 == 0 ? "Yes, it's even. Hooray!" : "Nope, it's odd. Deal with it.");
		}

		[HttpGet("echo")]
		public IActionResult Echo([FromQuery] string message)
		{
			return Ok(message ?? "You forgot to say something!");
		}

		[HttpGet("divideByZero")]
		public IActionResult DivideByZero([FromQuery] int number)
		{
			return BadRequest("Whoa there, buddy! Do you want to break reality?");
		}

		[HttpGet("yell")]
		public IActionResult Yell([FromQuery] string message)
		{
			return Ok((message ?? "You forgot to say something!").ToUpper());
		}

		[HttpGet("meaningOfLife")]
		public IActionResult MeaningOfLife()
		{
			return Ok(42);
		}

		[HttpGet("whyAreWeHere")]
		public IActionResult WhyAreWeHere()
		{
			return Ok("To call pointless APIs, apparently.");
		}

		[HttpGet("weatherToday")]
		public IActionResult WeatherToday()
		{
			return Ok("Look outside.");
		}
	}
}