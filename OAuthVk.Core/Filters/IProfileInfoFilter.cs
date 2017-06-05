namespace OAuthVk.Core.Filters
{
  public interface IProfileInfoFilter : IProfile
  {
    /// <summary>
    /// Идентификатор заявки на смену имени, которую необходимо отменить.
    /// Если передан этот параметр, все остальные параметры игнорируются.
    /// </summary>
    int? CancelRequestId {get;set;}

    /// <summary>
    /// Идентификатор пользователя, с которым связано семейное положение.
    /// </summary>
    int? RelationPartnerId {get;set;}

    /// <summary>
    /// Идентификатор страны пользователя.
    /// </summary>
    int? CountryId {get;set;}

    /// <summary>
    /// Идентификатор города пользователя.
    /// </summary>
    int? CityId {get;set;}

  }
}