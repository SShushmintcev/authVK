using System;
using System.Collections.Generic;

namespace OAuthVk.Core
{
  public interface IAccountPushSettings
  {
    /// <summary>
    /// Отключены ли уведомления.
    /// </summary>
    bool IsDisabled { get; set; }

    /// <summary>
    /// Подписка.
    /// </summary>
    string Subscribe { get; set; }

    /// <summary>
    /// Unixtime-значение времени, до которого временно отключены уведомления.
    /// </summary>
    int? DisabledUntil { get; set; }

    /// <summary>
    /// Список, содержащий настройки конкретных диалогов, и их количество первым элементом.
    /// </summary>
    IListModel<IChatPushSettings> Conversations { get; }

    /// <summary>
    /// Объект с настройками Push-уведомлений в специальном формате.
    /// </summary>
    IPushNotification Settings { get; }
  }
}