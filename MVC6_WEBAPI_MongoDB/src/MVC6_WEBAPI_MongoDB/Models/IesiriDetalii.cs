using System;
using MongoDB.Bson.Serialization.Attributes;

namespace MVC6_WEBAPI_MongoDB.Models
{
    public class IesiriDetalii
    {
        [BsonId]
        public string Id { get; set; }
        public string TipOperatiuneIesire { get; set; }
        public DateTime DataOperatiuneIesire { get; set; }
        public int NumarDocumentIntrare { get; set; }
        public int NumarDocumentIesire { get; set; }
        public string AcronimValuta { get; set; }
        public DateTime DataOperatiuneIntrareValuta { get; set; }
        public int SumaValuta { get; set; }
        public decimal CursIntrareStabilit { get; set; }
        public decimal CursIesireStabilit { get; set; }
        public decimal CursIntrareBnr { get; set; }
        public decimal CursIesireBnr { get; set; }
        public int AdaosRealizat { get; set; }
        public int AdaosRelativ { get; set; }
    }
}
