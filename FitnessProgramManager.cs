using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagmentSystem
{
    internal class FitnessProgramManager
    {
        public List<FitnessProgram> manager = new List<FitnessProgram>();


        public void CreateFitnessProgram(FitnessProgram program)
        {
          manager.Add(program);
          return;

        }

        public void ReadFitnessProgram()
        {
            foreach (var Program in manager) 
            {
                Console.WriteLine(Program);
            }
        }


        public void UpdateFitnessProgram(string Proid, string _title ,string _duration,string _price)
        {
            if (Proid != null) 
            {
                var updatedId = manager.Find(p => p. );
            }

            else
            {
                Console.WriteLine("Check The Id");
            }
        }



        public void DeleteFitnessProgram(int id)
        {
            if ( id != null )
            {
                var delId = manager.Find(p => p.);
            }

            else
            {
                Console.WriteLine("Check The Id")
            }
        }
    }

}
