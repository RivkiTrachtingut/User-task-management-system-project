using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_DP.Interface;

namespace Project_DP.Class;

class DoneState : IStatus
{
    public DoneState(Task status) : base(status) { }
    override public void ChangeState()
    {
        _status.Emit("the task is Finished");
    }
}
