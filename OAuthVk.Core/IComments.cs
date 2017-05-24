namespace OAuthVk.Core
{
  public interface IComments : ICount
  {
    /// <summary>
    /// Может ли текущий пользователь комментировать запись(1 — может, 0 — не может).
    /// </summary>
    bool CanPost {get;set;}
  }
}