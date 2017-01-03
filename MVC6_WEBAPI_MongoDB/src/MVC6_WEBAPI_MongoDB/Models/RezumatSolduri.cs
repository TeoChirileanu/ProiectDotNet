using System;
using MongoDB.Bson;

namespace MVC6_WEBAPI_MongoDB.Models
{
    public class RezumatSolduri
    {
        public ObjectId Id { get; set; }
        public Guid RezumatId { get; set; }
        public DateTime DataSold { get; set; }
        public int NumarCurentValuta { get; set; }
        public string AcronimValuta { get; set; }
        public string DenumireValuta { get; set; }
        public int SoldInitial { get; set; }
        public int SoldFinal { get; set; }
        public decimal CursValutarStabilit { get; set; }
        public decimal CursOficialBnr { get; set; }
        public int EvaluareSoldFinal { get; set; }
        public int SumaDisponibila { get; set; }
    }
}
