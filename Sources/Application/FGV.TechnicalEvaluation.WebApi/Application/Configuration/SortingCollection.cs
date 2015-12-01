using System.Configuration;

namespace FGV.TechnicalEvaluation.WebApi.Application.Configuration
{
    public class SortingCollection : ConfigurationElementCollection
    {
        [ConfigurationProperty("name", IsRequired = true, IsKey = true)]
        public string Name
        {
            get
            {
                return (string)this["name"];
            }
            set
            { this["name"] = value; }
        }

        [ConfigurationProperty("type", IsRequired = true)]
        public string Type
        {
            get { return (string) this["type"]; }
            set { this["type"] = value; }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new SortingElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((SortingElement)element).Column;
        }

        public SortingElement this[int index]
        {
            get { return (SortingElement)BaseGet(index); }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        public void Add(SortingElement connectionString)
        {
            BaseAdd(connectionString);
        }

        public void Remove(SortingElement connectionString)
        {
            BaseRemove(connectionString.Column);
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
