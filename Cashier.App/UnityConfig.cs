using System;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml;
using Unity;
using Cashier.Data.NHibernate;
using Cashier.Data;
using Cashier.Migration;
using Cashier.DataService;
using Cashier.Data.NHibernate.Repository;
using Unity.Lifetime;

namespace Cashier.App
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        

        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            

            string hibernateCfgFileName = "hibernate.cfg.xml";
            XElement root = XElement.Load(hibernateCfgFileName);
            var nsMgr = new XmlNamespaceManager(new NameTable());
            nsMgr.AddNamespace("NC", "urn:nhibernate-configuration-2.2");
            string connectionString = root.XPathSelectElement("//NC:property[@name='connection.connection_string']", nsMgr).Value;

            //регистрация NHibernate-репозиториев
            NHibernateDataInstaller.Install(container, new PerResolveLifetimeManager());
            NHibernateRepositoryInstaller.Install(container);
           
            DataInstaller.Install(container, new PerResolveLifetimeManager());

            //регистрация Мигратора
            MigratorInstaller.Install(container, connectionString);

            //регистрация дата-сервисов
            DataServiceInstaller.Install(container);


            container.RegisterType<FormMain>();


        }
        
    }
    
}
