using MediatR;
using Post.Infrastructure.Dtos.RequestModels.V1;
using Post.Infrastructure.Dtos.ResultObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Post.Domain.Queries.V1
{
    public class GetTop10RecentQuery : IRequest<AbstractResult<PostModel>>
    {

        public GetTop10RecentQuery()
        {
        }
    }
}
