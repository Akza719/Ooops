using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooops
{
    public class Programmer : Creator
    {
        public override void Create()
        {
            if (base.CreativityLevel >= 70 && base.Energy >= 80)
            {
                this.BrainstormSolution();
                this.PickOptimalSolution();
                this.WriteCode();
                this.TestCode();
            }
            else
            {
                throw new Exception(" Cannot create a program");
            }
        }

        private void BrainstormSolution()
        {
            base.CreativityLevel = base.CreativityLevel - 15;
            base.Energy = base.Energy - 10;
            Console.WriteLine("Brainstorming Solution......");
        }
       private void PickOptimalSolution()
        {
            base.CreativityLevel = base.CreativityLevel - 5;
            base.Energy = base.Energy - 5;
            Console.WriteLine("Pick the best optimal Solution......");
        }
        private void WriteCode()
        {
            base.CreativityLevel = base.CreativityLevel - 7;
            base.Energy = base.Energy - 5;
            Console.WriteLine(" Writing Code......");
        }
        private void TestCode()
        {
            base.CreativityLevel = base.CreativityLevel - 8;
            base.Energy = base.Energy - 4;
            Console.WriteLine("Testing Code......");
        }
    }
}
