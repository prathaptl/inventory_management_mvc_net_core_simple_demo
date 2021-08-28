using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagement.Web.Models
{
    public class MenuViewModel
    {
        public IList<MainMenuItem> Menus { get; set; }
        public MenuViewModel()
        {
            Menus = new List<MainMenuItem>();
        }
        public MenuViewModel AddMainMenu(MainMenuItem item)
        {
            if (item.Visible)
                Menus.Add(item);
            return this;
        }
        public void MakeSelection(string[] path)
        {
            if (path.Length == 0)
                return;

            var selectedMainMenu = Menus.FirstOrDefault(x => x.Text == path[0]);
            if (selectedMainMenu != null)
            {
                selectedMainMenu.IsActive = true;
                if (path.Length < 2)
                    return;

                var selectedSubMenu = selectedMainMenu.SubMenus.FirstOrDefault(x => x.Entity == path[1]);
                if (selectedSubMenu != null)
                    selectedSubMenu.IsActive = true;
            }
        }
    }

    public class MainMenuItem
    {
        public string Text { get; set; }
        public string Icon { get; set; }
        public string URL { get; set; }
        public bool IsActive { get; set; }
        public bool Visible { get; set; }
        public IList<SubMenuItem> SubMenus { get; set; }
        public MainMenuItem(string text, bool visible, string icon = "", string url = "")
        {
            Text = text;
            Visible = visible;
            Icon = icon;
            URL = url;
            SubMenus = new List<SubMenuItem>();
        }
        public MainMenuItem AddSubMenu(SubMenuItem item)
        {
            if (item.Visible)
                SubMenus.Add(item);
            return this;
        }
    }

    public class SubMenuItem
    {
        public string Text { get; set; }
        public string Entity { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
        public bool Visible { get; set; }
        public string Target { get; set; }

        public string Icon { get; set; }

        public SubMenuItem(string text, string entity, bool visible, string url = "", string target = "", string icon = "")
        {
            Text = text;
            Entity = entity;
            Visible = visible;
            Url = url;
            Target = target;
            if (url == "")
                Url = "/" + Entity;
            Icon = icon;
        }

    }

}
