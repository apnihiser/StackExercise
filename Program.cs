using System.Collections;
using System;

namespace SectionFourStack
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int command;
                bool result;
                string input;
                string msg = "initializing...";
                Stack stack = new Stack();

                do
                {
                    RenderMainMenu(msg);

                    input = Console.ReadLine();

                    result = int.TryParse(input, out command);

                    if (result == true)
                    {
                        switch (command) 
                        {
                            case 1:
                                msg = $"Contents of stack: {stack.ReadStack()}";
                                break;
                            case 2:
                                stack.Push(1);
                                msg = $"##### Pushing Test data (integer 1)...\nStack size: {stack.StackLength()}.";
                                break;
                            case 3:
                                msg = $"##### Popped: {stack.Pop()}.\nStack size: {stack.StackLength()}.";
                                break;
                            case 4:
                                stack.Clear();
                                msg = $"##### Clearing stack...\nStack size: {stack.StackLength()}.";
                                break;
                            case 5:
                                msg = "##### Prepare for a crash...";
                                stack.Push(null);
                                break;
                            default:
                                msg = "##### Exiting program...";
                                command = -1;
                                break;
                        }
                    }
                    else if(result == false)
                    {
                        Console.WriteLine("Invalid command, please check your entry and try again.");
                    }
                } while (command != -1);
            }
            catch (InvalidOperationException err)
            {
                Console.WriteLine($"Error : {err}");
            }
        }

        public static void RenderMainMenu(string msg)
        {
            msg = (msg == null) ? "" : msg;

            Console.Clear();
            Console.WriteLine("CALL STACK SIMULATION PROGRAM");
            Console.WriteLine("\nPress 1: Read the contents of the stack... \n" +
            "Press 2: Push an object on the stack...      \n" +
            "Press 3: Pop an object from the stack...     \n" +
            "Press 4: Remove all objects from the stack...\n" +
            "Press 5: Attempt to add null to the stack... \n" +
            "Press 0: Exit program...                     \n");
            Console.WriteLine($"Status Message: {msg}\n");
            Console.Write(":~$ ");
        }
    }
}
