using Empires.Interfaces;

namespace Empires.Models
{
    public class GlobalUpdataerCounter : IUpdatable
    {
        private static int counter;

        public int Counter
        {
            get { return counter; }
        }
        public void Update()
        {
            counter++;
        }
    }
}