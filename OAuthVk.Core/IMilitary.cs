namespace OAuthVk.Core
{
  public interface IMilitary
  {
    /// <summary>
    /// Идентификатор части в базе данных.
    /// </summary>
    int UnitId { get; set; }

    /// <summary>
    /// Номер части.
    /// </summary>
    string Unit { get; set; }

    /// <summary>
    /// Идентификатор страны, в которой находится часть.
    /// </summary>
    int CountryId { get; set; }

    /// <summary>
    /// Начало службы.
    /// </summary>
    int From { get; set; }

    /// <summary>
    /// Год окончания службы.
    /// </summary>
    int Until { get; set; }
  }
}