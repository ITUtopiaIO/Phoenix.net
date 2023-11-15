using System.Security.Cryptography.X509Certificates;

namespace Phoenix.Core
{
    public class BirdSpecies
    {
        public int Seq { get; set; }
        public string AOU { get; set; }
        public string EnglishCommonName { get; set; }
        public string FrenchCommonName { get; set; }
        public string SpanishCommonName { get; set; }
        public string Order { get; set; }
        public string Family { get; set; }
        public string Genus { get; set; }
        public string Species { get; set; }

        public BirdSpecies(int seq, string aou, string englishCommonName, string frenchCommonName, string spanishCommonName, string order, string family, string genus, string species)
        {
            Seq = seq;
            AOU = aou;
            EnglishCommonName = englishCommonName;
            FrenchCommonName = frenchCommonName;
            SpanishCommonName = spanishCommonName;
            Order = order;
            Family = family;
            Genus = genus;
            Species = species;
        }

        public BirdSpecies()
        {
        }

        public string ScientificName 
        { 
            get
            {
                return this.Genus + "-" + this.Species;
            }
        }


    }

}