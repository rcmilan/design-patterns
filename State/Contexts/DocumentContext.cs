using State.States;

namespace State.Contexts
{
    public class DocumentContext : Domain.Models.Document
    {
        public IState _currentState;
        public DocumentContext()
        {
            _currentState = new CreatedState();
        }

        public void SetState(IState state)
        {
            _currentState = state;
        }

        public void UpdateDocument()
        {
            _currentState.Update(this);
        }
    }
}
