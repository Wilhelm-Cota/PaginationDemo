using System.ComponentModel.DataAnnotations;

namespace PaginationDemo.Models
{
    public class Customer
    {
        [Key]
        public string CustomerId { get; set; }

        public string CompanyName { get; set; }

        public string ContactTitle { get; set;}

        public string ContactName { get; set;}

        public string Country { get; set;}

    }
}
