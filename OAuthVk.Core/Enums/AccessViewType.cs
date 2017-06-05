namespace OAuthVk.Core.Enums
{
  public enum AccessViewType
  {
    /// <summary>
    /// Доступ только у руководителей.
    /// </summary>
    OnlyLeaders = 0,

    /// <summary>
    /// Доступ только у участников.
    /// </summary>
    OnlyCommunity = 1,

    /// <summary>
    /// Доступ есть у всех.
    /// </summary>
    All = 2
  }
}