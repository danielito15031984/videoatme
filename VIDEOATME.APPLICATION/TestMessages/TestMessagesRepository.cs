namespace VIDEOATME.APPLICATION.TestMessages
{
    public class TestMessagesRepository : ITestMessagesRepository
    {
        public async Task<ICollection<string>> GetTestMessages()
        {
            return await Task.FromResult(new List<string>() { "Daniel", "Daniel Jr", "Deiwing", "Milo"});
        }
    }
}
