using MediatR;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Post.Domain.Queries.V1;
using Post.Domain.SeedWork;
using Post.Infrastructure.DAL.IService;
using Post.Infrastructure.Dtos.Configurations;
using Post.Infrastructure.Dtos.RequestModels.V1;
using Post.Infrastructure.Dtos.ResultObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Post.Domain.QueryHandlers.V1
{
    public class GetTop10RecentQueryHandler : IRequestHandler<GetTop10RecentQuery, AbstractResult<PostModel>>, IQueryHandlerInjectable
    {
        //private readonly IDatabaseService _dbService;
        private readonly IOptions<AppSettingsConfiguration> _config;

        public GetTop10RecentQueryHandler(IOptions<AppSettingsConfiguration> config)
        {
           // _dbService = dbService;
            _config = config;
        }

        public async Task<AbstractResult<PostModel>> Handle(GetTop10RecentQuery request, CancellationToken cancellationToken)
        {
            var data = new PostModel { Description = "Test" };
            return new AppErrorResult<PostModel>(null, "Data not found");
        }

    }
}
