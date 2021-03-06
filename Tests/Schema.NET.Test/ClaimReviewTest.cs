namespace Schema.NET.Test
{
    using System;
    using Newtonsoft.Json;
    using Xunit;

    // https://developers.google.com/search/docs/data-types/factcheck
    public class ClaimReviewTest
    {
        private readonly ClaimReview claimReview = new ClaimReview()
        {
            DatePublished = new DateTimeOffset(2016, 6, 22, 0, 0, 0, TimeSpan.Zero), // Required
            Url = new Uri("http://example.com/news/science/worldisflat.html"), // Required
            ItemReviewed = new CreativeWork() // Required
            {
                Author = new Organization() // Required
                {
                    Name = "Square World Society", // Required
                    SameAs = new Uri("https://example.flatworlders.com/we-know-that-the-world-is-flat") // Recommended
                },
                DatePublished = new DateTimeOffset(2016, 6, 20, 0, 0, 0, TimeSpan.Zero), // Optional
            },
            ClaimReviewed = "The world is flat", // Required
            Author = new Organization() // Required
            {
                Name = "Example.com science watch"
            },
            ReviewRating = new Rating() // Required
            {
                RatingValue = 1D, // Required
                BestRating = 5D, // Required
                WorstRating = 1D, // Required
                AlternateName = "False" // Recommended
            }
        };

        private readonly string json =
        "{" +
            "\"@context\":\"http://schema.org\"," +
            "\"@type\":\"ClaimReview\"," +
            "\"url\":\"http://example.com/news/science/worldisflat.html\"," +
            "\"author\":{" +
                "\"@type\":\"Organization\"," +
                "\"name\":\"Example.com science watch\"" +
            "}," +
            "\"datePublished\":\"2016-06-22T00:00:00+00:00\"," +
            "\"itemReviewed\":{" +
                "\"@type\":\"CreativeWork\"," +
                "\"author\":{" +
                    "\"@type\":\"Organization\"," +
                    "\"name\":\"Square World Society\"," +
                    "\"sameAs\":\"https://example.flatworlders.com/we-know-that-the-world-is-flat\"" +
                "}," +
                "\"datePublished\":\"2016-06-20T00:00:00+00:00\"" +
            "}," +
            "\"reviewRating\":{" +
                "\"@type\":\"Rating\"," +
                "\"alternateName\":\"False\"," +
                "\"bestRating\":5.0," +
                "\"ratingValue\":1.0," +
                "\"worstRating\":1.0" +
            "}," +
            "\"claimReviewed\":\"The world is flat\"" +
        "}";

        [Fact]
        public void ToString_ClaimReviewGoogleStructuredData_ReturnsExpectedJsonLd() =>
            Assert.Equal(this.json, this.claimReview.ToString());

        [Fact]
        public void Deserializing_ClaimReviewJsonLd_ReturnsClaimReview()
        {
            var serializerSettings = new JsonSerializerSettings()
            {
                DateParseHandling = DateParseHandling.DateTimeOffset
            };

            Assert.Equal(this.claimReview.ToString(), JsonConvert.DeserializeObject<ClaimReview>(this.json, serializerSettings).ToString());
        }
    }
}
