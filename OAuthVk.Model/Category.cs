using System;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  [Serializable]
  public class Category : ICategory
  {
    /// <summary>
    /// идентификатор Категории.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Название Категории.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Данные секции.
    /// </summary>
    public Section Section { get; set; }

    /// <summary>
    /// Данные секции.
    /// </summary>
    ISection ICategory.Section => Section;
  }

  [Serializable]
  public class Section : ISection
  {
    /// <summary>
    /// Идентификатор секции.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Название секции.
    /// </summary>
    public string Name { get; set; }
  }
}