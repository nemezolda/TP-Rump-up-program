using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace ModulesProject
{
    public class MainListModule : IModule
    {
        private readonly IRegionManager regionManager;
        public MainListModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.MainView));
            //regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.EditEmployeeView));
        }
    }
}
