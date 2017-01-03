using System;
using MongoDB.Bson;

namespace MVC6_WEBAPI_MongoDB.Models
{
    public class Operatii
    {
        public ObjectId Id { get; set; }
        public Guid OperatieId { get; set; }
        public DateTime DataOperatiune { get; set; } //data si ora
        public string SerieChitanta { get; set; }
        public int NumarChitanta { get; set; }
        public int NumarDocument { get; set; }
        public string StareOperatiuneTranzactie { get; set; }
        public int NumarRaportZ { get; set; }
        public string NumePrenumeClient { get; set; }
        public string CalitateClient { get; set; }
        public string DenumireTaraClient { get; set; }
        public int CodTaraClient { get; set; }
        public string TipDocumentIdentitate { get; set; }
        public string SerieDocumentIdentitate { get; set; }
        public int NumarDocumentIdentitate { get; set; }
        public string AcronimValuta { get; set; } //EUR, USD, CHF etc
        public int Multiplu { get; set; } //multiplu de valuta (e.g. 1 pentru dolar, 100 pentru forinti)
        public decimal ParitateEuro { get; set; } //paritatea fara de euro, e.g. cati dolari incap intr-un euro
        public int NumarLista { get; set; } //numarul de actualizari dintr-o luna (e.g. de cate ori s-a actualizat cursul intr-o luna)
        public int ProcentComisionCec { get; set; }
        public int ProcentComisionCard { get; set; }
        public int ValoareComision { get; set; }
        public int ValoareSpeze { get; set; }
        public string InstrumentPlata { get; set; }
        public int SumaValuta { get; set; }
        public int CursOficialBnr { get; set; }
        public int CursValutarStabilit { get; set; }
        public int ValoareLei { get; set; }
        public int AdaosRealizat { get; set; }
        public int AdaosRelativ { get; set; }
        public int SoldPrecedent { get; set; }
    }
}
