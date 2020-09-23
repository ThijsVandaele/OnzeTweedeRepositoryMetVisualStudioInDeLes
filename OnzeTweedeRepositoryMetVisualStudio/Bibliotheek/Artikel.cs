using System;
using System.Collections.Generic;
using System.Text;

namespace OnzeTweedeRepositoryMetVisualStudio.Bibliotheek
{
    public abstract class Artikel
    {
        public int ID { get; set; }
        public string Ean { get; set; }
        public string Titel { get; set; }



        // Nav prop
        public List<Ontlening> Ontleningen { get; set; }

    }
}
