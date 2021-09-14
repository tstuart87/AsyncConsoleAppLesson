using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncConsoleApp
{
    public class ScrambledEggs
    {
        public void MakeScrambledEggs()
        {
            HeatFryingPan();
            CrackEggsInBowl();
            WhiskEggs();
            PourEggsIntoHeatedPan();
            ScrambleScrambleScramble();
        }

        //MakeScrambledEggsAsync(){}

        public void HeatFryingPan()
        {
            Console.WriteLine("Turning the stove on now...should only take a few minutes...no need to rush.");
            Thread.Sleep(10000);
            Console.WriteLine("Pan is hot and ready.");
        }

        //HeatFryingPanAsync(){}
        

        public void CrackEggsInBowl()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Cracking eggs, Chef.");
        }

        public void WhiskEggs()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Whisking eggs, Chef.");
        }

        public void PourEggsIntoHeatedPan()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Is the pan hot yet?");
            Thread.Sleep(2000);
            Console.WriteLine("Yeah, I turned it on before we started cracking and whisking.");
            Thread.Sleep(2000);
            Console.WriteLine("Putting the eggs in the pan, Chef.");
        }

        public void ScrambleScrambleScramble()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Scramble, scramble, scramble...vOiLa!");
        }
    }
}
