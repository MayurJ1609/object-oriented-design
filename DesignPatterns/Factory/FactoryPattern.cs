using System;

namespace System.FactoryPatterns
{
    /* Factory Pattern - Factory pattern is used when there are mutliple methods creating an object of another class, create a factory (like helper class).
    NOTE: The helper class / Factory is generic here, it should not act depends on the input from other class / methods
    */
    public class FactoryPattern
    {
        public void mainEntry()
        {
            new NavigationBar();
            new DropDownMenu();
        }
    }

    public class NavigationBar
    {
        Button navigationBarButton;

        public NavigationBar()
        {
            navigationBarButton = ButtonFactory.CreateButton();
        }
        //  => new Button { Type = "Default Button".Dump() };
    }

    public class DropDownMenu
    {
        Button ddButton;

        public DropDownMenu()
        {
            ddButton = ButtonFactory.CreateButton();
        }
        //  => new Button { Type = "Default Button".Dump() };
    }

    public class ButtonFactory
    {
        public static Button CreateButton()
        {
            Button button = new Button();
            button.Type = "Default Button";
            return button;
        }
    }

    public class Button
    {
        public string Type { get; set; }
    }
}
