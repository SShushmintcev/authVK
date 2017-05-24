namespace OAuthVk.Core
{
  public interface IAction
  {
    /// <summary>
    /// Тип действия.
    /// </summary>
    string Type { get; set; }

    /// <summary>
    /// URL для перехода.
    /// </summary>
    string Url { get; set; }
  }
}