using Observer_Design_Pattern.DAL.Entities;
using System.Collections.Generic;

namespace Observer_Design_Pattern.ObserverDesignPattern
{//Subject Nesnesi:Observer nesnelerini tutan bir liste ve bu nesnelerin haberdar
    //edilmesini sağlayacak notify metodu
    //Observer nesnelerini kaydetme, silme ve haberdar etme metodları
    public class UserObserverObject
    {
        //Kullanıcı oluşturulacak, indirim yapılacak, kullanıcıya mail gönderilecek.
        private readonly List<IUserObserver> _userObservers;
        public UserObserverObject()
        {
            _userObservers = new List<IUserObserver>();
        }
        public void RegisterObserver(IUserObserver userObserver)
        {
            _userObservers.Add(userObserver);
        }
        //Discount maili gitmesin mesela
        public void RemoveObserver(IUserObserver userObserver)
        {
            _userObservers.Remove(userObserver);
        }

        public void NotifyObserver(AppUser appUser)
        {
            _userObservers.ForEach(x =>
            {
                x.CreateUser(appUser);
            });
        }
    }
}
