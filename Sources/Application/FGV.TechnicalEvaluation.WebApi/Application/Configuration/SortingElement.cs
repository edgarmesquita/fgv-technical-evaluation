using System.Configuration;

namespace FGV.TechnicalEvaluation.WebApi.Application.Configuration
{
    public class SortingElement : ConfigurationElement
    {
        [ConfigurationProperty("column", IsRequired = true, IsKey = true)]
        public string Column
        {
            get { return (string)this["column"]; }
            set { this["column"] = value; }
        }

        [ConfigurationProperty("ascending", IsRequired = true, IsKey = false)]
        public bool Ascending
        {
            get { return (bool)this["ascending"]; }
            set { this["ascending"] = value; }
        }
    }
}
