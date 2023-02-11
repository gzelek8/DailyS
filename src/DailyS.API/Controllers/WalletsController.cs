using DailyS.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DailyS.API.Controllers;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
public class WalletsController : ControllerBase
{
    // private readonly DailySContext _context;

    // public WalletsController(DailySContext context)
    // {
    //     _context = context;
    // }

    // GET: api/Wallets
    // [HttpGet]
    // public async Task<ActionResult<IEnumerable<Wallet>>> GetWallets()
    // {
    //     return await _context.Wallets.ToListAsync();
    // }

    // GET: api/Wallets/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Wallet>> GetWallet(int id)
    {
        await Task.Delay(1000);
        return Ok(new Wallet
        {
            Id = id,
            Name = $"Wallet {id}",
            Balance = 1000
        });
    }

    // // PUT: api/Wallets/5
    // // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    // [HttpPut("{id}")]
    // public async Task<IActionResult> PutWallet(int id, Wallet wallet)
    // {
    //     if (id != wallet.Id)
    //     {
    //         return BadRequest();
    //     }

    //     _context.Entry(wallet).State = EntityState.Modified;

    //     try
    //     {
    //         await _context.SaveChangesAsync();
    //     }
    //     catch (DbUpdateConcurrencyException)
    //     {
    //         if (!WalletExists(id))
    //         {
    //             return NotFound();
    //         }
    //         else
    //         {
    //             throw;
    //         }
    //     }

    //     return NoContent();
    // }

    // // POST: api/Wallets
    // // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    // [HttpPost]
    // public async Task<ActionResult<Wallet>> PostWallet(Wallet wallet)
    // {
    //     _context.Wallets.Add(wallet);
    //     await _context.SaveChangesAsync();

    //     return CreatedAtAction("GetWallet", new { id = wallet.Id }, wallet);
    // }

    // // DELETE: api/Wallets/5
    // [HttpDelete("{id}")]
    // public async Task<IActionResult> DeleteWallet(int id)
    // {
    //     var wallet = await _context.Wallets.FindAsync(id);
    //     if (wallet == null)
    //     {
    //         return NotFound();
    //     }

    //     _context.Wallets.Remove(wallet);
    //     await _context.SaveChangesAsync();

    //     return NoContent();
    // }

    // private bool WalletExists(int id)
    // {
    //     return _context.Wallets.Any(e => e.Id == id);
    // }
}
