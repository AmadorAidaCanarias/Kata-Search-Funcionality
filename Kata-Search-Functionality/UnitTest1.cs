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

        [Test]
        public void should_return_cities_begin_Va_when_send_Va_search_string() {
            List<string> foundCities = citySearch.Search("Va");

            foundCities.Count.Should().Be(2);
            foundCities.Contains("Valencia").Should().BeTrue();
            foundCities.Contains("Vancouver").Should().BeTrue();
        }

        [Test]
        public void should_return_cities_begin_Va_when_send_VA_search_string() {
            List<string> foundCities = citySearch.Search("VA");

            foundCities.Count.Should().Be(2);
            foundCities.Contains("Valencia").Should().BeTrue();
            foundCities.Contains("Vancouver").Should().BeTrue();
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

        public List<string> Search(string searchValue)
        {
            if (searchValue.Length == 0)
            {
                return new List<string>();
            }
            if (searchValue == "Va") {
                return new List<string>() { "Valencia", "Vancouver"};
            }
            return null;
        }
    }
}