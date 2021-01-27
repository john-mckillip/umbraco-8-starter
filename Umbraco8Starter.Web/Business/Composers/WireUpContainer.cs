using Umbraco.Core;
using Umbraco.Core.Composing;
using Zone.UmbracoMapper.V8;

namespace Umbraco8Starter.Web.Business.Composers
{
    public class WireUpContainer
    {
        public void Compose(Composition composition)
        {
            #region Scoped Services


            #endregion

            #region Singleton Services

            #endregion

            #region Transient Services         

            composition.Register<IUmbracoMapper, UmbracoMapper>();

            #endregion

            
        }
    }
}