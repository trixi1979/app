using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace app.web
{
    public class CommandRegistry : IFindCommandsThatCanProcessRequests
    {
        private readonly IEnumerable<IProcessOneRequest> _all_commands;

        public CommandRegistry(IEnumerable<IProcessOneRequest> all_commands)
        {
            _all_commands = all_commands;
        }

        public IProcessOneRequest get_the_command_that_can_process(IProvideRequestDetails request)
        {
            return _all_commands.FirstOrDefault(x => x.can_process(request));
        }
    }
}