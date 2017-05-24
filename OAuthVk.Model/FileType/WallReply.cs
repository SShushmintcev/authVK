using System;
using Newtonsoft.Json;
using OAuthVk.Core;
using OAuthVk.Core.FileType;

namespace OAuthVk.Model.FileType
{
  [Serializable]
  public class WallReply : IWallReply
  {
    /// <summary>
    /// Идентификатор комментария.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Идентификатор автора комментария.
    /// </summary>
    [JsonProperty("from_id")]
    public int FromId { get; set; }

    /// <summary>
    /// Дата создания комментария в формате Unixtime.
    /// </summary>
    public int Date { get; set; }

    /// <summary>
    /// Текст комментария.
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Идентификатор пользователя или сообщества, в ответ которому оставлен текущий комментарий (если применимо).
    /// </summary>
    [JsonProperty("reply_to_user")]
    public int? ReplyToUser { get; set; }

    /// <summary>
    /// Идентификатор комментария, в ответ на который оставлен текущий (если применимо).
    /// </summary>
    [JsonProperty("reply_to_comment")]
    public int? ReplyToComment { get; set; }

    /// <summary>
    /// Медиавложения комментария (фотографии, ссылки и т.п.).
    /// </summary>
    public Attachment Attachments { get; set; }

    /// <summary>
    /// Медиавложения комментария (фотографии, ссылки и т.п.).
    /// </summary>
    IAttachment IWallReply.Attachments => Attachments;
  }
}