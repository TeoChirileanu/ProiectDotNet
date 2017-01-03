using MongoDB.Bson.Serialization.Attributes;

namespace MVC6_WEBAPI_MongoDB.Models
{
    public class NomenclatorTari
    {
        [BsonId]
        public string Id { get; set; }
        public string Cod { get; set; }
        public string Denumire { get; set; }
        public int TotalCumparariEuro { get; set; }
        public int TotalVanzariEuro { get; set; }
    }
}
