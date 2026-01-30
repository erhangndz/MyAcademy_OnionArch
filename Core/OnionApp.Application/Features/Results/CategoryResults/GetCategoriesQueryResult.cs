using OnionApp.Application.Features.Results.ProductResults;

namespace OnionApp.Application.Features.Results.CategoryResults
{
    public class GetCategoriesQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<GetProductsQueryResult> Products { get; set; }
    }
}
