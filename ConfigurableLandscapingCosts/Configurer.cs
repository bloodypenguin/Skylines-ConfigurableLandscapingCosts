using System;
using ConfigurableLandscapingCosts.Options;

namespace ConfigurableLandscapingCosts
{
    public static class Configurer
    {
        public static void OnCostChanged(string str)
        {
            SetCostForOptions();
        }

        public static void SetCostForOptions()
        {
            if (!TerrainManager.exists)
            {
                return;
            }
            var properties = TerrainManager.instance.m_properties;
            if (properties == null)
            {
                return;
            }
            properties.m_dirtPrice = OptionsWrapper<ModOptions>.Options.landscapingCost;
        }
    }
}