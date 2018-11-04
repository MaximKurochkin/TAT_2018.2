

namespace DEV_5
{
    /// <summary>
    /// Interface ICommand
    /// contains method Execute
    /// which will be implemented in the heirs
    /// </summary
    /// <param name="stock">storage in which we keep cars</param>

    interface ICommand
    {
        void Execute(Stock stock);
    }
}
