namespace MarketingCampaign.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CampaignController : ControllerBase
{
  [HttpGet]
  public IActionResult Get() => Ok("Campaigns up");
}