using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace SalesWeb.Models
{


    public class Seller
    {
        public int Id { get; set; }
        [Display(Name = "Nome")]
        [Required]
        [StringLength(60, MinimumLength = 3, ErrorMessage = $"Tamanho deve ser entre 3 e 60")]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="{0} required")] // 0 pega o nome do atributo
        public string Email { get; set; }
        [Display(Name = "Aniversário")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "{0} required")]
        public DateTime Date { get; set; } // data de aniversario
        [Display(Name ="Salário Base")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        [Required(ErrorMessage = "{0} required")]
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }
        public Seller(string name, string email, DateTime date, double baseSalary, Department department)
        {            
            Name = name;
            Email = email;
            BaseSalary = baseSalary;
            Date = date;
            Department = department;
        }
        public void AddSales(SalesRecord sr) 
        { 
            Sales.Add(sr);
        }
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {

            return Sales.Where(x => x.Date >= initial && x.Date <= final).Sum(x => x.Amount);
        }
    }
}
