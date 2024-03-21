using NUnit.Framework;

namespace Phoenix.Core.SpecFlowTest.StepDefinitions
{
    [Binding]
    public sealed class BirdSpeciesStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        BirdSpecies _birdSpecies;


        [Given(@"I enter a bird species with the following values")]
        public void GivenIEnterABirdSpeciesWithTheFollowingValues(Table table)
        {
            _birdSpecies = EnterABirdSpeciesFromTable(table);
        }

        BirdSpecies EnterABirdSpeciesFromTable(Table table)
        {
            BirdSpecies birdSpecies = new BirdSpecies();

            if (table.Rows.Count > 0)
            {
                birdSpecies.Seq = Convert.ToInt32(table.Rows[0]["Seq"]);
                //birdSpecies.AOU = table.Rows[0]["AOU"];
                //birdSpecies.EnglishCommonName = table.Rows[0]["EnglishCommonName"];
                //birdSpecies.FrenchCommonName = table.Rows[0]["FrenchCommonName"];
                //birdSpecies.SpanishCommonName = table.Rows[0]["SpanishCommonName"];
                //birdSpecies.Order = table.Rows[0]["Order"];
                //birdSpecies.Family = table.Rows[0]["Family"];
                birdSpecies.Genus = table.Rows[0]["Genus"];
                birdSpecies.Species = table.Rows[0]["Species"];
            }

            return birdSpecies;

        }

        [Then(@"the scientific name should be ""(.*)""")]
        public void ThenTheScientificNameShouldBe(string expectedScientificName)
        {
            Assert.AreEqual(expectedScientificName, _birdSpecies.ScientificName);
        }

    }
}