using Newtonsoft.Json;
using OAuthVk.Core.FileType;

namespace OAuthVk.Model.FileType
{
  public class Note : INote
  {
    /// <summary>
    /// Идентификатор заметки.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Идентификатор владельца заметки.
    /// </summary>
    [JsonProperty("owner_id")]
    public int OwnerId { get; set; }

    /// <summary>
    /// Заголовок заметки.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Текст заметки.
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Дата создания заметки в формате Unixtime.
    /// </summary>
    public int Date { get; set; }

    /// <summary>
    /// Количество комментариев.
    /// </summary>
    [JsonProperty("comments")]
    public int CommentCount { get; set; }

    /// <summary>
    /// Количество прочитанных комментариев(только при запросе информации о заметке текущего пользователя).
    /// </summary>
    [JsonProperty("read_comments")]
    public int ReadCommentCount { get; set; }

    /// <summary>
    /// URL страницы для отображения заметки.
    /// </summary>
    [JsonProperty("view_url")]
    public string ViewUrl { get; set; }
  }
}