using Microsoft.AspNetCore.Mvc;

namespace FamilyAccountingSystem.Controllers
{
    [Route("members")]
    [Produces("application/json")]
    [ApiController]
    public class MemberController : Controller
    {
        /// <summary>
        /// Создание члена семьи
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost("member")]
        public Task CreateMember()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Изменение данных члена семьи
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPut("member")]
        public Task EditMember()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Получение данных члена семьи по id
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpGet("member")]
        public Task GetMemberInfo()
        {
            throw new NotImplementedException();

        }

        /// <summary>
        /// Поиск члена семьи
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost("member/find")]
        public Task FindMember()
        { 
            throw new NotImplementedException(); 
        }


    }
}
