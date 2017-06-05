using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using OAuthVk.Core;
using OAuthVk.Core.FileType;

namespace OAuthVk.Model.FileType
{
  [Serializable]
  public class Wall : IWall
  {
    /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
    public Wall()
    {
      Attachments = new List<Attachment>();
    }

    /// <summary>
    /// Идентификатор записи.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Идентификатор владельца стены, на которой размещена запись.
    /// В версиях API ниже 5.7 это поле называется to_id.
    /// </summary>
    [JsonProperty("owner_id")]
    public int? OwnerId { get; set; }

    /// <summary>
    /// Идентификатор владельца стены, на которой размещена запись.
    /// Для версии ниже 5.7.
    /// </summary>
    [JsonProperty("to_id")]
    public int? ToId { get; set; }

    /// <summary>
    /// Идентификатор автора записи.
    /// </summary>
    [JsonProperty("from_id")]
    public int FromId { get; set; }

    /// <summary>
    /// Время публикации записи в формате unixtime.
    /// </summary>
    public int Date { get; set; }

    /// <summary>
    /// Текст записи.
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Идентификатор владельца записи, в ответ на которую была оставлена текущая.
    /// </summary>
    [JsonProperty("reply_owner_id")]
    public int ReplyOwnerId { get; set; }

    /// <summary>
    /// Идентификатор записи, в ответ на которую была оставлена текущая.
    /// </summary>
    [JsonProperty("reply_post_id")]
    public int ReplyPostId { get; set; }

    /// <summary>
    /// 1, если запись была создана с опцией «Только для друзей».
    /// </summary>
    [JsonProperty("friends_only")]
    public int FriendsOnly { get; set; }

    /// <summary>
    /// Информация о комментариях к записи.
    /// </summary>
    [JsonProperty]
    public Comments Comments { get; set; }

    /// <summary>
    /// Информация о комментариях к записи.
    /// </summary>
    IComments IWall.Comments => Comments;

    /// <summary>
    /// Информация о лайках к записи.
    /// </summary>
    [JsonProperty]
    public Like Likes { get; set; }

    /// <summary>
    /// Информация о лайках к записи.
    /// </summary>
    ILike IWall.Likes => Likes;

    /// <summary>
    /// Информация о репостах записи «Рассказать друзьям».
    /// </summary>
    [JsonProperty]
    public Repost Reposts { get; set; }

    /// <summary>
    /// Информация о репостах записи «Рассказать друзьям».
    /// </summary>
    IRepost IWall.Reposts => Reposts;

    /// <summary>
    /// Информация о просмотрах записи.
    /// </summary>
    [JsonProperty]
    public CountInfo Views { get; set; }

    /// <summary>
    /// Информация о просмотрах записи.
    /// </summary>
    ICount IWall.Views => Views;

    /// <summary>
    /// Тип записи, может принимать следующие значения: post, copy, reply, postpone, suggest.
    /// </summary>
    [JsonProperty("post_type")]
    public string PostType { get; set; }

    /// <summary>
    /// Поле возвращается только для Standalone-приложений с ключом доступа, полученным в Implicit Flow.
    /// Информация о способе размещения записи.
    /// </summary>
    [JsonProperty("post_source")]
    public PostSource PostSource { get; set; }

    /// <summary>
    /// Поле возвращается только для Standalone-приложений с ключом доступа, полученным в Implicit Flow.
    /// Информация о способе размещения записи.
    /// </summary>
    IPostSource IWall.PostSource => PostSource;

    /// <summary>
    /// Медиавложения записи (фотографии, ссылки и т.п.).
    /// </summary>
    [JsonProperty]
    public List<Attachment> Attachments { get; set; }

    /// <summary>
    /// Медиавложения записи (фотографии, ссылки и т.п.).
    /// </summary>
    IEnumerable<IAttachment> IWall.Attachments => Attachments;

    /// <summary>
    /// Информация о местоположении.
    /// </summary>
    [JsonProperty]
    public Geo Geo { get; set; }

    /// <summary>
    /// Информация о местоположении.
    /// </summary>
    IGeo IWall.Geo => Geo;

    /// <summary>
    /// Идентификатор автора, если запись была опубликована от имени сообщества и подписана пользователем.
    /// </summary>
    [JsonProperty("signer_id")]
    public int? SignerId { get; set; }

    /// <summary>
    /// Массив, содержащий историю репостов для записи.
    /// Возвращается только в том случае, если запись является репостом.
    /// Каждый из объектов массива, в свою очередь, является объектом-записью стандартного формата.
    /// </summary>
    /// TODO: Что за тип массива?
    [JsonProperty("copy_history")]
    public Array CopyHistory { get; set; }

    /// <summary>
    /// Может ли текущий пользователь закрепить запись.
    /// </summary>
    [JsonProperty("can_pin")]
    public bool IsPin { get; set; }

    /// <summary>
    /// Может ли текущий пользователь удалить запись.
    /// </summary>
    [JsonProperty("can_delete")]
    public bool IsDelete { get; set; }

    /// <summary>
    /// Может ли текущий пользователь редактировать запись.
    /// </summary>
    [JsonProperty("can_edit")]
    public bool IsEdit { get; set; }

    /// <summary>
    /// Признак того, что запись закреплена.
    /// </summary>
    [JsonProperty("is_pinned")]
    public bool IsPinned { get; set; }

    /// <summary>
    /// Содержит ли запись отметку "реклама".
    /// </summary>
    [JsonProperty("marked_as_ads")]
    public bool MarkedAsAds { get; set; }
  }
}