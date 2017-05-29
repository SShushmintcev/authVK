using System.Collections.Generic;

namespace OAuthVk.Core.DataProvider
{
  public interface IFriendProvider
  {
    IEnumerable<IUser> Get();
  }
}