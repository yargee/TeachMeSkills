using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractableRoom
{
    internal class Flags
    {
        public static Dictionary<Constants.Interactables, int> AnswerResults = new Dictionary<Constants.Interactables, int>();

        public static void SetFlag(Constants.Interactables interactable, int value)
        {
            AnswerResults.Add(interactable, value);
        }

        public static int GetValue(Constants.Interactables interactable)
        {
            AnswerResults.TryGetValue(interactable, out int value);
            return value;
        }
    }
}
