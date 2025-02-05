using DependencyInjector.Core;
using DependencyInjector.Installers;

namespace Commands.Core
{
    public class CommandConstructorExecutorInstaller : SingleMonoInstaller<CommandConstructorExecutor>
    {
        [Inject] private ICommand _command;
        protected override CommandConstructorExecutor GetData()
        {
            return new CommandConstructorExecutor(_command);
        }
    }
}