using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIDEOATME.APPLICATION.TestMessages
{
    public interface ITestMessagesRepository
    {
        Task<ICollection<string>> GetTestMessages();
    }
}
