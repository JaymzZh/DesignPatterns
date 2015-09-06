using System.Collections.Generic;

namespace Flyweight
{
    public class WebSiteFactory
    {
        private Dictionary<string, WebSite> flyweights = new Dictionary<string, WebSite>();

        public WebSite GetWebSiteCategory(string key)
        {
            if(!flyweights.ContainsKey(key))
                flyweights.Add(key, new ConcreteWebSite(key));
            return flyweights[key];
        }

        public int GetWebSiteCount()
        {
            return flyweights.Count;
        }
    }
}
