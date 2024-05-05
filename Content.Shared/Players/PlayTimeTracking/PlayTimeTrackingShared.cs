using Content.Shared.Dataset;

namespace Content.Shared.Players.PlayTimeTracking;

public static class PlayTimeTrackingShared
{
    /// <summary>
    /// The prototype ID of the play time tracker that represents overall playtime, i.e. not tied to any one role.
    /// </summary>
    [ValidatePrototypeId<PlayTimeTrackerPrototype>]
    public const string TrackerOverall = "Overall";

    //SS220-aghost-playtime begin
    /// <summary>
    /// The prototype ID of the play time tracker that represents overall time with admin priveleges.
    /// </summary>
    [ValidatePrototypeId<PlayTimeTrackerPrototype>]
    public const string TrackerAdmin = "AdminTime";

    /// <summary>
    /// The prototype ID of the play time tracker that represents admin ghost playtime.
    /// </summary>
    [ValidatePrototypeId<PlayTimeTrackerPrototype>]
    public const string TrackerAGhost = "AGhostTime";

    /// <summary>
    /// The prototype ID of the play time tracker that represents overall time in ghost.
    /// </summary>
    [ValidatePrototypeId<PlayTimeTrackerPrototype>]
    public const string TrackerObserver = "ObserverTime";
    //SS220-aghost-playtime end
}
