using System.Collections.Generic;

namespace OAuthVk.Core
{
  public interface ILookupUser
  {
    /// <summary>
    /// Список найденных пользователей.
    /// </summary>
    IEnumerable<IUser> Found { get; }

    /// <summary>
    /// Список контактов, которые не были найдены.
    /// </summary>
    IEnumerable<IOtherLookup> Other { get; }
  }

  public interface IOtherLookup
  {
    /// <summary>
    /// Email, по которому был найден пользователь
    /// (не приходит если пользователь был найден при предыдущем использовании метода).
    /// </summary>
    string Email { get; set; }

    /// <summary>
    /// Общее количество друзей с пользователем.
    /// </summary>
    int? CommonCount { get; set; }
  }
}