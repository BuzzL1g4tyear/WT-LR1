using Microsoft.AspNetCore.Mvc;
using WT_LR1.Models;

namespace WT_LR1.Components
{
    public class MenuViewComponent:ViewComponent
    {
        private List<MenuItem> _menuItems = new List<MenuItem>
{
        new MenuItem{ ControllerName="Home", ActionName="Index", Text="Lab 2"},
        new MenuItem{ ControllerName="Product", ActionName="Index",
        Text="Каталог"},
        new MenuItem{ IsPage=true, AreaName="Admin", PageName="/Index",
        Text="Администрирование"}
        };

        public IViewComponentResult Invoke()
        {
            //Получение значений сегментов маршрута
            var controller = ViewContext.RouteData.Values["controller"];
            var page = ViewContext.RouteData.Values["page"];
            var area = ViewContext.RouteData.Values["area"];
            foreach (var item in _menuItems)
            {
                // Название контроллера совпадает?
                var _matchController = controller?.Equals(item.ControllerName)
                ?? false;

                // Название зоны совпадает?
                var _matchArea = area?.Equals(item.AreaName) ?? false;
                // Если есть совпадение, то сделать элемент меню активным
                // (применить соответствующий класс CSS)
                if (_matchController || _matchArea)
                {
                    item.ActionName = "active";
                }
            }
            return View(_menuItems);
        }
    }
}
