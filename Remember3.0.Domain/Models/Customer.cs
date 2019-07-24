using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remember3._0.Domain.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage ="Отсутствует дата создания")]
        [Display(Name="Дата создания")]
        public DateTime Create_at { get; set; }

        [StringLength(50, MinimumLength =0, ErrorMessage ="Недопустимое кол-во символов")]
        [Required(ErrorMessage = "Отсутствует адрес")]
        [Display(Name = "Адрес")]
        public string Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Отсутствует номер телефона")]
        [Display(Name = "Номер телефона")]
        public string PhoneNumber { get; set; }

        [Range(0, 10, ErrorMessage = "Недопустимое количество")]
        [Required(ErrorMessage = "Отсутствует количество")]
        [Display(Name = "Количесво")]
        public Count Count { get; set; }

        [Range(0, 10000, ErrorMessage = "Недопустимая цена")]
        [Required(ErrorMessage = "Отсутствует цена продукции")]
        [Display(Name = "Цена")]
        public int FinalPrice { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

    }

    public enum Count
    {
        one=1,
        two=2,
        three=3,
        four=4,
        five=5,
        six=6,
        seven=7,
        eight=8,
        nine=9,
        ten=10
    }
}
