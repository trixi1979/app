namespace app.web
{
  public class RequestCommand : IProcessOneRequest
  {
      private readonly IMatchARequest _request_matcher;

      public RequestCommand(IMatchARequest request_matcher)
      {
          _request_matcher = request_matcher;
      }

      public void process(IProvideRequestDetails request)
    {
      throw new System.NotImplementedException();
    }

    public bool can_process(IProvideRequestDetails request)
    {
      return _request_matcher(request);
    }
  }
}