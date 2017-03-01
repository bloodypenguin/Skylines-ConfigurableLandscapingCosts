using System.Xml.Serialization;
using ConfigurableLandscapingCosts.Options;

namespace ConfigurableLandscapingCosts
{
    public class ModOptions : IModOptions
    {
        public ModOptions()
        {
            landscapingCost = 10;
        }

        [TextField("Landscaping cost (default: 10)", "Configurer", "OnCostChanged")]
        public int landscapingCost { internal set; get; }

        [XmlIgnore]
        public string FileName => "CSL-ConfigurableLandscapingCosts.xml";
    }
}