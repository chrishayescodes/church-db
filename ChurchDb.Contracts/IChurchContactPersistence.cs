namespace ChurchDb.Contracts;

public interface IChurchContactPersistence
{
    string Save(ChurchContact contact);
    void Update(ChurchContact contact);
    ChurchContact GetById(string id);
    IEnumerable<ChurchContact> GetAll();

}