namespace Commands.Core
{
    public interface ICommandWithType<TType>
    {
        void Execute(TType parameter);
    }
}