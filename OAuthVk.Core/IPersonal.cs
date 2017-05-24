using System.Collections.Generic;
using OAuthVk.Core.Enums;

namespace OAuthVk.Core
{
  public interface IPersonal
  {
    /// <summary>
    /// Политические предпочтения.
    /// </summary>
    PoliticalType Political { get; set; }

    /// <summary>
    /// Знание языков.
    /// </summary>
    IEnumerable<string> Langs { get; }

    /// <summary>
    /// Мировоззрение.
    /// </summary>
    string Religion { get; set; }

    /// <summary>
    /// Источники вдохновения.
    /// </summary>
    string InspiredBy { get; set; }

    /// <summary>
    /// Главное в людях.
    /// </summary>
    HumanTraitType PeopleMain { get; set; }

    /// <summary>
    /// Главное в жизни.
    /// </summary>
    LifeMainType LifeMain { get; set; }

    /// <summary>
    /// Отношение к курению.
    /// </summary>
    AttitudeType Smoking { get; set; }

    /// <summary>
    /// Отношение к алкоголю.
    /// </summary>
    AttitudeType Alcohol { get; set; }
  }
}