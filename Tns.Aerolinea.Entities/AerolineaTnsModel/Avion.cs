//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tns.Aerolinea.Entities.AerolineaTnsModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Avion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Avion()
        {
            this.Asiento = new HashSet<Asiento>();
            this.Vuelo = new HashSet<Vuelo>();
        }
    
        public int IdAvion { get; set; }
        public string Modelo { get; set; }
        public string Fabricante { get; set; }
        public int Capacidad { get; set; }
        public string Siglas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asiento> Asiento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vuelo> Vuelo { get; set; }
    }
}
