using System;
using System.Collections.Generic;
using System.Linq;

namespace app.web.application.catalog_browsing.stubs
{
    public class StubFinder<InputType, CatalogItemType> : IFind<InputType, CatalogItemType> where CatalogItemType : IHaveAName
    {
        public IEnumerable<CatalogItemType> find_items(InputType input)
        {
            return Enumerable.Range(1, 100).Select(x => Activator.CreateInstance<CatalogItemType>());
        }
    }
}