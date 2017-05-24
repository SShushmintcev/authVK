using System;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  [Serializable]
  public class Action : IAction
  {
    /// <summary>
    /// Тип действия.
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// URL для перехода.
    /// </summary>
    public string Url { get; set; }
  }
}