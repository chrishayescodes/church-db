using ChurchDb.Contracts;

namespace ChurchDb;

public interface IEditContactStateMachine
{
    void Save(ChurchContact contact, IChurchContactPersistence persistence, IEditContactForm form);
}