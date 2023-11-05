using System.Security.Cryptography.X509Certificates;

namespace Phoenix.Core
{
    public class BirdSpecies
    {
        int Seq { get; set; }
        string AOU { get; set; }
        string EnglishCommonName { get; set; }
        string FrenchCommonName { get; set; }
        string SpanishCommonName { get; set; }
        string ScientificName { get; set; }
        string Order { get; set; }
        string Family { get; set; }
        string Genus { get; set; }
        string Species { get; set; }

        public BirdSpecies(int seq, string aou, string englishCommonName, string frenchCommonName, string spanishCommonName, string scientificName, string order, string family, string genus, string species)
        {
            Seq = seq;
            AOU = aou;
            EnglishCommonName = englishCommonName;
            FrenchCommonName = frenchCommonName;
            SpanishCommonName = spanishCommonName;
            ScientificName = scientificName;
            Order = order;
            Family = family;
            Genus = genus;
            Species = species;
        }

     
    }

}