namespace OAuthVk.Core.FileType
{
  public interface INote
  {
    /// <summary>
    /// Идентификатор заметки.
    /// </summary>
    int Id { get; set; }

    /// <summary>
    /// Идентификатор владельца заметки.
    /// </summary>
    int OwnerId { get; set; }

    /// <summary>
    /// Заголовок заметки.
    /// </summary>
    string Title { get; set; }

    /// <summary>
    /// Текст заметки.
    /// </summary>
    string Text { get; set; }

    /// <summary>
    /// Дата создания заметки в формате Unixtime.
    /// </summary>
    int Date { get; set; }

    /// <summary>
    /// Количество комментариев.
    /// </summary>
    int CommentCount { get; set; }

    /// <summary>
    /// Количество прочитанных комментариев(только при запросе информации о заметке текущего пользователя).
    /// </summary>
    int ReadCommentCount { get; set; }

    /// <summary>
    /// URL страницы для отображения заметки.
    /// </summary>
    string ViewUrl { get; set; }
    
  }
}