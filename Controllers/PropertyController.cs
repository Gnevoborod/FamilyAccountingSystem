using FamilyAccountingSystem.Controllers.Dtos.Property;
using FamilyAccountingSystem.Interfaces.Services;
using FamilyAccountingSystem.Infrastructure.Mappers;
using Microsoft.AspNetCore.Mvc;


namespace FamilyAccountingSystem.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("attribute")]
    public class PropertyController : Controller
    {
        private readonly IPropertyService _attributeService;
        public PropertyController(IPropertyService attributeService)
        {
            _attributeService = attributeService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAttributesForFamily([FromQuery] long familyId)
        {
            var result = await _attributeService.GetPropertiesAsync(familyId);

            return Ok(new PropertyListDto {
                Properties = result.FromModelListToDtoList()
            }
            );
        }
    }
}
