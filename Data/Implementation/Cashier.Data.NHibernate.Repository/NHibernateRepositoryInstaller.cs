using Cashier.Data.Repository;
using Cashier.Entity;
using Unity;

namespace Cashier.Data.NHibernate.Repository
{
    public static class NHibernateRepositoryInstaller
    {
        public static void Install(IUnityContainer container)
        {
            
            //регистрация репозиториев
            container.RegisterType<IRepository, BaseRepository>();

            container.RegisterType<IBaseRepository<Catalog>, BaseRepository<Catalog>>();
            container.RegisterType<IBaseRepository<SaleDocument>, BaseRepository<SaleDocument>>();
            container.RegisterType<IBaseRepository<SaleDocumentItem>, BaseRepository<SaleDocumentItem>>();
            container.RegisterType<IBaseRepository<Stock>, BaseRepository<Stock>>();
        }
        
    }
}
