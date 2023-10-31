using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            runApp();
        }
            static void runApp()
            {
                Queue queue = new Queue(5);

                // Enqueue elements into the queue
                queue.Enqueue(10);
                queue.Enqueue(20);
                queue.Enqueue(30);
                queue.Enqueue(40);
                queue.Enqueue(50);
                queue.Enqueue(60);

            // Dequeue elements and display them
            Console.WriteLine("Queue Elements:");
                while (!queue.IsEmpty())
                {
                    int element = queue.Dequeue();
                    Console.WriteLine(element);
                }
            }

        }
    }

