using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_DP.Enum;
using Project_DP.Interface;

namespace Project_DP.Class;

class CodeReviewState : IStatus
{
    public CodeReviewState(Task status) : base(status) { }

    override public void ChangeState()
    {
        if (_status.Reporter.roles == Roles.Manager)
        {
            _status.ChangeStatus(new QAState(_status));
            _status.Emit("The status has moved to the QAState ");
        }
        else
        {
            _status.Emit("you cant do this... ");
        }

    }


}
