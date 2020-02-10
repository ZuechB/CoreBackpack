namespace CoreBackpack.Models
{
    public class LuisResponse
    {
        public string query { get; set; }
        public LuisResponse_Topscoringintent topScoringIntent { get; set; }
        public LuisResponse_Entity[] entities { get; set; }
    }

    public class LuisResponse_Topscoringintent
    {
        public string intent { get; set; }
        public float score { get; set; }
    }

    public class LuisResponse_Entity
    {
        public string entity { get; set; }
        public string type { get; set; }
        public int startIndex { get; set; }
        public int endIndex { get; set; }
        public float score { get; set; }
        public string role { get; set; }
        public LuisResponse_Resolution resolution { get; set; }
    }

    public class LuisResponse_Resolution
    {
        public string subtype { get; set; }
        public string value { get; set; }
    }
}