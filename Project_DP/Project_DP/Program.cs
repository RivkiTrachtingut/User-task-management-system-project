using Project_DP.Class;
using Project_DP.Enum;
using Project_DP.Interface;
IMessage message = new Message();
User user = new User("12@gmail,com", "Name1", Roles.QA, message);
User user1 = new User("34@gmail,com", "Name2", Roles.QA, message);
User user2 = new User("56@gmail,com", "Name3", Roles.QA, message);
User user3 = new User("78@gmail,com", "Name4", Roles.Manager, message);
DateTime date1 = new DateTime();
DateTime date2 = new DateTime();
DateTime date3 = new DateTime();
TaskBuilder taskBuilde = new(date1, "Title", "Des", Priority.Low);
taskBuilde.buildAssisnee(user);
taskBuilde.buildReporter(user1);
taskBuilde.buildestimationTime(30f);
TaskBuilder taskBuilde1 = new(date2, "Title1", "Des1", Priority.High);
taskBuilde1.buildAssisnee(user2);
taskBuilde1.buildReporter(user3);
taskBuilde1.buildestimationTime(20f);
TaskBuilder taskBuilde2 = new(date3, "Title2", "Des2", Priority.medium);
taskBuilde2.buildAssisnee(user1);
taskBuilde2.buildReporter(user3);
taskBuilde2.buildestimationTime(89f);

var task1 = taskBuilde1.build();
var task = taskBuilde.build();
var task2 = taskBuilde2.build();

Console.WriteLine($"estimation time for task1: {task1.GetEstimationTime()}");
Console.WriteLine($"estimation time for task2: {task2.GetEstimationTime()}");
Console.WriteLine($"estimation time before add task: {task.GetEstimationTime()}");
taskBuilde.buildListTask(task1);
taskBuilde.buildListTask(task2);
task = taskBuilde.build();
Console.WriteLine($"estimation time after add task: {task.GetEstimationTime()}");

task.Status = new ToDoState(task1);
Console.WriteLine($"logged time for task: {task1.GetLoggedTime()}");
task.Status.ChangeState();
task1.LoggedTime = 56f;
Console.WriteLine($"logged time for task: {task1.GetLoggedTime()}");
Console.WriteLine("state & observer: ");
task1.Status.ChangeState();

task2.LoggedTime = 54f;
Console.WriteLine($"logged time for task: {task.GetLoggedTime()}");
task.Status.ChangeState();
task.Undo();
task.Reporter = user3;
Console.WriteLine($"the last task is :  status: {task.Status} , priority: {task.Priority} , assigsne: {task.Assigsnee.name}");
Console.WriteLine($"the last task is :  status: {task.Status} , priority: {task.Priority} , assigsne: {task.Assigsnee.name}");
task.Status.ChangeState();
task.Priority = Priority.medium;
task.Undo();
task.Reporter = user1;
task.Status.ChangeState();
task.Status.ChangeState();






