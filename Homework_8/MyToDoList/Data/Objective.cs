namespace MyToDoList.Data
{
    [Serializable]
    internal class Objective : IObjective
    {
        public string? Description { get; private set; }

        public DateTime Created { get; private set; }

        public DateTime FinishBefore { get; private set; }

        public DateTime Finished { get; private set; }

        public Objective(string? description, DateTime finishBefore)
        {
            Description = description;
            Created = DateTime.Now;
            FinishBefore = finishBefore;
        }

        public void Finish()
        {
            Finished = DateTime.Now;
        }
    }
}
