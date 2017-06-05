using Newtonsoft.Json;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  public class Dialog : IDialog
  {
    /// <summary>
    /// Количество непрочитанных сообщений.
    /// </summary>
    public int? Unread { get; set; }

    /// <summary>
    /// Список диалогов.
    /// </summary>
    public Message Message { get; set; }

    /// <summary>
    /// Список диалогов.
    /// </summary>
    IMessage IDialog.Message => Message;

    /// <summary>
    /// Количество непрочитанных диалогов.
    /// Возвращается тогда, когда есть непрочитанные диалоги и параметр фильтра unread=0.
    /// </summary>
    // TODO: Указать крассиво параметр фильтра.
    [JsonProperty("unread_dialogs")]
    public int? UnreadMessages { get; set; }

    /// <summary>
    /// Идентификатор последнего сообщения, прочитанного текущим пользователем.
    /// </summary>
    [JsonProperty("in_read")]
    public int? InRead { get; set; }

    /// <summary>
    /// Идентификатор последнего сообщения, прочитанного собеседником.
    /// </summary>
    [JsonProperty("out_read")]
    public int? OutRead { get; set; }

    /// <summary>
    /// Итоговое смещение данного подмножества диалогов.
    /// </summary>
    [JsonProperty("real_offset")]
    public int? RealOffset { get; set; }
  }
}