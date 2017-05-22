using System;
using Newtonsoft.Json;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  [Serializable]
  public class Contact: IContact
  {
    /// <summary>
    /// Номер мобильного телефона пользователя(только для Standalone-приложений)
    /// </summary>
    [JsonProperty("mobile_phone")]
    public string MobilePhone { get; set; }

    /// <summary>
    /// Дополнительный номер телефона пользователя.
    /// </summary>
    [JsonProperty("home_phone")]
    public string HomePhone { get; set; }
  }
}