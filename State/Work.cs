namespace State
{
    public class Work
    {
        private State currentState;

        public Work()
        {
            currentState = new ForenoonState();
        }

        public double Hour { get; set; }

        public bool TaskFinished { get; set; }

        public void SetState(State state)
        {
            currentState = state;
        }

        public void WriteProgram()
        {
            currentState.WriteProgram(this);
        }
    }
}
