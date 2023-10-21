using Project.Validations;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class InsertProductClassModel
    {
        [Required]
        //Associated Property
        public string DataBaseType { get; set; } = "";


        [RequiredIfNot(nameof(DataBaseType), "FireStore", ErrorMessage = "The RealTime List Name field is required.")]
        public string RealTimeDBProductsListName { get; set; } = "";



        [RequiredIf(nameof(DataBaseType), "RealTime", ErrorMessage = "The Id field is required.")]
        //Dependent Property
        public string Id { get; set; } = "";

        [Required]
        public bool IsVisible { get; set; } = true;

        [Required]
        public string Title { get; set; } = "";

        [Required]
        public string Category { get; set; } = "";

        [Required]
        public string Brand { get; set; } = "";


        [RequiredIfNot(nameof(DataBaseType), "FireStore", ErrorMessage = "The KeyWords field is required.")]
        public string KeyWords { get; set; } = "";


        [RequiredIfNot(nameof(DataBaseType), "RealTime", ErrorMessage = "The Description field is required.")]
        public string Description { get; set; } = "";


        public List<String> DescrKeyPointsTitle { get; set; } = new List<String> { new String { Value = "" } };
        public List<String> DescrKeyPointsInfo { get; set; } = new List<String> { new String { Value = "" } };
        public class String
        {
            public string Value = "";
        }

        public List<String> ImgURLs { get; set; } = new List<String> { new String { Value = "" } };


        [RequiredIfNot(nameof(DataBaseType), "RealTime", ErrorMessage = "The Details field is required.")]
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
