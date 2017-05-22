namespace OAuthVk.Core.Enums
{
  public enum UserRelationType
  {
    /// <summary>
    /// Не указано.
    /// </summary>
    None = 0,

    /// <summary>
    /// Hе женат/не замужем.
    /// </summary>
    Single = 1,

    /// <summary>
    /// Есть друг/есть подруга
    /// </summary>
    HaveFriend = 2,

    /// <summary>
    /// Помолвлен/помолвлена
    /// </summary>
    Betrothed = 3,

    /// <summary>
    /// Женат/замужем
    /// </summary>
    Married = 4,

    /// <summary>
    /// Всё сложно
    /// </summary>
    Complicated = 5,

    /// <summary>
    /// В активном поиске
    /// </summary>
    ActiveSearch = 6,

    /// <summary>
    /// Влюблён/влюблена
    /// </summary>
    Love = 7,

    /// <summary>
    /// В гражданском браке
    /// </summary>
    CivilMarriage = 8
  }
}