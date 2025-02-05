using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TalIdentity.Data;
using TalIdentity.DTOs;
using TalIdentity.Models;

namespace TalIdentity.Controllers
{
    public class UsersController : BaseController
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<IActionResult> GetUser(string id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return ErrorResponse("User not found", 404);

            return SuccessResponse(new UserDto
            {
                Id = user.Id,
                Email = user.Email,
                FullName = user.FullName,
                CreatedDate = user.CreatedDate,
                UpdatedDate = user.UpdatedDate,
                UpdatedBy = user.UpdatedBy
            });
        }
    }
}
