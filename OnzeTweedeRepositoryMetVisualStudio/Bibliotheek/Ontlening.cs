using System;
using System.Collections.Generic;
using System.Text;

namespace OnzeTweedeRepositoryMetVisualStudio.Bibliotheek
{
    public class Ontlening
    {
        public int Id { get; set; }
        public DateTime Van { get; set; }
        public DateTime Tot { get; set; }

        // Nav prop
        public Klant Klant { get; set; }
        public List<Artikel> Artikelen { get; set; }
    }
}
