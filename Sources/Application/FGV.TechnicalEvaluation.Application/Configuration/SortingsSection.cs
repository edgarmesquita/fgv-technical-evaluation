using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGV.TechnicalEvaluation.Application.Configuration
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