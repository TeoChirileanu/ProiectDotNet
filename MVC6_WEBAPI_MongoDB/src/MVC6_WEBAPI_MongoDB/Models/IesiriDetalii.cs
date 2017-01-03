using System;
using MongoDB.Bson.Serialization.Attributes;

namespace MVC6_WEBAPI_MongoDB.Models
{
    public class IesiriDetalii
    {
        [BsonId]
        public string Id { get; set; }
        public string TipOperatiuneIesire { get; set; } //{Vanzare (V) | Remitere (R)}
        public DateTime DataOperatiuneIesire { get; set; } //data si ora
        public int NumarDocumentIntrare { get; set; } //NumarBonFiscal (V), NumarDispozitieDePlata (R)
        public int NumarDocumentIesire { get; set; }
        public string AcronimValuta { get; set; }
        public DateTime DataOperatiuneIntrareValuta { get; set; }
        public int SumaValuta { get; set; }
        public decimal CursIntrareStabilit { get; set; } //cursul de cumparare stabilit
        public decimal CursIesireStabilit { get; set; } //cursul de vanzare stabilit
        public decimal CursIntrareBnr { get; set; }
        public decimal CursIesireBnr { get; set; }
        public int AdaosRealizat { get; set; } //SumaValuta*CursIesire - SumaValuta*CursIntrare
        public int AdaosRelativ { get; set; } //SumaValuta*CursBnrIntrare - SumaValuta*CursBnrIesire
    }
}
