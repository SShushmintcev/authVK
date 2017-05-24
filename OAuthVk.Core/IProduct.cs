namespace OAuthVk.Core
{
  public interface IProduct
  {
    /// <summary>
    /// Информация о цене.
    /// </summary>
    IPrice Price { get; }
  }
}