﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Payment
    {
        [Display(Name = "Payment ID")]
        public int PaymentID { get; set; }
        [Display(Name = "Receipt #")]
        public int ReceiptNumber { get; set; }
        [Display(Name = "Employee ID")]
        public int EmployeeID { get; set; }
        [Display(Name = "Rent Contract ID")]
        public int RentalContractID { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Payment Date")]
        public DateTime PaymentDate { get; set; }
        public int Amount { get; set; }
        public string Notes { get; set; }
    }
}