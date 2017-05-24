namespace OAuthVk.Core
{
  public interface IRepost : ICount
  {
    /// <summary>
    /// Наличие репоста от текущего пользователя.
    /// </summary>
    bool UserReposted {get;set;}
  }
}