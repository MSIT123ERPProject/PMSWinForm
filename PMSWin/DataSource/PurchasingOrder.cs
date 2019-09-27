//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PMSWin.DataSource
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchasingOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchasingOrder()
        {
            this.Orders = new HashSet<Order>();
            this.PurchasingOrderDetails = new HashSet<PurchasingOrderDetail>();
        }
    
        public int PurchasingOrderOID { get; set; }
        public string PurchasingOrderID { get; set; }
        public string EmployeeID { get; set; }
        public System.DateTime POBeginDate { get; set; }
    
        public virtual Buyer Buyer { get; set; }
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchasingOrderDetail> PurchasingOrderDetails { get; set; }
    }
}