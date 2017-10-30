using NHibernate;
using Unity;
using Unity.Lifetime;
using Unity.Injection;

namespace Cashier.Data.NHibernate
{
    public static class NHibernateDataInstaller
    {
        public static void Install(IUnityContainer container, LifetimeManager lifetimeManager)
        {
            //регистрация ISession
            container.RegisterType<ISession>(new InjectionFactory(c => NHibernateSessionManager.Instance.GetSession()));
            container.RegisterType<ISession>(lifetimeManager);
            
            
            
        }
    }
}
