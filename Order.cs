//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Reczna_Myjnia_Samochodowa
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.Order_detail = new HashSet<Order_detail>();
            this.Employee1 = new HashSet<Employee>();
            this.Fault = new HashSet<Fault>();
        }
    
        public int ID_order { get; set; }
        public int ID_employee { get; set; }
        public int ID_customer { get; set; }
        public int ID_car { get; set; }
        public int ID_document { get; set; }
        public Nullable<System.DateTime> Order_date { get; set; }
        public Nullable<System.TimeSpan> Start_time { get; set; }
        public Nullable<System.TimeSpan> End_time { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> Workplace_nr { get; set; }
        public Nullable<bool> Payment_type { get; set; }
        public Nullable<bool> Document_type { get; set; }
    
        public virtual Car Car { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_detail> Order_detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employee1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fault> Fault { get; set; }
    }
}
