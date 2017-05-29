using OAuthVk.Core.DataProvider;

namespace OAuthVk.Core
{
  /// <summary>
  /// Модель запросов.
  /// </summary>
  public interface IDataModelRequest
  {
    /// <summary>
    /// Провайдер пользовательских данных.
    /// </summary>
    IFriendProvider FriendProvider { get; }

    /// <summary>
    /// Провайдер данных сообщений.
    /// </summary>
    IMessageProvider MessageProvider { get; }
  }
}