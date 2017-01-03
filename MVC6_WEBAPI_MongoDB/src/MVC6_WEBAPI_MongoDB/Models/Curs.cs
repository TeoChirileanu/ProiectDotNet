using System;
using MongoDB.Bson;

namespace MVC6_WEBAPI_MongoDB.Models
{
    public class Curs //tine evidenta cursurilor
    {
        public ObjectId Id { get; set; }
        public int NumarCurentValuta { get; set; }
        public string TipValuta { get; set; } //cotata, necotata
        public string PozitieValuta { get; set; } //principala, secundara
        public string AcronimValuta { get; set; } //EUR, USD, CHF etc
        public string DenumireValuta { get; set; } //euro, dolar american etc
        public decimal CursOficialBnr { get; set; } //4 decimale precizie
        public decimal CursCumparare { get; set; }
        public decimal CursVanzare { get; set; }
        public decimal ParitateEuro { get; set; } //paritatea fara de euro, e.g. cati dolari incap intr-un euro
        public DateTime DataCurs { get; set; } //data si ora setarii cursului (i.e. ultimei actualizari a cursului)
        public int NumarLista { get; set; } //numarul de actualizari dintr-o luna (e.g. de cate ori s-a actualizat cursul intr-o luna)
        public bool ActualizareValuta { get; set; } //este true daca la inceputul zilei s-a actualizat cursul
        public Guid CasierId { get; set; } //din Casieri.cs
        public int Multiplu { get; set; } //multiplu de valuta (e.g. 1 pentru dolar, 100 pentru forinti)
        public int SoldCurentValuta { get; set; } //cat {denumire_valuta} am disponibil
    }
}
