namespace WT_LR1.Models
{
    public class MenuItem
    {
        public bool IsPage { get; set; } = false;
        public string Text { get; set; } = "";
        public string ControllerName { get; set; } = "";
        public string ActionName { get; set; } = "";
        public string PageName { get; set; } = "";
        public string AreaName { get; set; } = "";
        public string CssClass { get; set; } = "";
    }

}
