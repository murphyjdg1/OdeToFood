using System.Configuration;

namespace OdeToFood.Configuration
{
    public class RedirectSection : ConfigurationSection
    {
        [ConfigurationProperty("",IsDefaultCollection = true)]
        [ConfigurationCollection(typeof(RedirectCollection))]
        public RedirectCollection Redirects
        {
            get { return (RedirectCollection)base[""]; }
        }
    }
}