using MongoDB.Bson.Serialization.Attributes;

namespace MVC6_WEBAPI_MongoDB.Models
{
    public class NomenclatorValute
    {
        [BsonId]
        public string Id { get; set; }
        public int NumarCurentValuta { get; set; }
        public string AcronimValuta { get; set; }
        public string DenumireValuta { get; set; }
        public int Multiplu { get; set; }
        public string TipValuta { get; set; } //cotata (i.e. se afla in tabloul BNR), necotata
        public int PozitieValuta { get; set; } //principala (cele mai folosite), secundara
        //deprecated
    }
}
