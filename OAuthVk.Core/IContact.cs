namespace OAuthVk.Core
{
  public interface IContact
  {
    /// <summary>
    /// Номер мобильного телефона пользователя(только для Standalone-приложений)
    /// </summary>
    string MobilePhone { get; set; }

    /// <summary>
    /// Дополнительный номер телефона пользователя.
    /// </summary>
    string HomePhone { get; set; }
  }
}