//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inlamning2DatabasTeknik.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {
        public int InvoiceID { get; set; }
        public decimal AmountToPay { get; set; }
        public bool PaymentStatus { get; set; }
        public int BookingID { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public System.DateTime DueDate { get; set; }
    
        public virtual Booking Booking { get; set; }
    }
}
