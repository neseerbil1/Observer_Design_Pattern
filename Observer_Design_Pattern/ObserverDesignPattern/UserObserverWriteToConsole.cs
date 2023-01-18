using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Observer_Design_Pattern.DAL.Entities;
using System;

namespace Observer_Design_Pattern.ObserverDesignPattern
{//CreateUser metodunu override eder
    public class UserObserverWriteToConsole:IUserObserver
    {//Bir hizmet nesnesini almak için bir mekanizma tanımlar; yani, bir nesne
      //  diğer nesnelere özel destek sağlar.
        private readonly IServiceProvider _serviceProvider;
        public UserObserverWriteToConsole(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void CreateUser(AppUser appUser)
        {//loglama:yapılan işlemleri kayıt altına alma
            var logger = _serviceProvider.GetRequiredService<ILogger<UserObserverWriteToConsole>>();
            logger.LogInformation($"{appUser.Id + " nolu" + appUser.Name + " " + appUser.Surname} isimli kullanıcı sisteme kayıt edildi");
           
        }
    }
}
