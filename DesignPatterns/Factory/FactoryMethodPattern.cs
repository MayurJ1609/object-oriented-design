using System;

namespace System.FactoryMethodPatterns
{
    /* Factory Pattern - Factory pattern is used when there are mutliple methods creating an object of another class, create a factory (like helper class).
    NOTE: The helper class / Factory is generic here, it should not act depends on the input from other class / methods
    */
    public class FactoryMethodPattern
    {
        public void mainEntry()
        {
            new NavigationBar();
            new DropDownMenu();
        }
    }

    public abstract class Element
    {
        protected abstract Button CreateButton();
        public Element() => CreateButton();
    }

    public class NavigationBar : Element
    {
        protected override Button CreateButton()
        {
            return new Button { Type = "Default Button" };
        }
    }

    public class DropDownMenu : Element
    {
        protected override Button CreateButton()
        {
            return new Button { Type = "Default Button" };
        }
    }

    public class AndroidNavigationBar : Element
    {
        protected override Button CreateButton()
        {
            return new Button { Type = "Android Default Button" };
        }
    }

    public class AndroidDropDownMenu : Element
    {
        protected override Button CreateButton()
        {
            return new Button { Type = "Android Default Button" };
        }
    }

    public class Button
    {
        public string Type { get; set; }
    }
}
