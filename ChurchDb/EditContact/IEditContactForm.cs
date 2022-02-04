using ChurchDb.Controls;

namespace ChurchDb;

public interface IEditContactForm
{
    event EventHandler SaveRequested;
    event EventHandler SaveAndCloseRequested;
    event EventHandler CancelRequested;

    ITextInput IDInput { get; }
    ITextInput LastNameInput { get; }
    void CloseForm();

}