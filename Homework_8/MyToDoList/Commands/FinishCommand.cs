using MyToDoList.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList.Commands
{
    internal class FinishCommand : ICommand
    {
        private ToDoList _toDoList;

        public FinishCommand(ToDoList toDoList)
        {
            _toDoList = toDoList;
        }

        public string Description => "Завершить задачу.";

        public void Execute()
        {
            do
            {
                Console.WriteLine("Введи номер задачи для завершения.");
                var input = Console.ReadLine();

                if (!int.TryParse(input, out int index))
                {
                    continue;
                }
                else
                {
                    if (index >= 0 && index < _toDoList.ToDoCount)
                    {
                        _toDoList.Finish(index);
                        break;
                    }
                }
            } while (true);
        }
    }
}
