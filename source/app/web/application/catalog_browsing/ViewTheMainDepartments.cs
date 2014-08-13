using app.web.core;

namespace app.web.application.catalog_browsing
{
  public class ViewTheMainDepartments : ISupportAUserStory
  {
      private readonly IFindDepartments _department_finder;

      public ViewTheMainDepartments(IFindDepartments department_finder)
      {
          _department_finder = department_finder;
      }

      public void process(IProvideRequestDetails request)
    {
      _department_finder.get_the_main_departments(); 
    }
  }
}