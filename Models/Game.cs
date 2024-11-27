using IS4439_Project_1.DAO;
using System.ComponentModel.DataAnnotations;

namespace IS4439_Project_1.Models;

// defining data structure for game
    public class Game
    {

    // Defining all parameters and all ones that are Required and any certain conditions they have to meet
    [Key]
    public int GameId {get; set;}

    [Required(ErrorMessage = "Game Name is required.")]
    [StringLength(100, ErrorMessage = "Game Name cannot exceed 100 characters.")]
    public string? GameName { get; set; }

    [Required(ErrorMessage = "Game Price is required.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Game Price must be greater than 0.")]
    public double GamePrice { get; set; }

    [Required(ErrorMessage = "Game Description is required.")]
    [StringLength(100, ErrorMessage = "Game Description cannot exceed 100 characters.")]
    public string? GameDescription { get; set; }

    [Required]
    public string GameImageName { get; set; } 

    [Required(ErrorMessage = "Game Rating is required.")]
    [Range(1, 5, ErrorMessage = "Game Rating must be between 1 and 5.")]
    public int GameRating { get; set; }

    public int DeverloperId { get; set; }

    public Developer Developer { get; set; }

    // full arguments constructor used in the DAO class to make game
    public Game(int gameId, string gameName, double gamePrice, string gameDescription, string gameImageName, int gameRating)
    {
        GameId = gameId;
        GameName = gameName;
        GamePrice = gamePrice;
        GameDescription = gameDescription;
        GameImageName = gameImageName;
        GameRating = gameRating;
    }
    // Empty Constuctor
    public Game() 
{
}

}
