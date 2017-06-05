using Newtonsoft.Json;
using OAuthVk.Core;
using OAuthVk.Core.Filters;

namespace OAuthVk.Model.Filter
{
  public class AccountPushSettingsFilter : IAccountPushSettingsFilter
  {
    /// <summary>
    /// Уникальный идентификатор устройства.
    /// </summary>
    public int DeviceId { get; set; }

    /// <summary>
    /// JSON-объект.
    /// </summary>
    public IPushNotification Settings { get; set; }

    /// <summary>
    /// Ключ уведомления.
    /// </summary>
    public string Key { get; set; }

    /// <summary>
    /// Новое значение уведомления.
    /// </summary>
    public IPushNotification Value { get; set; }

    /// <summary>
    /// Сериализованный объект.
    /// </summary>
    public string SettingsJson => Settings == null ? null : JsonConvert.SerializeObject(Settings);

    /// <summary>
    /// Сериализованный объект.
    /// </summary>
    public string ValueJson => Value == null ? null : JsonConvert.SerializeObject(Value);
  }
}