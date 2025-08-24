# User-task-management-system-project
Task Management / Design Template Projects This project built a task management system that allows users to create, assign, update, and track tasks. The system uses design templates that cover all three categories (creative, structural, behavioral)

1.User Management:

User Properties: Name, Email (used as an identifier), Role
Support for different roles - Developer, Manager, QA

2.Task Creation:

Task Properties:

•Created Date

•Title

•Description

•Recipient (User)

•Reporter (User)

•Status (Task, In Progress, Code Review, QA, Done)

•Priority (Low, Medium, High)

•Evaluation Time

•Registration Time (initially set to 0)

Task creation is a complex process and should follow a step-by-step construction approach
Tasks can have subtasks, which have the same properties

3.Task Workflow

Setting up a workflow for tasks:

•Manage task status according to the workflow

•Only Admins can review and approve code

•Only QA can mark a task as done after review

Time Management:

•A task starts with an estimated time

•As work progresses, users record the actual time spent on the task, which is stored in the Recorded Time property

•If a task has subtasks:

•Estimated Time = Sum of estimated times of all subtasks

•Recorded Time = Sum of recorded times of all subtasks

oNotifications:
•Any changes to the task should be notified to the recipient and the task reporter
•Users receive notifications and log them in the console (be sure to keep a general value for future expansion)
oTask History
•Any changes to the task details (status, recipient, priority, etc.) should be stored to allow for review of previous states.
•Users can view the history and undo the last change to the task
