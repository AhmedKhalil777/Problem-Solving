using System.Collections;
using System.Collections.Concurrent;

using static Community.CsharpSqlite.Sqlite3;

namespace LeetCode.Algorithms;

public static class Single_Threaded_CPU
{

    public static int[] GetOrder(int[][] tasks)
    {

        Comparer<Task> enquethenProcessingTimeThenIndex = Comparer<Task>
        .Create((t1, t2) => {
            if (t1.EnqueueTime != t2.EnqueueTime)
            {
                return t1.EnqueueTime.CompareTo(t2.EnqueueTime);
            }
            if (t1.ProcessingTime != t2.ProcessingTime)
            {
                return t1.ProcessingTime.CompareTo(t2.ProcessingTime);
            }
            return t1.Index.CompareTo(t2.Index);
        });

        Comparer<Task> processingTimeThenIndex = Comparer<Task>
        .Create((t1, t2) => {
            if (t1.ProcessingTime != t2.ProcessingTime)
            {
                return t1.ProcessingTime.CompareTo(t2.ProcessingTime);
            }
            return t1.Index.CompareTo(t2.Index);
        });  
       

        var  allTasks = new PriorityQueue<Task, Task>(enquethenProcessingTimeThenIndex);
        var availableTasks = new PriorityQueue<Task, Task>(processingTimeThenIndex);
        for (int i = 0, tasksLength = tasks.Length; i < tasksLength; i++)
        {
            int[] taskInfo = tasks[i];
            Task task = new Task(taskInfo[0], taskInfo[1], i);
            allTasks.Enqueue(task, task);
        }
        int virtualTime = 0;
        int orderCounter = 0;
        int[] order = new int[tasks.Length];
        while (allTasks.Count > 0 || availableTasks.Count> 0)
        {
            Task nextTask;
            if (availableTasks.Count == 0)
            {
                nextTask = allTasks.Dequeue();
                virtualTime = nextTask.EnqueueTime;
            }
            else
            {
                nextTask = availableTasks.Dequeue();
            }
            order[orderCounter++] = nextTask.Index;
            virtualTime += nextTask.ProcessingTime;
            while (allTasks.Count >0 && allTasks.Peek().EnqueueTime <= virtualTime)
            {
                var taskTemp = allTasks.Dequeue();
                availableTasks.Enqueue(taskTemp, taskTemp);
            }
        }
        return order;
    }

    class Task
    {
        public int EnqueueTime;
        public int ProcessingTime;
        public int Index;

        public Task(
                 int enqueueTime,
                 int processingTime,
                 int index)
        {
            this.EnqueueTime = enqueueTime;
            this.ProcessingTime = processingTime;
            this.Index = index;
        }

    }
    public static int[] GetOrder1(int[][] tasks)
    {
        var tasksTuples = new List<Tuple<int, int, int>>();
        for (int i = 0; i < tasks.Length; i++)
        {
            tasksTuples.Add(new Tuple<int, int, int>(i, tasks[i][0], tasks[i][1]));
        }
        tasksTuples = tasksTuples.OrderBy(t => t.Item2).ToList();
        var queue = new PriorityQueue<int,int>();
        var res = new int[tasks.Length];
        var j = 0;
        var s = 0;
        var currentTime = tasksTuples[0].Item2;
        while (s < tasksTuples.Count)
        {
            if (currentTime >= tasksTuples[s].Item2 || queue.Count == 0)
            {
                queue.Enqueue(tasksTuples[s].Item1, tasksTuples[s++].Item3);
            }
            else
            {
                break;
            }
        }
               // queue.Enqueue(index, tasks[index++][1]);
        while (queue.TryDequeue(out var i, out var proTime ))
        {
            res[j++] = i;
            currentTime += proTime;
            while (s < tasksTuples.Count)
            {
                if (currentTime >= tasksTuples[s].Item2 || queue.Count == 0)
                {
                    queue.Enqueue(tasksTuples[s].Item1, tasksTuples[s++].Item3);
                }
                else
                {
                    break;
                }
            }
        }
        return res;
    }




}
