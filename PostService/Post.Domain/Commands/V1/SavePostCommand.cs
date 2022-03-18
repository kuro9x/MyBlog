using MediatR;
using Post.Infrastructure.Dtos.RequestModels.V1;
using Post.Infrastructure.Dtos.ResultObjects;

namespace Post.Domain.Commands.V1
{
    public class SavePostCommand : IRequest<AbstractResult<PostModel>>
    {
        public PostModel RecallRequestModel { get; }

        public SavePostCommand(PostModel requestModel)
        {
            RecallRequestModel = requestModel;
        }
    }
}
