using System.Web.Http;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace Umbraco8Starter.Web.Business.Composers
{
    public class WebApiComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Components().Append<WebApiComponent>();
        }

        public class WebApiComponent : IComponent
        {
            public void Initialize()
            {
                GlobalConfiguration.Configure(WebApiConfig.Register);
            }

            public void Terminate() { }
        }
    }
}