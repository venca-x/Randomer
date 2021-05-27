using System;

namespace VencaX.Randomer
{
    /// <summary>
    /// Generator radom int number
    /// </summary>
    public class Randomer
    {
        /// <summary>
        /// Random integers between 0 and 100
        /// </summary>
        /// <returns></returns>
        public int Number()
        {
            var rand = new Random();
            return rand.Next(101);
        }

        /// <summary>
        /// Random integers between from - to
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public int NumberFromTo(int from, int to)
        {
            var rand = new Random();
            return rand.Next(from, to);
        }
    }
}
