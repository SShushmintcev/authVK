using System;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  [Serializable]
  public class Relative : IRelative
  {
    /// <summary>
    /// Идентификатор пользователя 
    /// (в том случае, если родственник не является пользователем ВКонтакте, в этом случае id не возвращается).
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// Имя родственника.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// тип родственной связи.
    /// </summary>
    /// <value>child — сын/дочь.</value>
    /// <value>sibling — брат/сестра.</value>
    /// <value>parent — отец/мать.</value>
    /// <value>grandparent — дедушка/бабушка.</value>
    /// <value>grandchild — внук/внучка.</value>
    public string Type { get; set; }
  }
}