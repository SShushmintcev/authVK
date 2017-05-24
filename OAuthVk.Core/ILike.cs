namespace OAuthVk.Core
{
  public interface ILike : ICount
  {
    /// <summary>
    /// Наличие отметки «Мне нравится» от текущего пользователя.
    /// </summary>
    bool UserLikes { get; set; }

    /// <summary>
    /// Может ли текущий пользователь поставить отметку «Мне нравится».
    /// </summary>
    bool CanLike { get; set; }

    /// <summary>
    /// Может ли текущий пользователь сделать репост записи.
    /// </summary>
    bool CanPublish { get; set; }
  }
}