using ChurchDb.Contracts;

namespace ChurchDb;

public class EditContactStateMachineEDIT : IEditContactStateMachine
{
    public void Save(ChurchContact contact, IChurchContactPersistence persistence, IEditContactForm form)
    {
        persistence.Update(contact);
    }
}