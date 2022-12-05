using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class OgretmenlerValidator : AbstractValidator<Ogretmenler>
    {
        public OgretmenlerValidator()
        {
            RuleFor(x => x.AdSoyad).NotEmpty().WithMessage("Lütfen AdSoyad giriniz.");
            RuleFor(x => x.Brans).NotEmpty().WithMessage("Lütfen Branş giriniz.");
            RuleFor(x => x.TelefonNo).NotEmpty().WithMessage("Lütfen Telefon No giriniz.");
            RuleFor(x => x.KullanıcıAdı).NotEmpty().WithMessage("Lütfen Kullanıcı Adı giriniz.");
            RuleFor(x => x.Sifre).NotEmpty().WithMessage("Lütfen Şifre giriniz.");

        }
    }
}
