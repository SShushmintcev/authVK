using OAuthVk.Core.Filters;

namespace OAuthVk.Model.Filter
{
  public class AccountPushFilter : IAccountPushFilter
  {
    /// <summary>
    /// Уникальный идентификатор устройства.
    /// </summary>
    public int DeviceId { get; set; }

    /// <summary>
    /// Время в секундах на которое требуется отключить уведомления, -1 отключить навсегда.
    /// </summary>
    public int? Time { get; set; }

    /// <summary>
    /// Идентификатор назначения.
    /// </summary>
    public int? PeerId { get; set; }

    /// <summary>
    /// Состояние звукового оповещения
    /// (параметр работает, только если в peer_id передан идентификатор групповой беседы или пользователя). 
    /// </summary>
    public bool Sound { get; set; }
  }
}