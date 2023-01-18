using Observer_Design_Pattern.DAL.Entities;

namespace Observer_Design_Pattern.ObserverDesignPattern
{//abone olacak; abona olduğu zaman verileri veri tabanına kaydedilecek;indirim uygulanacak ve mail atılacak
    public interface IUserObserver
    {
        void CreateUser(AppUser appUser);   

    }
}
