using ProjetoMaster.Application.Entities;
using ProjetoMaster.Application.Interfaces;
using ProjetoMaster.Domain.Interfaces.Services;
using ProjetoMaster.Domain.Interfaces.Services;
using ProjetoMaster.Domain.Services;
using ProjetoMaster.Infra.Data.Repositories;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ProjetoMaster.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(ProjetoMaster.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace ProjetoMaster.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof (IAppServiceBase<>)).To(typeof (AppServiceBase<>));
            kernel.Bind<IPessoaAppService>().To<PessoaAppService>();
            kernel.Bind<IUsuarioAppService>().To<UsuarioAppService>();
            kernel.Bind<IDadosSensorAppService>().To<DadosSensorAppService>();

            //kernel.Bind<IClienteAppService>().To<ClienteAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IPessoaService>().To<ProdutoService>();
            kernel.Bind<IUsuarioService>().To<UsuarioService>();
            kernel.Bind<IDadosSensorService>().To<DadosPulseiraService>();
            
            //kernel.Bind<IClienteService>().To<ClienteService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IPessoaRepository>().To<PessoaRepository>();
            kernel.Bind<IUsuarioRepository>().To<UsuarioRepository>();
            kernel.Bind<IDadosSensorRepository>().To<DadosSensorRepository>();
            
            //kernel.Bind<IClienteRepository>().To<ClienteRepository>();
        }        
    }
}
