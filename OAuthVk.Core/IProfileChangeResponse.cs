namespace OAuthVk.Core
{
  public interface IProfileChangeResponse
  {
    /// <summary>
    /// Признак того, что информация была сохранена.
    /// </summary>
    bool Changed {get;set;}

    /// <summary>
    /// Содержащий информацию о заявке на смену имени.
    /// </summary>
    /// <remarks>Если в параметрах передавалось имя или фамилия пользователя!</remarks>
    IRequestChangeName RequestChangeName { get; }
  }

  public interface IRequestChangeName
  {
    /// <summary>
    /// Идентификатор заявки, необходимый для её отмены (только если status равен processing).
    /// Для отмены заявки необходимо вызвать метод редактирования информации
    ///  текущего профиля с параметром 'Идентификатор заявки на смену имени'.
    /// </summary>
    int? Id {get;set;}

    /// <summary>
    /// Статус заявки.
    /// Возвращаемые значения:
    ///   success – имя было успешно изменено;
    ///   processing – заявка рассматривается;
    ///   declined – заявка отклонена;
    ///   was_accepted – недавно уже была одобрена заявка, повторную заявку можно подать не раньше даты, указанной в поле repeat_date;
    ///   was_declined – предыдущая заявка была отклонена, повторную заявку можно подать не раньше даты, указанной в поле repeat_date;
    /// </summary>
    string Status { get; set; }

    /// <summary>
    /// Имя пользователя.
    /// </summary>
    string FirstName {get;set;}

    /// <summary>
    /// Фамилия пользователя.
    /// </summary>
    string LastName {get;set;}
  }
}