using FluentValidation;
using OnionApp.Domain.Entities;

namespace OnionApp.Application.Validators
{
    public class ProductValidator: AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün adı boş bırakılamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Ürün açıklaması boş bırakılamaz");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Kategori boş bırakılamaz");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün fiyatı boş bırakılamaz")
                                 .GreaterThanOrEqualTo(0).WithMessage("Ürün fiyatı eksi değer olamaz")
                                 .LessThan(10000).WithMessage("Ürün fiyatı maksimum 10.000 TL olmalıdır");
        }
    }
}
