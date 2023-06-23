using FamilyAccountingSystem.Infrastructure.Exceptions;
using System.Security.Claims;

namespace FamilyAccountingSystem.Infrastructure.Extensions
{
    public static class AuthExtensions
    {
        public static long GetUserId(this ClaimsPrincipal claims)
        {
            var employeeId = claims.Claims.FirstOrDefault(x => x.Type == ClaimTypes.PrimarySid)?.Value;
            if (employeeId == null)
                throw new ApiException(ExceptionEvents.UserIdUndefined);
            return Int64.Parse(employeeId);
        }
    }
}
