namespace Commands.Core
{
    public interface ICommand
    {
        void Execute();
    }

    public interface ICommand<TType>
    {
        void Execute(TType parameter);
    }
}