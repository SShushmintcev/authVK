using Newtonsoft.Json;
using OAuthVk.Core;
using OAuthVk.Core.Filters;

namespace OAuthVk.Model.Filter
{
  public class DeviceFilter : IDeviceFilter
  {
    /// <summary>
    /// Идентификатор устройства, используемый для отправки уведомлений 
    /// (для mpns идентификатор должен представлять из себя URL для отправки уведомлений).
    /// </summary>
    public string Token { get; set; }

    /// <summary>
    /// Название модели устройства.
    /// </summary>
    public string DeviceModel { get; set; }

    /// <summary>
    /// год устройства
    /// </summary>
    public int? DeviceYear { get; set; }

    /// <summary>
    /// Уникальный идентификатор устройства.
    /// </summary>
    public int DeviceId { get; set; }

    /// <summary>
    /// Версия операционной системы устройства.
    /// </summary>
    public string SystemVersion { get; set; }

    /// <summary>
    /// Сериализованный JSON-объект, описывающий настройки уведомлений в специальном формате.
    /// </summary>
    public IPushNotification Settings { get; set; }

    /// <summary>
    /// Признак предназначен для iOS устройств.
    /// Использовать sandbox сервер для отправки push-уведомлений иначе не использовать.
    /// </summary>
    public bool Sandbox { get; set; }

    /// <summary>
    /// Сериализованный объект.
    /// </summary>
    public string SettingsJson => Settings == null ? null : JsonConvert.SerializeObject(Settings);
  }
}