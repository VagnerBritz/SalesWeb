using SalesWeb.Models.Enums;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SalesWeb.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name ="Data")]
        public DateTime Date { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Display(Name = "Total")]
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        [Display(Name = "Vendedor")]
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }
        public SalesRecord(DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
