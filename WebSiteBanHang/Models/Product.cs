namespace WebSiteBanHang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    [Table("Product")]
    public partial class Product
    {
        [Key]
        [Required]
        [StringLength(20)]
        public string idProduct { get; set; }

        [Required]
        [StringLength(20)]
        public string nameProduct { get; set; }

        [Required]
        [StringLength(20)]
        public string pictureProduct { get; set; }

        [Required]
        [Range(1, 1000000)]
        [DataType(DataType.Currency)]
        public int? priceProduct { get; set; }

        [Required]
        [Range(1, 5)]
        [DataType(DataType.Currency)]
        public int? rateProduct { get; set; }

        [Required]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public int? qualityProduct { get; set; }

        [Required]
        [StringLength(2000)]
        public string descriptionProduct { get; set; }

        [Required]
        [StringLength(20)]
        public string weightProduct { get; set; }

        [Required]
        [StringLength(20)]
        public string dismensionProduct { get; set; }

        [Required]
        [StringLength(20)]
        public string idCategory { get; set; }

        [Required]
        [StringLength(20)]
        public string idUser { get; set; }

        public virtual Category Category { get; set; }

        public virtual UserProduct UserProduct { get; set; }
    }
}
