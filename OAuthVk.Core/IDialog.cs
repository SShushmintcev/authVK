namespace OAuthVk.Core
{
  public interface IDialog
  {
    /// <summary>
    /// Количество непрочитанных сообщений.
    /// </summary>
    int? Unread { get; set; }

    /// <summary>
    /// Список диалогов.
    /// </summary>
    IMessage Message { get; }

    /// <summary>
    /// Количество непрочитанных диалогов.
    /// Возвращается тогда, когда есть непрочитанные диалоги и параметр фильтра unread=0.
    /// </summary>
    // TODO: Указать крассиво параметр фильтра.
    int? UnreadMessages { get; set; }

    /// <summary>
    /// Идентификатор последнего сообщения, прочитанного текущим пользователем.
    /// </summary>
    int? InRead { get; set; }

    /// <summary>
    /// Идентификатор последнего сообщения, прочитанного собеседником.
    /// </summary>
    int? OutRead { get; set; }

    /// <summary>
    /// Итоговое смещение данного подмножества диалогов.
    /// </summary>
    int? RealOffset { get; set; }
  }
}