
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace CRB
{

using System;
    using System.Collections.Generic;
    
public partial class Electronic_medical_card
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Electronic_medical_card()
    {

        this.MKB = new HashSet<MKB>();

    }


    public int id_case { get; set; }

    public int id_patient { get; set; }

    public System.DateTime date_receipt { get; set; }

    public Nullable<System.DateTime> date_discharge { get; set; }

    public int id_departments { get; set; }

    public int id_doctor { get; set; }

    public int id_outcomes { get; set; }



    public virtual Departments Departments { get; set; }

    public virtual Outcomes Outcomes { get; set; }

    public virtual Patient Patient { get; set; }

    public virtual Staff Staff { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<MKB> MKB { get; set; }

}

}
