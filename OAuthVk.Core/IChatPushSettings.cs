namespace OAuthVk.Core
{
  public interface IChatPushSettings
  {
    /// <summary>
    /// Идентификатор собеседника.
    /// </summary>
    long? PeerId { get; set; }

    /// <summary>
    /// Состояние звукового оповещения
    /// </summary>
    bool? IsSound { get; set; }

    /// <summary>
    /// Указывает, до какого времени оповещения отключены.
    /// </summary>
    int? DisabledUntil { get; set; }
  }
}