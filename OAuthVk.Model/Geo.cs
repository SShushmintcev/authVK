using System;
using Newtonsoft.Json;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  [Serializable]
  public class Geo : IGeo
  {
    /// <summary>
    /// Тип места.
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Координаты места.
    /// </summary>
    public string Coordinates { get; set; }

    /// <summary>
    /// Описание места(если оно добавлено).
    /// </summary>
    [JsonProperty]
    public Place Place { get; set; }

    /// <summary>
    /// Описание места(если оно добавлено).
    /// </summary>
    IPlace IGeo.Place => Place;
  }
}