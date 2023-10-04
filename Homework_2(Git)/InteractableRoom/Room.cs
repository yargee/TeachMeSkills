using InteractableRoom.Interactables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractableRoom
{
    internal class Room
    {
        private List<IInteractable> _interactables;

        public Room() 
        {
            _interactables = new List<IInteractable>
            {
                new Torch(),
                new Skeleton()
            };
        }
        public void ShowIntro()
        {
            Console.WriteLine("Привет. Буду краток. В качестве ответов используй цифры, которые будут указаны в вариантах ответа.\nЛень обрабатывать ввод, если введешь не цифру - вылетишь. \nПогнали. Ты оказался в комнате в подземелье. Как? Не спрашивай, не придумал. Выбирайся или присоединишься к местным.");
            Console.WriteLine();
            Console.ReadLine();

            var intro = "";

            foreach(var interactable in _interactables)
            {
                intro += interactable.Introducion;
            }

            Console.WriteLine(intro);
        }

        public void ShowInteractables()
        {
            foreach(var interactable in _interactables)
            {
                interactable.Interact();
            }
        }
    }
}
