//Queue Example
//follows FIFO approach doesnt work on index
//Enqueue and Dequeue

namespace QueueExample
{
    class Program
    {
        static void Main()
        {
            //create an object of Queue Class
            Queue<string> queue = new Queue<string>();

            //Enqueue (add)
            queue.Enqueue("Task 3");
            queue.Enqueue("Task 5");
            queue.Enqueue("Task 1");
            queue.Enqueue("Task 4");
            queue.Enqueue("Task 2");

            //foreach
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            //dequeue
            queue.Dequeue();

            //peek
            queue.Peek();

            //contains
            queue.Contains("Task 1");

            //To array
            queue.ToArray();

            //Clear
            queue.Clear();
        }
    }
}