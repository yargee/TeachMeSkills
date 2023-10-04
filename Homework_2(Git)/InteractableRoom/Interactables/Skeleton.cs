using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractableRoom.Interactables
{
    internal class Skeleton : IInteractable
    {
        public string Introducion => "На полу подземелья лежит чей-то древний скелет. " +
            "\nОдного взгляда на него достаточно, чтобы почувствовать себя неуютно. ";

        public string[] InteractionResults => new string[] {// 0 факел потушен
            "Ты почти наощупь, вдоль стены подходишь ближе к скелету. Лунный свет делает его кривой оскал особенно зловещим. " +
            "\nТебе не по себе. Отойдешь или толкнешь его ногой, несмотря на страх?[0/1]", 
            //1 факел горит
            "Когда ты подходишь к скелету, то видишь, что вблизи он не такой и страшный, как тебе показалось вначале." +
            "\nОн слишком старый и кажется, что развалится от любого касания." +
            "\nНа черепе видна трещина от удара чем-то тяжелым, а челюсть потеряла половину зубов. Он явно не от старости умер" +
            "\nЛюбопытство удовлетворено, страх отступил. Будешь осматривать комнату дальше или растопчешь скелет ногой [0/1]?",
            //2 отойти
            "Ну его... Не стоит тревожить мертвых.",
            //3 ударить
            "От удара ногой скелет расспается. В воздух взлетает облако пыли, и к стихающему запаху гари примешивается еще какая-то мерзость",
        };

        public void Interact()
        {
            var torchFlag = Flags.GetValue(Constants.Interactables.Torch);

            Console.WriteLine("Скелет в углу комнаты не выходит у тебя из головы");
            Console.WriteLine(InteractionResults[Flags.GetValue(Constants.Interactables.Torch)]); //варианты с горящим/потушенным факелом
            
            var answer = Convert.ToInt16(Console.ReadLine());
            Flags.SetFlag(Constants.Interactables.Skeleton, answer); //считываем выбор отойти/ударить

            Console.WriteLine(InteractionResults[answer + 2]);
            Console.ReadLine();
        }
    }
}
