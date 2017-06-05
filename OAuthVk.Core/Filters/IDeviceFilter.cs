namespace OAuthVk.Core.Filters
{
  public interface IDeviceFilter
  {
    /// <summary>
    /// Идентификатор устройства, используемый для отправки уведомлений 
    /// (для mpns идентификатор должен представлять из себя URL для отправки уведомлений).
    /// </summary>
    string Token { get; set; }

    /// <summary>
    /// Название модели устройства.
    /// </summary>
    string DeviceModel { get; set; }

    /// <summary>
    /// год устройства
    /// </summary>
    int? DeviceYear { get; set; }

    /// <summary>
    /// Уникальный идентификатор устройства.
    /// </summary>
    int DeviceId { get; set; }

    /// <summary>
    /// Версия операционной системы устройства.
    /// </summary>
    string SystemVersion { get; set; }

    /// <summary>
    /// Сериализованный JSON-объект, описывающий настройки уведомлений в специальном формате
    /// данные в формате JSON, доступен начиная с версии 5.31
    /// </summary>
    IPushNotification Settings { get; set; }

    /// <summary>
    /// Признак предназначен для iOS устройств.
    /// Использовать sandbox сервер для отправки push-уведомлений иначе не использовать.
    /// </summary>
    bool Sandbox { get; set; }

    /// <summary>
    /// Сериализованный объект.
    /// </summary>
    string SettingsJson { get; }
  }
}