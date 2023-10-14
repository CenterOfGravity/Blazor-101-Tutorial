using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class InsertProductClassModel
    {
        [Required]
        public string DataBaseType { get; set; } = "";

        public string RealTimeDBProductsListName { get; set; } = "";

        public string Id { get; set; } = "";

        [Required]
        public bool IsVisible { get; set; } = true;

        [Required]
        public string Title { get; set; } = "";

        [Required]
        public string Category { get; set; } = "";

        [Required]
        public string Brand { get; set; } = "";

        [Required]
        public string KeyWords { get; set; } = "";

        [Required]
        public string Description { get; set; } = "";

        public List<String> DescrKeyPointsTitle { get; set; } = new List<String> { new String { Value = "" } };
        public List<String> DescrKeyPointsInfo { get; set; } = new List<String> { new String { Value = "" } };
        public class String
        {
            public string Value = "";
        }

        public List<String> ImgURLs { get; set; } = new List<String> { new String { Value = "" } };


        [Required]
        public string Details { get; set; } = "";

        public List<String> DetailsKeyPointsTitle { get; set; } = new List<String> { new String { Value = "" } };

        public List<String> DetailsKeyPointsInfo { get; set; } = new List<String> { new String { Value = "" } };


        public List<String> DiscountedPrices { get; set; } = new List<String> { new String { Value = "" } };
        public List<String> OriginalPrices { get; set; } = new List<String> { new String { Value = "" } };

        public List<String> Quantities { get; set; } = new List<String> { new String { Value = "" } };

        public List<String> Colors { get; set; } = new List<String> { new String { Value = "" } };

        public List<String> Sizes { get; set; } = new List<String> { new String { Value = "" } };
    }
}
