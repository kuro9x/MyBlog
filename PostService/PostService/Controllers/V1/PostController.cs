using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Post.Domain.Commands.V1;
using Post.Domain.Queries.V1;
using System.Threading.Tasks;

namespace Post.API.Controllers.V1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class PostController : ControllerBase
    {
        private readonly ILogger<PostController> _logger;
        private readonly IMediator _mediator;

        public PostController(
            ILogger<PostController> logger,
            IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("top-10-recent")]
        public async Task<IActionResult> GetTop10PostRecent()
        {
            _logger.LogInformation("Start get top 10 posts recent");

            var cmd = new GetTop10RecentQuery();
            var response = await _mediator.Send(cmd);

            if (!response.IsSuccess)
            {
                _logger.LogWarning(response.PlainTextMessages);
                return BadRequest(response);
            }

            _logger.LogInformation($"End Save Prepurchase - Payment info. Message: {response.PlainTextMessages}");

            return Ok(response);
        }

        //[HttpPost("top-10-recent")]
        //public Task<IActionResult> GetTop10PostRecent()
        //{
        //    _logger.LogInformation("Start get top 10 posts recent");

        //    var cmd = new SavePostCommand(new PrePurchaseRequestModel { PaymentInfo = requestModel });
        //    var response = await _mediator.Send(cmd);

        //    if (!response.IsSuccess)
        //    {
        //        _logger.LogWarning(response.PlainTextMessages);
        //        return BadRequest(response);
        //    }

        //    _logger.LogInformation($"End Save Prepurchase - Payment info. Message: {response.PlainTextMessages}");

        //    return Ok(response);
        //}

    }
}
