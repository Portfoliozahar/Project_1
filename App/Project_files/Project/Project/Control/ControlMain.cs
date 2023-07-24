using Project.Data;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Control
{
    public class ControlMain
    {
        LocalDatabase database;
        Endpoints endpoints;

        public ControlMain()
        {
            database = LocalDatabase.GetInstance();
            endpoints = new Endpoints();
        }

        public List<MenuItem> GetMenuList()
        {
            List<MenuItem> menu = new List<MenuItem>
            {
                new MenuItem("Главная Панель", MaterialDesignThemes.Wpf.PackIconKind.ViewDashboard),
                new MenuItem("Профиль", MaterialDesignThemes.Wpf.PackIconKind.Account),
                new MenuItem("Доходы", MaterialDesignThemes.Wpf.PackIconKind.PlusCircleOutline),
                new MenuItem("Затраты", MaterialDesignThemes.Wpf.PackIconKind.MinusCircleOutline),
                
            };
            return menu;
        }

        
        
    }
}
