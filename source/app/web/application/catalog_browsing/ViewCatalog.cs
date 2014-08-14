using app.web.application.catalog_browsing.stubs;
using app.web.aspnet;
using app.web.core;

namespace app.web.application.catalog_browsing
{
    public class ViewCatalog<InputType, CatalogItemType> : ISupportAUserStory where CatalogItemType: IHaveAName
    {
        IFind<InputType, CatalogItemType> finder;
        IDisplayInformation display;

        public ViewCatalog(IFind<InputType, CatalogItemType> finder, IDisplayInformation display)
        {
            this.finder = finder;
            this.display = display;
        }

        public ViewCatalog()
            : this(new StubFinder<InputType, CatalogItemType>(),
                new WebFormDisplayEngine())
        {
        }

        public void process(IProvideRequestDetails request)
        {
            var input = request.map<InputType>();
            var results = finder.find_items(input);

            display.display(results);
        }
    }
}