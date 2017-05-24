using System;
using Newtonsoft.Json;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  [Serializable]
  public class ButtonInfo : IButtonInfo
  {
    /// <summary>
    /// Название кнопки.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Действие для кнопки.
    /// </summary>
    [JsonProperty]
    public Action Action { get; set; }

    /// <summary>
    /// Действие для кнопки.
    /// </summary>
    IAction IButtonInfo.Action => Action;
  }
}