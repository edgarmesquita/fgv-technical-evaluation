using System.Configuration;

namespace FGV.TechnicalEvaluation.WebApi.Application.Configuration
{
    public class SortingsCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new SortingCollection();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((SortingCollection)element).Name;
        }

        public SortingCollection this[int index]
        {
            get { return (SortingCollection)BaseGet(index); }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        public void Add(SortingCollection connectionString)
        {
            BaseAdd(connectionString);
        }

        public void Remove(SortingCollection connectionString)
        {
            BaseRemove(connectionString.Name);
        }

        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);
        }

        public void Remove(string name)
        {
            BaseRemove(name);
        }

        public void Clear()
        {
            BaseClear();
        }
    }
}
