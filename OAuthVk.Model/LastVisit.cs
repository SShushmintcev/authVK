using System;
using OAuthVk.Core;
using OAuthVk.Core.Enums;

namespace OAuthVk.Model
{
  [Serializable]
  public class LastVisit: ILastVisit
  {
    /// <summary>
    /// Время последнего посещения в формате Unixtime.
    /// </summary>
    public int Time { get; set; }

    /// <summary>
    /// тип платформы, через которую был осуществлён последний вход.
    /// </summary>
    public PlatformType Platform { get; set; }
  }
}