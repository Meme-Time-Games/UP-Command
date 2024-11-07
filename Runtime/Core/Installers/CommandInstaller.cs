using DependencyInjector.Installers;

namespace Commands.Core
{
    public abstract class CommandInstaller : SingleMonoInstaller<ICommand>
    {

    }
}