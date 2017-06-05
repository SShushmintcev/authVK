using Newtonsoft.Json;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  public class ProfileChangeResponse : IProfileChangeResponse
  {
    /// <summary>
    /// Признак того, что информация была сохранена.
    /// </summary>
    public bool Changed { get; set; }

    /// <summary>
    /// Содержащий информацию о заявке на смену имени.
    /// </summary>
    /// <remarks>Если в параметрах передавалось имя или фамилия пользователя!</remarks>
    [JsonProperty("name_request")]
    public IRequestChangeName RequestChangeName { get; }
  }

  public class RequestChangeName : IRequestChangeName
  {
    /// <summary>
    /// Идентификатор заявки, необходимый для её отмены (только если status равен processing).
    /// Для отмены заявки необходимо вызвать метод редактирования информации
    ///  текущего профиля с параметром 'Идентификатор заявки на смену имени'.
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// Статус заявки.
    /// Возвращаемые значения:
    ///   success – имя было успешно изменено;
    ///   processing – заявка рассматривается;
    ///   declined – заявка отклонена;
    ///   was_accepted – недавно уже была одобрена заявка, повторную заявку можно подать не раньше даты, указанной в поле repeat_date;
    ///   was_declined – предыдущая заявка была отклонена, повторную заявку можно подать не раньше даты, указанной в поле repeat_date;
    /// </summary>
    /// TODO: Изменить и что за поле repeat_date!!!!
    public string Status { get; set; }

    /// <summary>
    /// Имя пользователя.
    /// </summary>
    [JsonProperty("first_name")]
    public string FirstName { get; set; }

    /// <summary>
    /// Фамилия пользователя.
    /// </summary>
    [JsonProperty("last_name")]
    public string LastName { get; set; }
  }
}