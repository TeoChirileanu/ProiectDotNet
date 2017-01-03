using System;
using MongoDB.Bson;

namespace MVC6_WEBAPI_MongoDB.Models
{
    public class DetaliiSolduri
    {
        public ObjectId Id { get; set; }
        public int DetaliiId { get; set; }
        public string AcronimValuta { get; set; }
        public string SursaOperatiune { get; set; }
        public int SumaIntrata { get; set; }
        public int SumaDisponibilla { get; set; }
        public decimal CursValutarStabilit { get; set; }
        public decimal CursOficialBnr { get; set; }
        public int NumarDocument { get; set; }
        public string SerieDocument { get; set; }
        public DateTime DataIntrare { get; set; } //data si ora
        public int NumarListaCursValutar { get; set; }
    }
}
