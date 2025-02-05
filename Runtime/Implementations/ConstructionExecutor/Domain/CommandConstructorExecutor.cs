namespace Commands.Core
{
    public class CommandConstructorExecutor
    {
        public CommandConstructorExecutor(ICommand command)
        {
            command.Execute();
        }
    }
}