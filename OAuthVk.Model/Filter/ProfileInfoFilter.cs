using OAuthVk.Core.Filters;

namespace OAuthVk.Model.Filter
{
  public class ProfileInfoFilter : Profile, IProfileInfoFilter
  {
    /// <summary>
    /// Идентификатор заявки на смену имени, которую необходимо отменить.
    /// Если передан этот параметр, все остальные параметры игнорируются.
    /// </summary>
    public int? CancelRequestId { get; set; }

    /// <summary>
    /// Идентификатор пользователя, с которым связано семейное положение.
    /// </summary>
    public int? RelationPartnerId { get; set; }

    /// <summary>
    /// Идентификатор страны пользователя.
    /// </summary>
    public int? CountryId { get; set; }

    /// <summary>
    /// Идентификатор города пользователя.
    /// </summary>
    public int? CityId { get; set; }
  }
}