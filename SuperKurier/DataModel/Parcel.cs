//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parcel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parcel()
        {
            this.ParcelMoving = new HashSet<ParcelMoving>();
        }
    
        public int id { get; set; }
        public string code { get; set; }
        public decimal weight { get; set; }
        public decimal amount { get; set; }
        public System.DateTime dateOfShipment { get; set; }
        public Nullable<System.DateTime> dateOfDelivery { get; set; }
        public string signaturePath { get; set; }
        public int idSender { get; set; }
        public int idReceiver { get; set; }
        public Nullable<int> idSenderRegion { get; set; }
        public int idReceiverRegion { get; set; }
        public int idTypeOfParcel { get; set; }
        public int idStatus { get; set; }
        public Nullable<decimal> height { get; set; }
        public Nullable<decimal> width { get; set; }
        public Nullable<decimal> length { get; set; }
        public Nullable<int> idTariff { get; set; }
        public Nullable<int> idMethodOfSend { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Customer Customer1 { get; set; }
        public virtual MethodOfSend MethodOfSend { get; set; }
        public virtual Region Region { get; set; }
        public virtual Region Region1 { get; set; }
        public virtual Status Status { get; set; }
        public virtual Tariff Tariff { get; set; }
        public virtual TypeOfParcel TypeOfParcel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParcelMoving> ParcelMoving { get; set; }
    }
}
