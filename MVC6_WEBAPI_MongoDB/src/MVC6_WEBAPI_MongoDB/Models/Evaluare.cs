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
        public int EvaluareInitiala { get; set; } //cati lei am dat pe valuta repsectiva
        public int ValoareCumparari { get; set; }
        public int ValoareVanzari { get; set; }
        public int AdaosTranzactii { get; set; }
        public int ComisionDinCumparari { get; set; }
        public int ComisionDinVanzari { get; set; }
        public int IntrariAlimentari { get; set; }
        public int IesiriRemiteri { get; set; }
        public int EvaluareFinala { get; set; }
    }
}
