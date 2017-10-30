using Cashier.Data.Repository;
using Unity;

namespace Cashier.Data.NHibernate.Repository
{
    public static class NHibernateRepositoryInstaller
    {
        public static void Install(IUnityContainer container)
        {
            
            //регистрация репозиториев
            container.RegisterType<IRepository, BaseRepository>();
                        
        }
        
    }
}
