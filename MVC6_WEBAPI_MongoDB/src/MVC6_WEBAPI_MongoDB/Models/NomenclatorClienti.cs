using MongoDB.Bson.Serialization.Attributes;

namespace MVC6_WEBAPI_MongoDB.Models
{
    public class NomenclatorClienti//clar
    {
        [BsonId]
        public string Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string DenumireTara { get; set; }
        public string CodTara { get; set; }
        public string TipDocumentIdentitate { get; set; }
        public string SerieDocumentIdentitate { get; set; }
        public int NumarDocumentIdentitate { get; set; }
    }
}
