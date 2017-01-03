using System;
using MongoDB.Bson;

namespace MVC6_WEBAPI_MongoDB.Models
{
    public class Operatii
    {
        public ObjectId Id { get; set; }
        public Guid OperatieId { get; set; } //tipul operatiunii : {Cumparate, Vanzare, Alimentare (i.e. intrare prin transfer), Remitere (i.e. iesire prin transfer)}
        public DateTime DataOperatiune { get; set; } //data si ora
        public string SerieChitanta { get; set; } //pentru operatiuni nefiscale (vezi global.json)
        public int NumarCurentChitanta { get; set; } //pentru operatiuni nefiscale (vezi global.json)
        public int NumarDocument { get; set; } // "vanzare | cumparare" : NumarBonFiscal; "alimentare | remitere": NumarDispozitie{Incasare |  Plata}
        public string StareOperatiuneTranzactie { get; set; } //starile operatiunii: {"nefiscal": M; "regim fiscal nefinalizat": I; "regim fiscal finalizat": Z, "inregistrare invalida": A (i.e. anulat)}
        public int NumarRaportZ { get; set; } //intorc de echipamentul fiscal la finalizarea operatiei de golire a memoriei de zi a aparatului fiscal
        public string NumePrenumeClient { get; set; }
        public string CalitateClient { get; set; } //{"rezident": R; "nerezident": N}
        public string DenumireTaraClient { get; set; }
        public int CodTaraClient { get; set; }
        public string TipDocumentIdentitate { get; set; }
        public string SerieDocumentIdentitate { get; set; }
        public int NumarDocumentIdentitate { get; set; }
        public string AcronimValuta { get; set; } //EUR, USD, CHF etc
        public int Multiplu { get; set; } //multiplu de valuta (e.g. 1 pentru dolar, 100 pentru forinti)
        public decimal ParitateEuro { get; set; } //paritatea fara de euro, e.g. cati dolari incap intr-un euro
        public int NumarLista { get; set; } //numarul de actualizari dintr-o luna (e.g. de cate ori s-a actualizat cursul intr-o luna)
        public int ProcentComisionCec { get; set; } //deprecated (i.e. nici cash, nici card)
        public int ProcentComisionCard { get; set; } //daca omul plateste cu cardul
        public int ValoareComision { get; set; } //{valoare_tranzactie} * {procent_comision}
        public int ValoareSpeze { get; set; } //deprecated (i.e. pentru documente bancare)
        public string InstrumentPlata { get; set; } //{numerare (i.e. cash), card}
        public int SumaValuta { get; set; } // i.e. 200 de euro, daca acronimul e EUR
        public int CursOficialBnr { get; set; }
        public int CursValutarStabilit { get; set; } //de vanzare/cumparare, luate din tabelul Curs
        public int ValoareLei { get; set; } //{valuta} * {curs}
        public int AdaosRealizat { get; set; } //numai daca operatia este vanzare valuta (i.e. valoare_lei_valuta_vanduta - valoare_lei_valuta_cumparata)
        public int AdaosRelativ { get; set; } //valoare lei valuta vanduta, relativ la cursul BNR din momentul vanzarii - valoare lei valuta cumparata, relativ la cursul Bnr din momentul cumpararii
        public int SoldPrecedent { get; set; } //soldul inaintea operatiunii (i.e. daca pot face operatiunea sau nu)
    }
}
