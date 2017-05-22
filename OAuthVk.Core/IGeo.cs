namespace OAuthVk.Core
{
  public interface IGeo
  {
    /// <summary>
    /// Тип места.
    /// </summary>
    string Type { get; set; }

    /// <summary>
    /// Координаты места.
    /// </summary>
    string Coordinates { get; set; }

    /// <summary>
    /// Описание места(если оно добавлено).
    /// </summary>
    IPlace Place { get; set; }
  }
}