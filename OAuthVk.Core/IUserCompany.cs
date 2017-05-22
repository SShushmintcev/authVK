
namespace OAuthVk.Core
{
  public interface IUserCompany
  {
    /// <summary>
    /// Идентификатор сообщества(если доступно, иначе company).
    /// </summary>
    int? GroupId { get; set; }

    /// <summary>
    /// Название компании(если доступно, иначе group_id).
    /// </summary>
    string Company { get; set; }

    /// <summary>
    /// Идентификатор страны.
    /// </summary>
    int CountryId { get; set; }

    /// <summary>
    /// Идентификатор города.
    /// </summary>
    int CityId { get; set; }

    /// <summary>
    /// Год начала работы.
    /// </summary>
    int? From { get; set; }

    /// <summary>
    /// Год окончания работы.
    /// </summary>
    int? Until { get; set; }

    /// <summary>
    /// Должность.
    /// </summary>
    string Position { get; set; }
  }
}