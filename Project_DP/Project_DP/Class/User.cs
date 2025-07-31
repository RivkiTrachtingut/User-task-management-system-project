using Project_DP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DP.Class;

public class User : IMessageUser
{
    
    public string email { get; set; }
    public string name { get; set; }
    public Enum.Roles roles { get; set; }
    public IMessage message { get; }
    public User(string email, string name, Enum.Roles roles, IMessage? message)
    {
        this.email = email;
        this.name = name;
        this.roles = roles;
        this.message = message;
    }

    public void GetEvent(string mesage)
    {
        message.notify($"{roles} {name} got event: {mesage}");
    }
}

