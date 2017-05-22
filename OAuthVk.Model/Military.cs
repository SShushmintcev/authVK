using System;
using Newtonsoft.Json;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  [Serializable]
  public class Military : IMilitary
  {
    /// <summary>
    /// Идентификатор части в базе данных.
    /// </summary>
    [JsonProperty("unit_id")]
    public int UnitId { get; set; }

    /// <summary>
    /// Номер части.
    /// </summary>
    public string Unit { get; set; }

    /// <summary>
    /// Идентификатор страны, в которой находится часть.
    /// </summary>
    [JsonProperty("country_id")]
    public int CountryId { get; set; }

    /// <summary>
    /// Начало службы.
    /// </summary>
    public int From { get; set; }

    /// <summary>
    /// Год окончания службы.
    /// </summary>
    public int Until { get; set; }
  }
}