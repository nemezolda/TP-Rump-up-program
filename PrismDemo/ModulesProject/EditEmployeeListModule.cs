using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace ModulesProject
{
    public class EditEmployeeListModule : IModule
    {
        private readonly IRegionManager regionManager;
        public EditEmployeeListModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.EditEmployeeView));
            //regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.EditEmployeeView));
        }
    }
}
