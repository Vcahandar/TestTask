using JobTask.Models;

namespace JobTask.Services
{
	public interface IMessageSaver
	{
		Task SaveMessageAsync(MessageModel message);
	}

}
