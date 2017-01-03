using System;
using System.Security.Cryptography.X509Certificates;
using MongoDB.Bson.Serialization.Attributes;

namespace MVC6_WEBAPI_MongoDB.Models
{
    public class NomenclatorCarduri //deprecated (se tine evidenta clientilor care au cumparat valuta cu cardul)
    {
        [BsonId]
        public string Id { get; set; }
        public DateTime DataTranzactie { get; set; }
        public string SerieChitantaSchimbValutar { get; set; }
        public int NumarChitantaSchimbValutar { get; set; }
        public int NumarBonFiscal { get; set; }
        public int ClientId { get; set; }
        public string DenumireCard { get; set; }
        public string NumarCard { get; set; }
        public string Valuta { get; set; }
        public int SumaTranzactionata { get; set; }
        public decimal CursValutarStabilit { get; set; }
        public decimal ValoareLei { get; set; }
    }
}
