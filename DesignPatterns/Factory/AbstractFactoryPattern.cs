using System;

namespace DesignPatterns.AbstractFactoryPatterns
{
    /*  Abstract factory pattern is just a small difference from factory pattern. In factory pattern, the factory class should not behave based on other class input, but in abstract factory - the factory class should behave based on other class input. This is also called DEPENDENCY INJECTION
    */
    public class AbstractFactoryPattern
    {
        public void mainEntry()
        {
            new NavigationBar(new Android());
            new DropDownMenu(new Android());
        }
    }
    public class NavigationBar
    {
        Button navigationBarButton;
        public NavigationBar(IUIFactory factory)
        {
            navigationBarButton = factory.CreateButton();
        }
        //  => factory.CreateButton();
    }

    public class DropDownMenu
    {
        Button ddButton;
        public DropDownMenu(IUIFactory factory)
        {
            ddButton = factory.CreateButton();
        }
    }

    public interface IUIFactory
    {
        public Button CreateButton();
        // public Button CreateButton();
    }

    public class Apple : IUIFactory
    {
        public Button CreateButton()
        {
            return new Button()
            {
                Type = "IOS button"
            };

            // return new Button {Type = "ios Button".Dump()};
        }
    }

    public class Android :IUIFactory
    {
        public Button CreateButton()
        {
            return new Button()
            {
                Type = "Android button"
            };
            // return new Button {Type = "android Button".Dump()};
        }
    }

    public class Button
    {
        public string Type { get; set; }
    }
}