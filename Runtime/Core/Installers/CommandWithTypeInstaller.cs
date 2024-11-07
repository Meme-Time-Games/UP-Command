using DependencyInjector.Installers;

namespace Commands.Core
{
    public abstract class CommandWithTypeInstaller<TType> : SingleMonoInstaller<ICommandWithType<TType>>
    {

    }
}