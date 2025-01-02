using CommunityToolkit.Mvvm.Messaging.Messages;

namespace Alfa5.Maui.Messages;

public class LanguageChangedMessage : ValueChangedMessage<string?>
{
    public LanguageChangedMessage(string? value) : base(value)
    {
    }
}
