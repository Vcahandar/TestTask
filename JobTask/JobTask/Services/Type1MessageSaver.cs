using JobTask.Data;
using JobTask.Models;

namespace JobTask.Services
{
	public class Type1MessageSaver : IMessageSaver
	{
		private readonly AppDbContext _context;

		public Type1MessageSaver(AppDbContext context)
		{
			_context = context;
		}

		public async Task SaveMessageAsync(MessageModel message)
		{
			var type1Message = new Type1Entity
			{
				Data = message.Data,
				CreatedAt = DateTime.UtcNow
			};
			_context.Type1Table.Add(type1Message);
			await _context.SaveChangesAsync();
		}
	}
}
