using ChurchDb.Contracts;

namespace ChurchDb;

public class EditContactStateMachineNEW : IEditContactStateMachine
{
    public void Save(ChurchContact contact, IChurchContactPersistence persistence, IEditContactForm form)
    {
        string id = persistence.Save(new ChurchContact { LastName = form.LastNameInput.Text });
        form.IDInput.Text = id;
    }
}