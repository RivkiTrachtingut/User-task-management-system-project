using Project_DP.Enum;
using Project_DP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project_DP.Class;

public class Task : ITask
{
    private Stack<Memento> taskHistory=new Stack<Memento>();
    public DateTime CreateDate { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    private User assigsnee;
    public User Assigsnee
    {
        get { return assigsnee; }
        set
        {
            assigsnee = value;
            messages.Add(value);
        }
    }
    private User reporter;
    public User Reporter
    {
        get { return reporter; }
        set
        {
            reporter = value;
            messages.Add(value);
            taskHistory.Push(CreateBackup());
        }
    }
    private IStatus status;
    public IStatus Status
    {
        get { return status; }
        set
        {
            status = value;
            taskHistory.Push(CreateBackup());
        }


    }
    private Enum.Priority priority;
    public Enum.Priority Priority
    {
        get { return priority; }
        set
        {
            priority = value;
            taskHistory.Push(CreateBackup());
        }
    }

    public float EstimationTime { get; set; }

    public float LoggedTime { get; set; }

    public List<Task> Tasks { get; set; }
    public Task()
    {

    }
    //state
    public void ChangeStatus(IStatus status)
    {
        this.Status = status;
    }


    //observer
    public List<IMessageUser> messages = new List<IMessageUser>();
    public void Subscribe(IMessageUser subscriber)
    {
        messages.Add(subscriber);
    }

    public void Emit(string eventData)
    {
        foreach (IMessageUser subscriber in messages)
        {
            subscriber.GetEvent(eventData);
        }
    }


    //compsite
    public float GetLoggedTime()
    {

        float sumTimeTask = 0;
        if (Tasks != null)
        {
            foreach (var taskTime in Tasks)
            {
                sumTimeTask += taskTime.LoggedTime;
            }
        }
        return LoggedTime + sumTimeTask;

    }
    public float GetEstimationTime()
    {

        float sumTimeTask = 0;
        if (Tasks != null)
        {
            foreach (var taskTime in Tasks)
            {
                sumTimeTask += taskTime.EstimationTime;
            }
        }
        return EstimationTime + sumTimeTask;

    }

    //memento
    public Memento CreateBackup()
    {
        return new Memento()
        {
            Status = this.Status,
            Priority = this.Priority,
            Reporter=this.Reporter,
        };
    }
  
    public void Undo()
    {
        if (taskHistory.Count > 0)
        {
            Memento lastMemento = taskHistory.Pop();
            Console.WriteLine($"the last task is :  status: {lastMemento.Status} , priority: {lastMemento.Priority} , assigsne: {lastMemento.Reporter.name}");
            Restore(lastMemento);
        }
        else
        {
            throw new Exception("history is empty");
        }
    }


    IMessage message = new Message();
    public void Restore(Memento memento)
    {
     User newReporter = new User(assigsnee.email, reporter.name,assigsnee.roles,message);
        this.Status = memento.Status;
        taskHistory.Pop();
        this.Priority = memento.Priority;
        taskHistory.Pop();
        this.reporter = newReporter;
        taskHistory.Pop();
    }
}