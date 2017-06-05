using System.Collections.Generic;

namespace OAuthVk.Core
{
  public interface IChat
  {
    /// <summary>
    /// Идентификатор беседы.
    /// </summary>
    int Id { get; set; }

    /// <summary>
    /// Тип диалога.
    /// </summary>
    string Type { get; set; }

    /// <summary>
    /// Название беседы.
    /// </summary>
    string Title { get; set; }

    /// <summary>
    /// Идентификатор пользователя, который является создателем беседы.
    /// </summary>
    int AdminId { get; set; }

    /// <summary>
    /// Список участников беседы.
    /// </summary>
    // TODO: Научить возвращать только идентификаторы.
    IEnumerable<IUser> Users { get; }

    /// <summary>
    /// Настройки оповещений для диалога.
    /// </summary>
    IChatPushSettings ChatPushSettings { get; }

    /// <summary>
    ///  URL изображения-обложки чата шириной 50 px (Опционально).
    /// </summary>
    string PhotoSizeS { get; set; }
    /// <summary>
    /// URL изображения-обложки чата шириной 200 px (Опционально).
    /// </summary>
    string PhotoSizeM { get; set; }

    /// <summary>
    /// URL изображения-обложки чата шириной 200 px (Опционально).
    /// </summary>
    string PhotoSizeL { get; set; }

    /// <summary>
    /// Флаг, указывающий, что пользователь покинул беседу.Всегда содержит 1.
    /// </summary>
    bool Left { get; set; }

    /// <summary>
    /// Флаг, указывающий, что пользователь был исключен из беседы.Всегда содержит 1.
    /// </summary>
    bool Kicked { get; set; }
  }
}