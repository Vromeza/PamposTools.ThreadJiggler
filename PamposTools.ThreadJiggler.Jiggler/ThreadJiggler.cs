using PamposTools.ThreadJiggler.Abstractions;
using System;
using System.Threading;

namespace PamposTools.ThreadJiggler.Jiggler
{
    public static class ThreadJiggler
    {
        public static void Jiggle() {
            Random rng = new Random();
            int random = rng.Next(1, 3);
            switch (random) {
                case 1: Sleep(rng); break;
                case 2: Thread.Yield(); break;
                case 3: return;
            }
        }

        private static void Sleep(Random rng) {
            int sleepTime = rng.Next(1, 500);
            Thread.Sleep(sleepTime);
        }
    }
}