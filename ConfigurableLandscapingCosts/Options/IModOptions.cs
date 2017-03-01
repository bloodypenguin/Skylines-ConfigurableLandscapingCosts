using System.Xml.Serialization;

namespace ConfigurableLandscapingCosts.Options
{
    public interface IModOptions
    {
        [XmlIgnore]
        string FileName
        {
            get;
        }
    }
}