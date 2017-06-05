namespace OAuthVk.Core.Filters
{
  public interface IPasswordFilter
  {
    /// <summary>
    /// Идентификатор сессии, полученный при восстановлении доступа используя метод <see cref="AdminAccessor.RestoreAsync"/>.
    /// (В случае если пароль меняется сразу после восстановления доступа)
    /// </summary>
    string sessionId { get; set; }

    /// <summary>
    /// Хэш, полученный при успешной OAuth авторизации по коду полученному по СМС.
    /// (В случае если пароль меняется сразу после восстановления доступа)
    /// </summary>
    string hash { get; set; }

    /// <summary>
    /// Текущий пароль пользователя.
    /// </summary>
    string oldPassword { get; set; }

    /// <summary>
    /// Новый пароль, который будет установлен в качестве текущего (минимальная длина 6).
    /// </summary>
    string newPassword { get; set; }
  }
}