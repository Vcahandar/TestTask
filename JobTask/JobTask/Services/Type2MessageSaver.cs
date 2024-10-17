using JobTask.Data;
using JobTask.Models;

namespace JobTask.Services
{
	public class Type2MessageSaver : IMessageSaver
	{
		private readonly AppDbContext _context;

		public Type2MessageSaver(AppDbContext context)
		{
			_context = context;
		}

		public async Task SaveMessageAsync(MessageModel message)
		{
			var type2Message = new Type2Entity
			{
				Data = message.Data,
				CreatedAt = DateTime.UtcNow
			};
			_context.Type2Table.Add(type2Message);
			await _context.SaveChangesAsync();
		}
	}
}
