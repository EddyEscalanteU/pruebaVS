
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
    
public partial class Aerolinea
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Aerolinea()
    {

        this.Vuelo = new HashSet<Vuelo>();

    }


    public int IdAerolinea { get; set; }

    public string Nit { get; set; }

    public string Nombre { get; set; }

    public string Telefono { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Vuelo> Vuelo { get; set; }

}

}
