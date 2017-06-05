using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  public class AccountPushSettings : IAccountPushSettings
  {
    /// <summary>
    /// Отключены ли уведомления.
    /// </summary>
    [JsonProperty("disabled")]
    public bool IsDisabled { get; set; }

    /// <summary>
    /// Подписка.
    /// </summary>
    public string Subscribe { get; set; }

    /// <summary>
    /// Unixtime-значение времени, до которого временно отключены уведомления.
    /// </summary>
    [JsonProperty("disabled_until")]
    public int? DisabledUntil { get; set; }

    /// <summary>
    /// Список, содержащий настройки конкретных диалогов, и их количество первым элементом.
    /// </summary>
    public ListModel<ChatPushSettings> Conversations { get; set; }

    /// <summary>
    /// Список, содержащий настройки конкретных диалогов, и их количество первым элементом.
    /// </summary>
    IListModel<IChatPushSettings> IAccountPushSettings.Conversations => (IListModel<IChatPushSettings>)Conversations;

    /// <summary>
    /// Объект с настройками Push-уведомлений в специальном формате.
    /// </summary>
    public PushNotification Settings { get; set; }

    /// <summary>
    /// Объект с настройками Push-уведомлений в специальном формате.
    /// </summary>
    IPushNotification IAccountPushSettings.Settings => Settings;
  }
}