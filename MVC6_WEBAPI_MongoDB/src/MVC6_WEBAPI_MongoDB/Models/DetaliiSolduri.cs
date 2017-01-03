using System;
using MongoDB.Bson;

namespace MVC6_WEBAPI_MongoDB.Models
{
    public class DetaliiSolduri //componenta soldului de valuta (i.e. 1000 de euro adunati din mai multe zile, la diferite cursuri valutate)
    {
        public ObjectId Id { get; set; }
        public int DetaliiId { get; set; }
        public string AcronimValuta { get; set; }
        public string SursaOperatiune { get; set; } //{cumparare de valuta, intrari de valuta (alimentare)
        public int SumaIntrata { get; set; }
        public int SumaDisponibila { get; set; } //initial, egala cu SumaIntrata; in momentul iesirii, se diminueaza
        public decimal CursValutarStabilit { get; set; } //cursul de cumparare/alimentare
        public decimal CursOficialBnr { get; set; }
        public int NumarDocument { get; set; } //din tabelul operatii
        public string SerieDocument { get; set; } //tot de acolo
        public DateTime DataIntrare { get; set; } //data si ora
        public int NumarListaCursValutar { get; set; }//tot din operatii
    }
}
