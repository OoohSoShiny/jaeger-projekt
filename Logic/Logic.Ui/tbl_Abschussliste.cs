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
    
    public partial class tbl_Abschussliste
    {
        public int Abschussliste_ID { get; set; }
        public int Anzahl { get; set; }
        public System.DateTime Jahr { get; set; }
        public int Tiere_ID { get; set; }
    
        public virtual tbl_Tiere tbl_Tiere { get; set; }
    }
}