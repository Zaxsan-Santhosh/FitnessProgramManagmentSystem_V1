using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagmentSystem
{
    internal class FitnessProgram
    {
        private string fitnessProgramId { get; set; }
        private string title { get; set; }
        private string duration { get; set; }
        private string price { get; set; }


        public FitnessProgram(string ProgramId , string Title , string Duration , string Price)
        {
            this.fitnessProgramId = ProgramId;
            this.title = Title;
            this.duration = Duration;
                this.price = Price;

        }


        public override string ToString()
        {
           return($"fitnessProgramId: {fitnessProgramId}, Title: {title}, Duration: {duration}, Price: {price}");
           
        }


    }


    
}
