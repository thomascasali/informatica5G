//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TEST.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Societa
    {
        public Societa()
        {
        }
    
        public int IDSocieta { get; set; }
        public string IDComune { get; set; }
        public string NomeSocieta { get; set; }
        public string Indirizzo { get; set; }
        public string CAP { get; set; }
        public System.DateTime DataFondazione { get; set; }
        public System.DateTime DataAffiliazione { get; set; }
        public string CodiceAffiliazione { get; set; }
        public bool Affiliata { get; set; }
        public string Email { get; set; }
        public string Sito { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Pec { get; set; }
        public string PIVA { get; set; }
        public string CF { get; set; }
        public string CU { get; set; }
    }
}
