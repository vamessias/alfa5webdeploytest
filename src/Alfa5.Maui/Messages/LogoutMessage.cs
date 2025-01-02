using CommunityToolkit.Mvvm.Messaging.Messages;

namespace Alfa5.Maui.Messages;
public class LogoutMessage : ValueChangedMessage<bool?>
{
    public LogoutMessage(bool? value = null) : base(value)
    {
    }
}