
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
    
public partial class Origen
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Origen()
    {

        this.Vuelo = new HashSet<Vuelo>();

    }


    public int IdOrigen { get; set; }

    public int IdCiudad { get; set; }

    public string Aeropuerto { get; set; }

    public bool Activo { get; set; }



    public virtual Ciudad Ciudad { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Vuelo> Vuelo { get; set; }

}

}
