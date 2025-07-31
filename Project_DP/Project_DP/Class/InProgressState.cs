using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_DP.Interface;

namespace Project_DP.Class;

class InProgressState : IStatus
{
    public InProgressState(Task status) : base(status) { }
    override public void ChangeState()
    {
        _status.ChangeStatus(new CodeReviewState(_status));
        _status.Emit("The status has moved to the CodeReviewState ");
    }

}
