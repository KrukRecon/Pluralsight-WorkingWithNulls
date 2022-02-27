using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSNullBasics
{
    public class MessagePopulator
    {
        public static void Populate(Message message)
        {
            message.GetType().InvokeMember("From",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.SetProperty,
                Type.DefaultBinder, message, new[] { "Jason (set using reflection)" });
        }
    }
}
