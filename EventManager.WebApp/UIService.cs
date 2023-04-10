using EventManager.DomainLayer;

namespace WebApp;

public class UIService
{
    public enum Color { primary, secondary, success, danger, warning, info, light, dark }

    public static Color GetColorByStatus(Status status) =>
        new Dictionary<Status, Color>
        {
            { Status.Upcoming, Color.success },
            { Status.Inactive, Color.light },
            { Status.Cancelled, Color.danger },
            { Status.BookedOut, Color.dark }
        }[status];

    // public static Color GetColorByActionPriviledge(UserRole requiredPriviledge) =>
    //     new Dictionary<UserRole, Color>
    //     {
    //         { UserRole.Admin, Color.primary },
    //         { UserRole.Customer, Color.success }
    //     }[requiredPriviledge];
    public static string GetColorStringByStatus(Status status) => GetColorByStatus(status).ToString() ?? "";
}