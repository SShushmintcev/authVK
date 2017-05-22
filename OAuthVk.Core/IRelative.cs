namespace OAuthVk.Core
{
  public interface IRelative
  {
    /// <summary>
    /// Идентификатор пользователя 
    /// (в том случае, если родственник не является пользователем ВКонтакте, в этом случае id не возвращается).
    /// </summary>
    int? Id {get; set;}

    /// <summary>
    /// Имя родственника.
    /// </summary>
    string Name {get; set;}

    /// <summary>
    /// тип родственной связи.
    /// </summary>
    /// <value>child — сын/дочь.</value>
    /// <value>sibling — брат/сестра.</value>
    /// <value>parent — отец/мать.</value>
    /// <value>grandparent — дедушка/бабушка.</value>
    /// <value>grandchild — внук/внучка.</value>
    string Type {get; set;}
  }
}