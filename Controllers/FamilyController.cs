using Microsoft.AspNetCore.Mvc;

namespace FamilyAccountingSystem.Controllers
{
    [Route("families")]
    [Produces("application/json")]
    [ApiController]
    public class FamilyController : Controller
    {
        /// <summary>
        /// Запрос на добавление члена семьи
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost("reqest_to_join")]
        public Task RequestToJoin()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Создание семьи
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost("family")]
        public Task CreateFamily()
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Изменение семьи
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPut("family")]
        public Task EditFamily()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Получение данных о семье
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpGet("family")]
        public Task GetFamily()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Одобрить или отклонить присоединение к семье
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost("join_decision")]
        public Task JoinDecision()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Отправить приглашение на присоединение к семье
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost("send_invite")]
        public Task SendInvite()
        {
            throw new NotImplementedException();
        }
    }
}
