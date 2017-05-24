namespace OAuthVk.Core
{
  public interface IButtonInfo
  {
    /// <summary>
    /// Название кнопки.
    /// </summary>
    string Title { get; set; }

    /// <summary>
    /// Действие для кнопки.
    /// </summary>
    IAction Action { get; }
  }
}