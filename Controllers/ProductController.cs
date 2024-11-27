namespace IS4439_Project_1.Controllers;

using System.Net.Http.Headers;
using IS4439_Project_1.DAO;
using IS4439_Project_1.Data;
using IS4439_Project_1.Models;
using IS4439_Project_1.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


[Authorize]
public class ProductController : Controller
{
    private readonly GameDAO _gameDAO;

    public ProductController(IS4439_Project_1Context context)
    {
        _gameDAO = new GameDAO(context);
    }

    public async Task<IActionResult> Store()
    {
        var games = await _gameDAO.GetAllGamesAsync();
        return View(games);
    }

    [Route("Product/ProductDetail/{id:int}")]
    public async Task<IActionResult> ProductDetail(int id)
    {
        // Fetch the game by ID from the DAO
        var game = await _gameDAO.GetGameByIdAsync(id);

        if (game == null)
        {
            return NotFound(); // If the game doesn't exist, return 404 Not Found
        }

        return View(game); // Return the game details to the view
    }

}
