using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce1.Models
{
    public class Product
    {
        [Key]
        public long Id { get; set; }

        public DateTime DateCreated { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        public string Image { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int ProductCategoryId { get; set; }
        public IEnumerable<ProductCategory> ProductCategories { get; set; }

        [Required]
        [Display(Name = "Status")]
        public int StatusId { get; set; }
        public IEnumerable<Status> Statuses { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public int GenderId { get; set; }
        public IEnumerable<Gender> Genders { get; set; }

        [NotMapped]
        [Display(Name = "Upload Image File")]
        public IFormFile ImageFile { get; set; }

        public bool IsFeaturedProduct { get; set; }

        public IEnumerable<ProductImage> ProductImages { get; set; }

        public long StockQty { get; set; }

    }
}
