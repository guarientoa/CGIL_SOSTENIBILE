//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class ConversioneGrandezze
    {
        public string GrandezzaOrigine { get; set; }
        public string GrandezzaDestinazione { get; set; }
        public double Coefficiente { get; set; }
    
        public virtual Grandezze Grandezze { get; set; }
        public virtual Grandezze Grandezze1 { get; set; }
    }
}
