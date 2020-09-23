using System;
using System.Collections.Generic;
using System.Text;

namespace OnzeTweedeRepositoryMetVisualStudio.Bibliotheek
{
    public class Klant
    {
        public int Id { get; set; }
        public string Naam { get; set; }

        // Navigation Prop 
        public List<Ontlening> Ontleningen { get; set; }
    }
}
