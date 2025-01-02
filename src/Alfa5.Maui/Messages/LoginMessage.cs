using CommunityToolkit.Mvvm.Messaging.Messages;

namespace Alfa5.Maui.Messages;
public class LoginMessage : ValueChangedMessage<bool?>
{
    public LoginMessage(bool? value = null) : base(value)
    {
    }
}
