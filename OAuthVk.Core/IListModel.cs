using System.Collections.Generic;

namespace OAuthVk.Core
{
  public interface IListModel<T>
  {
    int Count { get; set; }

    IEnumerable<T> Items { get; }
  }
}