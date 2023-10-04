using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractableRoom.Interactables
{
    internal class Torch : IInteractable
    {
        public string Introducion => "Комнату подземелья освещает здоровенный факел. " +
            "\nПламя сильно дрожит из стороны в сторону от сильного сквозняка. ";
        public string[] InteractionResults => new string[] {
            "Ты оттягиваешь рукав и начинаешь бить по пламени, пока оно не потухнет. " +
            "\nПожалуй, это было не лучшее решение, теперь ничего не видно, а глаза какое-то время привыкают к наступившей темноте. " +
            "\nСпустя время ты замечаешь, что откуда-то сверху едва пробивается отраженный свет луны",
            "Не стоит оставаться без света в таком мрачном месте. Пусть горит себе дальше."
            };

        public void Interact()
        {
            Console.WriteLine("Ты подошел ближе к факелу. Он сильно чадит дымом и распространяет едкий запах гари. Глаза начинают слезиться от дыма. ");
            Console.WriteLine("Потушить его или отойти подальше?[0/1]");

            var answer = Convert.ToInt16(Console.ReadLine());
            Flags.SetFlag(Constants.Interactables.Torch, answer);
            Console.WriteLine(InteractionResults[answer]);
            Console.WriteLine();
        }
    }
}
