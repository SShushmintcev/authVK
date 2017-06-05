using System.Collections.Generic;
using Newtonsoft.Json;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  public class Chat : IChat
  {
    /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
    public Chat()
    {
      Users = new List<User>();
    }

    /// <summary>
    /// Идентификатор беседы.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Тип диалога.
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Название беседы.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Идентификатор пользователя, который является создателем беседы.
    /// </summary>
    [JsonProperty("admin_id")]
    public int AdminId { get; set; }

    /// <summary>
    /// Список участников беседы.
    /// </summary>
    // TODO: Научить возвращать только идентификаторы.
    public List<User> Users { get; set; }

    /// <summary>
    /// Список участников беседы.
    /// </summary>
    // TODO: Научить возвращать только идентификаторы.
    IEnumerable<IUser> IChat.Users => Users;

    /// <summary>
    /// Настройки оповещений для диалога.
    /// </summary>
    [JsonProperty("push_settings")]
    public ChatPushSettings PushSettings { get; set; }

    /// <summary>
    /// Настройки оповещений для диалога.
    /// </summary>
    IChatPushSettings IChat.ChatPushSettings => PushSettings;

    /// <summary>
    ///  URL изображения-обложки чата шириной 50 px (Опционально).
    /// </summary>
    [JsonProperty("photo_50")]
    public string PhotoSizeS { get; set; }
    /// <summary>
    /// URL изображения-обложки чата шириной 200 px (Опционально).
    /// </summary>
    [JsonProperty("photo_100")]
    public string PhotoSizeM { get; set; }

    /// <summary>
    /// URL изображения-обложки чата шириной 200 px (Опционально).
    /// </summary>
    [JsonProperty("photo_200")]
    public string PhotoSizeL { get; set; }

    /// <summary>
    /// Флаг, указывающий, что пользователь покинул беседу.Всегда содержит 1.
    /// </summary>
    public bool Left { get; set; }

    /// <summary>
    /// Флаг, указывающий, что пользователь был исключен из беседы.Всегда содержит 1.
    /// </summary>
    public bool Kicked { get; set; }
  }
}