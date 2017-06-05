using System.Collections.Generic;
using Newtonsoft.Json;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  public class LookupUser : ILookupUser
  {
    /// <summary>Initializes a new instance of the <see cref="T:LookupUser" /> class.</summary>
    public LookupUser()
    {
      Found = new List<User>();
      Other = new List<OtherLookup>();
    }

    /// <summary>
    /// Список найденных пользователей.
    /// </summary>
    [JsonProperty]
    public List<User> Found { get; set; }

    IEnumerable<IUser> ILookupUser.Found => Found;

    /// <summary>
    /// Список контактов, которые не были найдены.
    /// </summary>
    [JsonProperty]
    public List<OtherLookup> Other { get; set; }

    IEnumerable<IOtherLookup> ILookupUser.Other => Other;
  }

  public class OtherLookup : IOtherLookup
  {
    /// <summary>
    /// Email, по которому был найден пользователь
    /// (не приходит если пользователь был найден при предыдущем использовании метода).
    /// </summary>
    [JsonProperty("contact")]
    public string Email { get; set; }

    /// <summary>
    /// Общее количество друзей с пользователем.
    /// </summary>
    [JsonProperty("common_count")]
    public int? CommonCount { get; set; }
  }
}