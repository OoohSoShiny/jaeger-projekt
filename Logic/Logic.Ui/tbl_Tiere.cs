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
    
    public partial class tbl_Tiere
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Tiere()
        {
            this.tbl_Abschussliste = new HashSet<tbl_Abschussliste>();
            this.tbl_Jagderfolge = new HashSet<tbl_Jagderfolge>();
        }
    
        public int Tiere_ID { get; set; }
        public string Tierart { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Abschussliste> tbl_Abschussliste { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Jagderfolge> tbl_Jagderfolge { get; set; }
    }
}