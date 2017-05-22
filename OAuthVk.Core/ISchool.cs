using OAuthVk.Core.Enums;

namespace OAuthVk.Core
{
  public interface ISchool
  {
    /// <summary>
    /// Идентификатор школы.
    /// </summary>
    string Id { get; set; }

    /// <summary>
    /// Идентификатор страны, в которой расположена школа.
    /// </summary>
    int Country { get; set; }

    /// <summary>
    /// Идентификатор города, в котором расположена школа.
    /// </summary>
    int City { get; set; }

    /// <summary>
    /// Наименование школы.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Год начала обучения.
    /// </summary>
    int YearFrom { get; set; }

    /// <summary>
    /// Год окончания обучения.
    /// </summary>
    int YearTo { get; set; }

    /// <summary>
    /// Год выпуска.
    /// </summary>
    int YearGraduated { get; set; }

    /// <summary>
    /// Буква класса.
    /// </summary>
    string Class { get; set; }

    /// <summary>
    /// Специализация.
    /// </summary>
    string Speciality { get; set; }

    /// <summary>
    /// Идентификатор типа.
    /// </summary>
    SchoolType Type { get; set; }

    /// <summary>
    /// Название типа.
    /// </summary>
    string TypeName { get; set; }

  }
}