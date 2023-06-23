using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace FamilyAccountingSystem.Infrastructure.Security
{
    public class AuthOptions
    {
        public const string ISSUER = "FamilyAccountingSystem";
        public const string AUDIENCE = "FamilyAccountingSystem";
        const string KEY = "FktrcfylhCthuttdbxGeirbyfitDc`Dc`Dc`CjdctvDc`";   // ключ для шифрации перенести в конфиг
        public static SymmetricSecurityKey GetSymmetricSecurityKey() =>
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));

    }
}
