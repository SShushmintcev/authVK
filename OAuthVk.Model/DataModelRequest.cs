using OAuthVk.Core;
using OAuthVk.Core.DataProvider;

namespace OAuthVk.Model
{
  public class DataModelRequest : IDataModelRequest
  {
    /// <summary>
    /// Провайдер пользовательских данных.
    /// </summary>
    public IFriendProvider FriendProvider { get; }

    /// <summary>
    /// Провайдер данных сообщений.
    /// </summary>
    public IMessageProvider MessageProvider { get; }
  }
}