using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static WT_LR1.Controllers.Home;

namespace WT_LR1.Controllers
{
    public class Home : Controller
    {
        private List<ListDemo> _listDemo;
        public class ListDemo
        {
            public int ListItemValue { get; set; }
            public string ListItemText { get; set; }

        }

        public IActionResult Index()
        {
            ViewData["Text"] = "Лабораторная работа 2|3";
            ViewData["Lst"] = new SelectList(_listDemo, "ListItemValue", "ListItemText");
            return View();
        }

        public Home()
        {
            _listDemo = new List<ListDemo>
            {
            new ListDemo{ ListItemValue=1, ListItemText="Item 1"},
            new ListDemo{ ListItemValue=2, ListItemText="Item 2"},
            new ListDemo{ ListItemValue=3, ListItemText="Item 3"}
            };
        }
    }
}
