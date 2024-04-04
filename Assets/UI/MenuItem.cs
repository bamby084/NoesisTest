
namespace Testing
{
    public class MenuItem
    {
        public string Title { get; set; }
        public IconType? Icon { get; set; }
        public MenuItemType MenuItemType { get; set; } = MenuItemType.Normal;
        public bool IsSelected { get; set; }
    }

    public enum MenuItemType
    {
        Normal,
        GroupItem
    }
}
