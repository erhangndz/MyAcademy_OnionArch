using MediatR;
using OnionApp.Application.Base;

namespace OnionApp.Application.Features.Commands.CategoryCommands
{
    public class UpdateCategoryCommand: IRequest<BaseResult<object>>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
