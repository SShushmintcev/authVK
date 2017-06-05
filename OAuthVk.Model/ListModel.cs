using System.Collections.Generic;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  public class ListModel<T> : IListModel<T>
  {
    /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
    public ListModel()
    {
      Items = new List<T>();
    }

    public int Count { get; set; }

    public List<T> Items { get; set; }

    IEnumerable<T> IListModel<T>.Items => Items;
  }
}