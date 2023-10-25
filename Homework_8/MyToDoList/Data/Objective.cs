namespace MyToDoList.Data
{
    [Serializable]
    internal class Objective
    {
        public string Description { get; private set; }
        public string Created { get; private set; }
        public string FinishBefore { get; private set; }
        public string Finished { get; private set; }

        public Objective(string description, string finishBefore, string finished = "")
        {
            Description = description;
            Created = DateTime.Now.ToString();
            FinishBefore = finishBefore;
            Finished = finished;
        }

        public void Finish()
        {
            Finished = DateTime.Now.ToString();
        }
    }
}
