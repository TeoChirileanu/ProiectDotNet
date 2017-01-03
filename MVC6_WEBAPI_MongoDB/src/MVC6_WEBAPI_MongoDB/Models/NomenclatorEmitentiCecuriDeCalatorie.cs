using MongoDB.Bson.Serialization.Attributes;

namespace MVC6_WEBAPI_MongoDB.Models
{
    public class NomenclatorEmitentiCecuriDeCalatorie
    {
        [BsonId]
        public string Id { get; set; }
        public string Emitent { get; set; }
    }
}
