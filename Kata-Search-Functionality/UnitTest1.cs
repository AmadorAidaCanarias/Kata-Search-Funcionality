using FluentAssertions;

namespace Kata_Search_Functionality {
    public class Tests {
        
        private CitySearch citySearch;

        [SetUp]
        public void Setup() {
            citySearch = new CitySearch();
        }

        [Test]
        public void should_return_empty_list_when_search_string_fewer_2_character()
        {

            List<string> foundCities = citySearch.Search("");
            
            foundCities.Count.Should().Be(0);
        }
    }

    public class CitySearch {

        private readonly List<string> cities;

        public CitySearch()
        {
            cities = new List<string>()
            {
                "Paris",
                "Budapest",
                "Skopje",
                "Rotterdam",
                "Valencia",
                "Vancouver",
                "Amsterdam",
                "Vienna",
                "Sydney",
                "New York City",
                "London",
                "Bangkok",
                "Hong Kong",
                "Dubai",
                "Rome",
                "Istanbul"
            };
        }

        public List<string> Search(string empty)
        {
            throw new NotImplementedException();
        }
    }
}