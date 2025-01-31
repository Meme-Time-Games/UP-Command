using DependencyInjector.Core;
using DependencyInjector.Installers;
using UnityEngine;

namespace Commands.Core
{
    public class CommandUpdateFrameExecutorInstaller : SingleMonoInstaller<CommandUpdateFrameExecutor>
    {
        [Inject] private ICommand _commandExecute;

        protected override CommandUpdateFrameExecutor GetData()
        {
            CommandUpdateFrameExecutor commandUpdateFrameExecutor = new GameObject("CommandUpdateFrameExecutor").AddComponent<CommandUpdateFrameExecutor>();
            commandUpdateFrameExecutor.transform.SetParent(transform);
            commandUpdateFrameExecutor.Install(_commandExecute);

            return commandUpdateFrameExecutor;
        }
    }
}