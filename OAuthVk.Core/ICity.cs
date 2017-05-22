namespace OAuthVk.Core
{
  public interface ICity
  {
    /// <summary>
    /// Идентификатор города.
    /// </summary>
    long Id { get; set; }

    /// <summary>
    /// Название города.
    /// </summary>
    string Title { get; set; }
  }
}