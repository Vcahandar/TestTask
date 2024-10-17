using JobTask.Models;
using JobTask.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobTask.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MessageController : ControllerBase
	{
		private readonly MessageProcessingService _messageProcessingService;

		public MessageController(MessageProcessingService messageProcessingService)
		{
			_messageProcessingService = messageProcessingService;
		}

		[HttpPost("type1")]
		public async Task<IActionResult> ReceiveType1Message([FromBody] MessageModel message)
		{
			if (message.MessageType != "Type1")
			{
				return BadRequest("Invalid message type");

			}

			await _messageProcessingService.ProcessMessageAsync(message);
			return Ok(new { Status = "Type1 message success" });
		}

		[HttpPost("type2")]
		public async Task<IActionResult> ReceiveType2Message([FromBody] MessageModel message)
		{
			if (message.MessageType != "Type2")
			{
				return BadRequest("Invalid message type");
			}

			await _messageProcessingService.ProcessMessageAsync(message);
			return Ok(new { Status = "Type2 message success" });
		}
	}
}
