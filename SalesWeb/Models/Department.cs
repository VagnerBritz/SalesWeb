﻿using System.ComponentModel.DataAnnotations;

namespace SalesWeb.Models
{
#nullable disable

    public class Department
    {
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }
        public Department(string name )
        {
            Name = name;
            
        }
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(x => x.TotalSales(initial, final));
        }
    }
}
