using ChurchDb.Contracts;

namespace ChurchDb;

public class EditContactPresenter
{
    private readonly IChurchContactPersistence _persistence;
    private IEditContactStateMachine _stateMachine;

    private static Dictionary<EditContactState, IEditContactStateMachine> _states =
        new Dictionary<EditContactState, IEditContactStateMachine>
        {
            {EditContactState.EDIT,new EditContactStateMachineEDIT()},
            {EditContactState.NEW,new EditContactStateMachineNEW()},
        };
    private IEditContactForm _form;

    public EditContactPresenter(IChurchContactPersistence persistence)
    {
        _persistence = persistence;
    }
    public void SetForm(IEditContactForm form, EditContactState state)
    {
        _stateMachine = _states[state];
        _form = form;
        _form.IDInput.Enabled = false;
        _form.IDInput.SetLable("ID:");

        _form.LastNameInput.SetLable("Last Name:");

        _form.SaveRequested += (sender, args) =>
        {
            Save(new ChurchContact { LastName = _form.LastNameInput.Text, ID = _form.IDInput.Text });
            _stateMachine = _states[EditContactState.EDIT];
        };

        _form.CancelRequested += (sender, args) =>
        {
            _form.CloseForm();
        };
    }

    void Save(ChurchContact contact) => _stateMachine.Save(contact, _persistence, _form);
}