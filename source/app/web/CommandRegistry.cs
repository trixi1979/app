using System.Collections;
using System.Collections.Generic;

namespace app.web
{
    public class CommandRegistry : IFindCommandsThatCanProcessRequests
    {
        private readonly IEnumerable<IProcessOneRequest> _allCommands;

        public CommandRegistry(IEnumerable<IProcessOneRequest> all_commands)
        {
            _allCommands = all_commands;
        }

        public IProcessOneRequest get_the_command_that_can_process(IProvideRequestDetails request)
        {
            foreach (var command in _allCommands)
            {
                if (command.can_process(request))
                    return command;
            }
            return null;
        }
    }
}