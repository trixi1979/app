using System.Collections.Generic;

namespace app.web.application.catalog_browsing
{
    public interface IFind<InputType, CatalogItemType>
    {
        IEnumerable<CatalogItemType> find_items(InputType input);
    }
}