using OAuthVk.Core.Enums;

namespace OAuthVk.Core
{
  public interface ILastVisit
  {
    /// <summary>
    /// Время последнего посещения в формате Unixtime.
    /// </summary>
    int Time { get; set; }

    /// <summary>
    /// тип платформы, через которую был осуществлён последний вход.
    /// </summary>
    PlatformType Platform { get; set; }
  }
}