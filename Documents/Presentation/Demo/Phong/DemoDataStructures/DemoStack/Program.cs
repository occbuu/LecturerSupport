using System;

namespace DemoQueue
{
    class Program
    {
        static void RpnLoop()
        {
            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                if (input.Trim().ToLower() == "quit")
                {
                    break;
                }
                // The stack of integers not yet operated on.
                Stack<int> values = new Stack<int>();
                foreach (string token in input.Split(new char[] { ' ' }))
                {
                    // If the value is an integer...
                    int value;
                    if (int.TryParse(token, out value))
                    {
                        // ... push it to the stack.
                        values.Push(value);
                    }
                    else
                    {
                        // Otherwise evaluate the expression...
                        int rhs = values.Pop();
                        int lhs = values.Pop();
                        // ... and pop the result back to the stack.
                        switch (token)
                        {
                            case "+":
                                values.Push(lhs + rhs);
                                break;
                            case "-":
                                values.Push(lhs - rhs);
                                break;
                            case "*":
                                values.Push(lhs * rhs);
                                break;
                            case "/":
                                values.Push(lhs / rhs);
                                break;
                            case "%":
                                values.Push(lhs % rhs);
                                break;
                            default:
                                throw new ArgumentException(
                                string.Format("Unrecognized token: {0}", token));
                        }
                    }
                }
                Console.WriteLine(values.Pop());
            }
        }

        static void Main(string[] args)
        {
            //----Add elements for Doubly Linked List----//

            //LinkedList<int> dList = new LinkedList<int>();
            //dList.AddFirst(1);
            //dList.AddFirst(2);
            //dList.AddFirst(3);
            //dList.AddFirst(4);
            //dList.AddFirst(5);

            //----Remove element----//

            //dList.Remove(3);

            //----Add elements for Stack----//

            //Stack<int> values = new Stack<int>();
            //values.Push(1);
            //values.Push(2);
            //values.Push(3);
            //values.Push(4);
            //values.Push(5);
            //values.Pop();

            // Stack App

            RpnLoop();

        }
    }
}