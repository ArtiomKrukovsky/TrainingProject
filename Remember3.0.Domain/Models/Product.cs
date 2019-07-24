using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remember3._0.Domain.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [StringLength(50, MinimumLength =0, ErrorMessage ="Недопустимое кол-во символов")]
        [Required(ErrorMessage ="Отсутствует название продукции")]
        [Display(Name ="Название продукции")]
        public string Name { get; set; }

        [Range(0,100000,ErrorMessage ="Недопустимая цена")]
        [Required(ErrorMessage = "Отсутствует цена продукции")]
        [Display(Name ="Цена")]
        public int Price { get; set; }

        public ICollection<Customer> Customers { get; set; }

        public Product()
        {
            Customers = new List<Customer>();
        }
    }
}
