# 🎯**WORKERS**🎯
***********************************************************
## Description
Introduction of Csharp  by understanding how  cscharp work by example .
It suppose to have some experience in any  programming language and by reading the comment it is possible to sole the basic problem
***********************************************************
⚙️

I use visual studio code <https://code.visualstudio.com/>
using ``` dotnet run ``` cli command <https://docs.microsoft.com/en-us/dotnet/core/tools/>


Difficulty level: simple

* Task 1. Redesign the program so that before the first wave of dismissal in the department there were no more than 20 employees

2.Difficulty level: medium difficulty
* Task 2. Create a department of 40 employees and implement several layoffs, based on the results which in the department should not be more than 30 employees

Difficulty level: hard
* Task 3. Create a department of 50 employees and implement the dismissal of employees
whose salary exceeds 30,000 rubles


# MY SOLUTIONS

## *Task 1

Create a database of X employees
```cs
Repository repository = new Repository(20);
```

## * Task 2. Create a department of 40 employees and implement several layoffs, based on the results
which in the department should not be more than 30 employees

```cs
// * task2:
Repository repository2 = new Repository(40);
// Console.WriteLine(repository.Workers.Count);
while(repository2.Workers.Count > 30){
    repository2.DeleteWorkerByName("Агнес");
    if(repository2.Workers.Count < 30 )
        break;
    repository2.DeleteWorkerByName("Аделаида");
    if(repository2.Workers.Count < 30 )
         break;
    repository2.DeleteWorkerByName("Алдона");
    if(repository2.Workers.Count < 30 )
         break;
    repository2.DeleteWorkerByName("Алима");
    if(repository2.Workers.Count < 30 )
        break;
    repository2.DeleteWorkerByName("Алима");
    if(repository2.Workers.Count < 30 )
        break;
    repository2.DeleteWorkerByName("Аманда");
    if(repository2.Workers.Count < 30 )
        break;
}
// Print to the console of employees who did not get fired
repository2.Print("Database after last deletion");

```

### * task 3

```cs
Repository repository3 = new Repository(50);
repository3.DeleteWorkerBySalary(30000);
repository3.Print("After Deletion");
```
