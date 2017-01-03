using System;
using MongoDB.Bson;

namespace MVC6_WEBAPI_MongoDB.Models
{
    public class Evaluare //la nivel de luna
    {
        public ObjectId Id { get; set; }
        public Guid EvaluareId { get; set; }
        public int NumarCurentValuta { get; set; }
        public string AcronimValuta { get; set; } //EUR, USD, CHF etc
        public string DenumireValuta { get; set; } //euro, dolar american etc
        public int EvaluareInitiala { get; set; } //valoare in lei a valutei disponibile la inceputul lunii
        public int ValoareCumparari { get; set; } //cumulata pe parcursul lunii
        public int ValoareVanzari { get; set; }
        public int AdaosTranzactii { get; set; } //{valoare_valuta_vanduta} - {valoare_valuta_cumparata}
        public int ComisionDinCumparari { get; set; } //{valoare_valuta_cumparata} * {procent_comision}
        public int ComisionDinVanzari { get; set; }
        public int IntrariAlimentari { get; set; } //suma cumulata din transferuri
        public int IesiriRemiteri { get; set; } //suma iesita prin transfer
        public int EvaluareFinala { get; set; } //valoare in lei a valutei dispinibila la momentul actual (cand se face actualizarea) 
    }
}
