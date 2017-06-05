namespace OAuthVk.Core.Filters
{
  public interface IAccountPushSettingsFilter
  {
    /// <summary>
    /// Уникальный идентификатор устройства.
    /// </summary>
    int DeviceId { get; set; }

    /// <summary>
    /// JSON-объект.
    /// </summary>
    IPushNotification Settings { get; set; }

    /// <summary>
    /// Ключ уведомления.
    /// </summary>
    string Key { get; set; }

    /// <summary>
    /// Новое значение уведомления.
    /// </summary>
    IPushNotification Value { get; set; }

    /// <summary>
    /// Сериализованный объект.
    /// </summary>
    string SettingsJson { get; }

    /// <summary>
    /// Сериализованный объект.
    /// </summary>
    string ValueJson { get; }
  }
}