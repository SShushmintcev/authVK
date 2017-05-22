namespace OAuthVk.Core
{
  public interface IUniversity
  {
    /// <summary>
    /// Идентификатор университета.
    /// </summary>
    int Id { get; set; }

    /// <summary>
    /// Название университета.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    ///  Идентификатор страны, в которой расположен университет.
    /// </summary>
    int? CountryId { get; set; }

    /// <summary>
    /// Идентификатор города, в котором расположен университет.
    /// </summary>
    int? CityId { get; set; }

    /// <summary>
    /// Год окончания.
    /// </summary>
    int? Graduation { get; set; }

    /// <summary>
    /// Идентификатор кафедры.
    /// </summary>
    int? ChairId { get; set; }

    /// <summary>
    /// Наименование кафедры.
    /// </summary>
    string ChairName { get; set; }

    /// <summary>
    /// Форма обучения.
    /// </summary>
    string EducationForm { get; set; }

    /// <summary>
    /// Идентификатор факультета.
    /// </summary>
    int? FacultyId { get; set; }

    /// <summary>
    /// Название факультета.
    /// </summary>
    string FacultyName { get; set; }

    /// <summary>
    /// Статус(например, «Выпускник (специалист)»).
    /// </summary>
    string EducationStatus { get; set; }
  }
}