namespace MyToDoList.Data
{
    public interface IObjective
    {
        public string Description { get; }
        public DateTime Created { get; }
        public DateTime FinishBefore { get; }
        public DateTime Finished { get; }
        void Finish();
    }
}
