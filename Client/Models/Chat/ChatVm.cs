using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Models.Chat
{
    public class ChatVm
    {
        public string UserName { get; set; }
        public string UserMessage { get; set; }

        public List<UserChat> Chat { get; set; }
    }

    public class UserChat
    {
        public string Name { get; set; }
        public string Message { get; set; }

    }
}
