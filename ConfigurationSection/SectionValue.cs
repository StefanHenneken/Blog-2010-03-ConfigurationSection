using System;
using System.Configuration;

namespace MySection
{
    class SectionValue : ConfigurationElement
    {
        [ConfigurationProperty("id", DefaultValue = "1", IsRequired = true, IsKey = true)]
        [IntegerValidator(MinValue = 1, MaxValue = 1000, ExcludeRange = false)]
        public int Id
        {
            get { return (base["id"] == null) ? (int)0 : (int)base["id"]; }
            set { base["id"] = value; }
        }       
        [ConfigurationProperty("valueAttribute", IsRequired = true, IsKey = false)]
        [StringValidator(InvalidCharacters = "~!@#$%^&*", MinLength = 0, MaxLength = 60)]
        public string Attribute
        {
            get { return base["valueAttribute"] as string; }
            set { base["valueAttribute"] = value; }
        }
        [ConfigurationProperty("newValue", IsRequired = true, IsKey = false)]
        public double NewValue
        {
            get { return (base["newValue"] == null) ? (double)0 : (double)base["newValue"]; }
            set { base["newValue"] = value; }
        }
        [ConfigurationProperty("oldValue", IsRequired = true, IsKey = false)]
        public double OldValue
        {
            get { return (base["oldValue"] == null) ? (double)0 : (double)base["oldValue"]; }
            set { base["oldValue"] = value; }
        }
    }
}
