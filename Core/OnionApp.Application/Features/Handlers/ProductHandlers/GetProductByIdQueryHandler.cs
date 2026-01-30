using Mapster;
using MediatR;
using OnionApp.Application.Base;
using OnionApp.Application.Contracts;
using OnionApp.Application.Features.Queries.ProductQueries;
using OnionApp.Application.Features.Results.ProductResults;
using OnionApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Application.Features.Handlers.ProductHandlers
{
    public class GetProductByIdQueryHandler(IRepository<Product> _repository) : IRequestHandler<GetProductByIdQuery, BaseResult<GetProductByIdQueryResult>>
    {
        public async Task<BaseResult<GetProductByIdQueryResult>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetByIdAsync(request.Id);
            if(product is null)
            {
                return BaseResult<GetProductByIdQueryResult>.Fail("Ürün bulunamadı");
            }

            var mappedProduct = product.Adapt<GetProductByIdQueryResult>();

            return BaseResult<GetProductByIdQueryResult>.Success(mappedProduct);
        }
    }
}
