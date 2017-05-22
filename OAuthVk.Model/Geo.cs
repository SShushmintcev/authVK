using OAuthVk.Core;

namespace OAuthVk.Model
{
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
    public IPlace Place { get; set; }
  }
}