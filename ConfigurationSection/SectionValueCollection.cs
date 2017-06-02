using System;
using System.Configuration;

namespace MySection
{
    class SectionValueCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new SectionValue();
        }
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((SectionValue)element).Id;
        }
        protected override string ElementName
        {
            get { return "value"; }
        }
        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.BasicMap; }
        }
        public SectionValue this[int index]
        {
            get { return base.BaseGet(index) as SectionValue; }
        }
    }
}
