namespace IS4439_Project_1.DAO;

using System.Diagnostics.Tracing;
using IS4439_Project_1.Data;
using IS4439_Project_1.Models;
using Microsoft.EntityFrameworkCore;

public class GameDAO
{
    private readonly IS4439_Project_1Context _context;

    public GameDAO(IS4439_Project_1Context context)
    {
        _context = context;
    }

    public async Task<List<Game>> GetAllGamesAsync()
    {
        return await _context.Game.ToListAsync();
    }

    public async Task<Game> GetGameByIdAsync(int id)
    {
        return await _context.Game.FirstOrDefaultAsync(g => g.GameId == id);
    }
}

