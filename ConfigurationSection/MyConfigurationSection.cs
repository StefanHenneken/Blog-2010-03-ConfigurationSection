using System;
using System.Configuration;

namespace MySection
{
    class MyConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("values", IsDefaultCollection = true, IsRequired = true)]
        public SectionValueCollection SectionValues
        {
            get { return (SectionValueCollection)this["values"]  ?? new SectionValueCollection(); }
            set { base[""] = value; }
        }
    }
}
