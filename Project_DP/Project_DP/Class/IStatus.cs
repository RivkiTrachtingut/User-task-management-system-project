using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DP.Class;

public abstract class IStatus
{
    protected Task _status;

    protected IStatus(Task status)
    {
        _status = status;
    }

    abstract public void ChangeState();


}
