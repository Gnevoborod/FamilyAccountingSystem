using FamilyAccountingSystem.Infrastructure.Exceptions;
using FamilyAccountingSystem.Infrastructure.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading;

namespace FamilyAccountingSystem.Controllers
{
    [Route("authorization")]
    [Produces("application/json")]
    [ApiController]
    public class AuthorizationController:Controller
    {
        //это пока что заглушка для разработки
        /// <summary>
        /// Получение jwt токена
        /// </summary>
        /// <param name="id">Можем указать family_id на входе</param>
        /// <returns></returns>
        [HttpGet("token")]
        public IActionResult GetNewJwt([FromQuery]long id = 1)
        {
            var claims = new List<Claim>
            {
               new Claim(ClaimTypes.Role,"Отец"),
               new Claim(ClaimTypes.PrimarySid, "1"),
               new Claim(ClaimTypes.Sid, id.ToString())
            };

            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    claims: claims,
                    expires: DateTime.UtcNow.Add(TimeSpan.FromHours(24)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var token = new JwtSecurityTokenHandler().WriteToken(jwt);
            return Ok(token);
        }
    }
}
