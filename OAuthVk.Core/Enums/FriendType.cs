namespace OAuthVk.Core.Enums
{
  public enum FriendType
  {
    /// <summary>
    /// Не является другом.
    /// </summary>
    None = 0,

    /// <summary>
    /// Отправлена заявка/подписка пользователю.
    /// </summary>
    SendRequest = 1,

    /// <summary>
    /// Имеется входящая заявка/подписка от пользователя.
    /// </summary>
    IncomingRequest = 2,

    /// <summary>
    /// Является другом.
    /// </summary>
    Friend = 3
  }
}
 