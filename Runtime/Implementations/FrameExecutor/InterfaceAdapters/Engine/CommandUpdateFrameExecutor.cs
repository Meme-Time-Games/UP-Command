using UnityEngine;

namespace Commands.Core
{
    public class CommandUpdateFrameExecutor : MonoBehaviour
    {
        private ICommand _commandExecute;

        public void Install(ICommand command)
        {
            _commandExecute = command;
        }

        private void Update()
        {
            _commandExecute.Execute();
        }
    }
}