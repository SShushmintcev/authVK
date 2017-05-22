using System;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  [Serializable]
  public class City: ICity
  {
    /// <summary>
    /// Идентификатор города.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Название города.
    /// </summary>
    public string Title { get; set; }
  }
}