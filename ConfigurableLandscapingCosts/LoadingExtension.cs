using ICities;

namespace ConfigurableLandscapingCosts
{
    public class LoadingExtension : LoadingExtensionBase
    {
        public override void OnLevelLoaded(LoadMode mode)
        {
            base.OnLevelLoaded(mode);
            Configurer.SetCostForOptions();
        }
    }
}