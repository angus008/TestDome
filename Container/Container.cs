using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity.Configuration;
using Microsoft.Practices.Unity;
using System.Configuration;

namespace RepositoryContainer
{
    public class Container
    {
        private static IUnityContainer container;
        public Container()
        {
            if (container == null)
            {
                var unityConfig = System.AppDomain.CurrentDomain.BaseDirectory + @"Repository.config";
                var fileMap = new ExeConfigurationFileMap() { ExeConfigFilename = unityConfig };
                var configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

                container = new UnityContainer();
                UnityConfigurationSection unity = (UnityConfigurationSection)configuration.GetSection("UintRepository");
                unity.Configure(container);
            }
        }

        public T Resolve<T>()
        {
            return container.Resolve<T>();
        }
    }
}
