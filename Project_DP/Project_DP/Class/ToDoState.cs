
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Project_DP.Class;

class ToDoState : IStatus
{
    public ToDoState(Task status) : base(status) { }
    override public void ChangeState()
    {

        _status.ChangeStatus(new InProgressState(_status));

        _status.Emit("The status has moved to the InProgressState ");

    }

}