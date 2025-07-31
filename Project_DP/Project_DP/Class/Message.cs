using Project_DP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DP.Class;

public class Message : IMessage
{
    //singleton
    private static IMessage message=null;
    public IMessage _message
    {
        get
        {
            if (message == null)
                message = new Message();
            return message;

        }
    }
    public void notify(string meesage)
    {
        Console.WriteLine(meesage);
    }
}
