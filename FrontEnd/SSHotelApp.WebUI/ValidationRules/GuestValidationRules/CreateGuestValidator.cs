using FluentValidation;
using SSHotelApp.WebUI.Dtos.GuestDto;

namespace SSHotelApp.WebUI.ValidationRules.GuestValidationRules
{
    public class CreateGuestValidator : AbstractValidator<CreateGuestDto>
    {
        public CreateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Alanı Boş Geçilemez..");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Soyad Alanı Boş Geçilemez..");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir Alanı Boş Geçilemez..");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapınız..");
            RuleFor(x => x.SurName).MinimumLength(3).WithMessage("Lütfen en az 2 karakter veri girişi yapınız..");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapınız..");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapınız..");
            RuleFor(x => x.SurName).MaximumLength(30).WithMessage("Lütfen fazla az 20 karakter veri girişi yapınız..");
            RuleFor(x => x.City).MaximumLength(30).WithMessage("Lütfen fazla az 30 karakter veri girişi yapınız..");
        }
    }
}
