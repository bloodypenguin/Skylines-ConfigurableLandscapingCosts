using ConfigurableLandscapingCosts.Options;
using ICities;

namespace ConfigurableLandscapingCosts
{
 
    public class Mod : IUserMod
    {
        public string Name => "Configurable Landscaping Costs";

        public string Description => "Allows to set landcaping cost (including making it free)";

        public void OnSettingsUI(UIHelperBase helper)
        {
            helper.AddOptionsGroup<ModOptions>();
        }
    }
}