using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_DP.Interface;

namespace Project_DP.Class;

public class TaskBuilder
{

    public DateTime CreateDate { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    public User Assigsnee = null;
    public User Reporter = null;
    public IStatus Status { get; set; }
    public Enum.Priority Priority { get; set; }
    public float? EstimationTime { get; set; } //זמן אומדן
    public float LoggedTime { get; set; }
    public List<Task> Tasks = null;

    public TaskBuilder(DateTime createDate, string title, string description, Enum.Priority priority)
    {
        this.CreateDate = createDate;
        this.Title = title;
        this.Description = description;
        this.LoggedTime = 0;
        this.Priority = priority;

    }
    public void buildAssisnee(User assigsnee)
    {
        this.Assigsnee = assigsnee;
    }
    public void buildReporter(User reporter)
    {
        this.Reporter = reporter;
    }
    public void buildestimationTime(float estimationTime)
    {
        this.EstimationTime = estimationTime;
    }
    public void buildListTask(Task task)
    {
        if (Tasks == null)
        {
            Tasks = new List<Task>();
        }
        Tasks.Add(task);
    }
    public Task build()
    {
        if (Assigsnee == null || Reporter == null || EstimationTime == null)
        {
            throw new Exception("cano't build task");
        }

        return new Task()
        {
            Assigsnee = Assigsnee,
            Reporter = Reporter,
            Tasks = Tasks,
            EstimationTime = (float)EstimationTime,

        };
    }



}

