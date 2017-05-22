using System;
using Newtonsoft.Json;
using OAuthVk.Core;
using OAuthVk.Core.Enums;

namespace OAuthVk.Model
{
  [Serializable]
  public class School : ISchool
  {
    /// <summary>
    /// Идентификатор школы.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Идентификатор страны, в которой расположена школа.
    /// </summary>
    public int Country { get; set; }

    /// <summary>
    /// Идентификатор города, в котором расположена школа.
    /// </summary>
    public int City { get; set; }

    /// <summary>
    /// Наименование школы.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Год начала обучения.
    /// </summary>
    [JsonProperty("year_from")]
    public int YearFrom { get; set; }

    /// <summary>
    /// Год окончания обучения.
    /// </summary>
    [JsonProperty("year_to")]
    public int YearTo { get; set; }

    /// <summary>
    /// Год выпуска.
    /// </summary>
    [JsonProperty("year_graduated")]
    public int YearGraduated { get; set; }

    /// <summary>
    /// Буква класса.
    /// </summary>
    public string Class { get; set; }

    /// <summary>
    /// Специализация.
    /// </summary>
    public string Speciality { get; set; }

    /// <summary>
    /// Идентификатор типа.
    /// </summary>
    public SchoolType Type { get; set; }

    /// <summary>
    /// Название типа.
    /// </summary>
    [JsonProperty("type_str")]
    public string TypeName { get; set; }
  }
}