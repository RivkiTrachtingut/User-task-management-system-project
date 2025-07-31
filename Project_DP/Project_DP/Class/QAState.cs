using Project_DP.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DP.Class;

class QAState : IStatus
{
    public QAState(Task status) : base(status) { }
    override public void ChangeState()
    {

        if (_status.Reporter.roles == Roles.QA)
        {
            _status.ChangeStatus(new DoneState(_status));
            _status.Emit("The status has moved to the DoneState ");
        }
        else
        {

            _status.Emit("you cant do this  ...");
        }

    }


    //public QAState(Task status) : base(status) { }

    //public override void ChangeState(Role userRole)
    //{
    //    if (userRole == Role.QA)
    //    {
    //        _status.ChangeStatus(new DoneState(_status));
    //    }
    //    else
    //    {
    //        base.ChangeState(userRole); // Pass to the next handler
    //    }
    //}
}
