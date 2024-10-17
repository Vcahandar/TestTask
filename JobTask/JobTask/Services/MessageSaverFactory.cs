namespace JobTask.Services
{
	public class MessageSaverFactory
	{
		private readonly IServiceProvider _serviceProvider;

		public MessageSaverFactory(IServiceProvider serviceProvider)
		{
			_serviceProvider = serviceProvider;
		}

		public IMessageSaver CreateMessageSaver(string messageType)
		{
			return messageType switch
			{
				"Type1" => _serviceProvider.GetService<Type1MessageSaver>(),
				"Type2" => _serviceProvider.GetService<Type2MessageSaver>(),
				_ => throw new ArgumentException("Unknown message type")
			};
		}
	}

}
