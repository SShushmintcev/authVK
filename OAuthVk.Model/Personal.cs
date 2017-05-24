using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using OAuthVk.Core;
using OAuthVk.Core.Enums;

namespace OAuthVk.Model
{
  [Serializable]
  public class Personal : IPersonal
  {
    /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
    public Personal()
    {
      Langs = new List<string>();
    }

    /// <summary>
    /// Политические предпочтения.
    /// </summary>
    public PoliticalType Political { get; set; }

    /// <summary>
    /// Знание языков.
    /// </summary>
    [JsonProperty]
    public List<string> Langs { get; set; }

    /// <summary>
    /// Знание языков.
    /// </summary>
    IEnumerable<string> IPersonal.Langs => Langs;

    /// <summary>
    /// Мировоззрение.
    /// </summary>
    public string Religion { get; set; }

    /// <summary>
    /// Источники вдохновения.
    /// </summary>
    [JsonProperty("inspired_by")]
    public string InspiredBy { get; set; }

    /// <summary>
    /// Главное в людях.
    /// </summary>
    [JsonProperty("people_main")]
    public HumanTraitType PeopleMain { get; set; }

    /// <summary>
    /// Главное в жизни.
    /// </summary>
    [JsonProperty("life_main")]
    public LifeMainType LifeMain { get; set; }

    /// <summary>
    /// Отношение к курению.
    /// </summary>
    public AttitudeType Smoking { get; set; }

    /// <summary>
    /// Отношение к алкоголю.
    /// </summary>
    public AttitudeType Alcohol { get; set; }
  }
}