namespace OAuthVk.Core
{
  public interface ICategory
  {
    /// <summary>
    /// идентификатор Категории.
    /// </summary>
    int Id { get; set; }

    /// <summary>
    /// Название Категории.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Данные секции.
    /// </summary>
    ISection Section { get; }

  }

  public interface ISection
  {
    /// <summary>
    /// Идентификатор секции.
    /// </summary>
    int Id { get; set; }

    /// <summary>
    /// Название секции.
    /// </summary>
    string Name { get; set; }
  }
}