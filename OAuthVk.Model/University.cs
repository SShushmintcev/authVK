using System;
using Newtonsoft.Json;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  [Serializable]
  public class University: IUniversity
  {
    /// <summary>
    /// Идентификатор университета.
    /// </summary>
    [JsonProperty("university")]
    public int Id { get; set; }

    /// <summary>
    /// Название университета.
    /// </summary>
    [JsonProperty("university_name")]
    public string Name { get; set; }

    /// <summary>
    ///  Идентификатор страны, в которой расположен университет.
    /// </summary>
    [JsonProperty("country")]
    public int? CountryId { get; set; }

    /// <summary>
    /// Идентификатор города, в котором расположен университет.
    /// </summary>
    [JsonProperty("city")]
    public int? CityId { get; set; }

    /// <summary>
    /// Год окончания.
    /// </summary>
    public int? Graduation { get; set; }

    /// <summary>
    /// Идентификатор кафедры.
    /// </summary>
    [JsonProperty("chair")]
    public int? ChairId { get; set; }

    /// <summary>
    /// Наименование кафедры.
    /// </summary>
    [JsonProperty("chair_name")]
    public string ChairName { get; set; }

    /// <summary>
    /// Форма обучения.
    /// </summary>
    [JsonProperty("education_form")]
    public string EducationForm { get; set; }

    /// <summary>
    /// Идентификатор факультета.
    /// </summary>
    [JsonProperty("faculty")]
    public int? FacultyId { get; set; }

    /// <summary>
    /// Название факультета.
    /// </summary>
    [JsonProperty("faculty_name")]
    public string FacultyName { get; set; }

    /// <summary>
    /// Статус(например, «Выпускник (специалист)»).
    /// </summary>
    [JsonProperty("education_status")]
    public string EducationStatus { get; set; }
  }
}
 