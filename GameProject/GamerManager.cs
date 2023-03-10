using System;

namespace GameProject;

//MicroService
public class GamerManager : IGamerService
{
    private IUserValidationService _userValidationService;

    public GamerManager(IUserValidationService userValidationService)
    {
        _userValidationService = userValidationService;
    }

    public void Add(Gamer gamer)
    {
        if (_userValidationService.Validate(gamer))
        {
            Console.WriteLine("Kayıt oldunuz");
        }
        else
        {
            Console.WriteLine("Doğrulama başarısız. Kayıt başarısız.");
        }
    }

    public void Update(Gamer gamer)
    {
        Console.WriteLine("Kayıt güncellendi");
    }

    public void Delete(Gamer gamer)
    {
        Console.WriteLine("Kayıt silindi");
    }
}