namespace OAuthVk.Core.Filters
{
  public interface IAccountPushFilter
  {
    /// <summary>
    /// Уникальный идентификатор устройства.
    /// </summary>
    int DeviceId {get; set;}

    /// <summary>
    /// Время в секундах на которое требуется отключить уведомления, -1 отключить навсегда.
    /// </summary>
    int? Time {get; set;}

    /// <summary>
    /// Идентификатор назначения.
    /// Для пользователя:
    ///   id пользователя.
    /// Для групповой беседы:
    ///   2000000000 + id беседы.
    /// Для сообщества:
    ///   -id сообщества.
    /// </summary>
    int? PeerId {get; set;}

    /// <summary>
    /// Состояние звукового оповещения
    /// (параметр работает, только если в peer_id передан идентификатор групповой беседы или пользователя). 
    /// </summary>
    bool Sound {get; set;}
  }
}