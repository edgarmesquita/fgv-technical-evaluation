using System.Configuration;

namespace FGV.TechnicalEvaluation.WebApi.Application.Configuration
{
    public class SortingsSection : ConfigurationSection
    {
        [ConfigurationProperty(null, IsDefaultCollection = true)]
        [ConfigurationCollection(typeof(SortingCollection),
           AddItemName = "sorting")]
        public SortingsCollection Sortings
        {
            get
            {
                return (SortingsCollection)base[""];
            }
        }
    }
}