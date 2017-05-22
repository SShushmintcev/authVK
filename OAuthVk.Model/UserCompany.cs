using System;
using Newtonsoft.Json;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  [Serializable]
  public class UserCompany: IUserCompany
  {
    /// <summary>
    /// Идентификатор сообщества(если доступно, иначе company).
    /// </summary>
    [JsonProperty("group_id")]
    public int? GroupId { get; set; }

    /// <summary>
    /// Название компании(если доступно, иначе group_id).
    /// </summary>
    public string Company { get; set; }

    /// <summary>
    /// Идентификатор страны.
    /// </summary>
    [JsonProperty("country_id")]
    public int CountryId { get; set; }

    /// <summary>
    /// Идентификатор города.
    /// </summary>
    [JsonProperty("city_id")]
    public int CityId { get; set; }

    /// <summary>
    /// Год начала работы.
    /// </summary>
    public int? From { get; set; }

    /// <summary>
    /// Год окончания работы.
    /// </summary>
    public int? Until { get; set; }

    /// <summary>
    /// Должность.
    /// </summary>
    public string Position { get; set; }
  }
}