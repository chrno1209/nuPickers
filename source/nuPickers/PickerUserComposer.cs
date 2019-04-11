using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nuPickers.Caching;
using nuPickers.EmbeddedResource;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace nuPickers
{
    [RuntimeLevel(MinLevel = RuntimeLevel.Run)]
    public class PickerUserComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Components().Append<CacheInvalidationComponent>();
            composition.Components().Append<EmbeddedResourceComponent>();
        }
    }
}
