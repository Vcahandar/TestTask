using JobTask.Models;

namespace JobTask.Services
{

	public class MessageProcessingService
	{
		private readonly MessageSaverFactory _messageSaverFactory;

		public MessageProcessingService(MessageSaverFactory messageSaverFactory)
		{
			_messageSaverFactory = messageSaverFactory;
		}

		public async Task ProcessMessageAsync(MessageModel message)
		{
			var messageSaver = _messageSaverFactory.CreateMessageSaver(message.MessageType);
			await messageSaver.SaveMessageAsync(message);
		}
	}


}
