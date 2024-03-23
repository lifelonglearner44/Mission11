using System.ComponentModel.DataAnnotations;

namespace Mission11.Models
{

    //For each book, we want to store the following info:
    //• Title
    //• Author
    //• Publisher
    //• ISBN

    //• Classification/Category
    //• Number of Pages
    //• Price
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        [Required]
        public required string Title { get; set; }
        [Required]
        public required string Author { get; set; }
        [Required]
        public required string Publisher { get; set; }
        [Required]
        public required string ISBN { get; set; }
        [Required]
        public required string Classification { get; set; }
        [Required]
        public required string Category { get; set; }
        [Required]
        public required int PageCount { get; set; }
        [Required]
        public required decimal Price { get; set; }
    }
}
