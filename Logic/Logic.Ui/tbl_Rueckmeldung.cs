//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JaegerMeister.MvvmSample.Logic.Ui
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Rueckmeldung
    {
        public int Rückmeldung_ID { get; set; }
        public string Funktion { get; set; }
        public int Gäste { get; set; }
        public int Jäger_ID { get; set; }
        public int Termine_ID { get; set; }
    
        public virtual tbl_Jaeger tbl_Jaeger { get; set; }
        public virtual tbl_Termine tbl_Termine { get; set; }
    }
}