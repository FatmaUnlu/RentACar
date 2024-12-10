using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Features.Brands.Commands.Create
{
    public class CreateBrandCommand:IRequest<CreatedBrandResponse>
    {
        public string Name { get; set; }

        public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
        {
            public async Task<CreatedBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
            {
                CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
                createdBrandResponse.Id = new Guid();
                createdBrandResponse.Name = request.Name;

                return createdBrandResponse;

            }
        }
    }
}
