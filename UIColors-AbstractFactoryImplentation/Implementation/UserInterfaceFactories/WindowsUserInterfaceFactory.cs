using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIColors_AbstractFactoryImplentation.Constants;
using UIColors_AbstractFactoryImplentation.Implementation.Buttons;
using UIColors_AbstractFactoryImplentation.Implementation.TextBoxes;
using UIColors_AbstractFactoryImplentation.Interfaces;

namespace UIColors_AbstractFactoryImplentation.Implementation.UserInterfaceFactories
{
    internal class Windows_UserInterfaceFactory:UserInterfaceFactory
    {
        public Button GetButton()
        {
            return new WindowsButton
            {
                color = WiindowsConstants.BUTTON_COLOR,
                height = WiindowsConstants.BUTTON_HEIGHT,
                width = WiindowsConstants.BUTTON_WIDTH,
                Name = WiindowsConstants.NAME
            };
        }

        public TextBox GetTextBox()
        {
            return new WidowsTextBox
            {
                height = WiindowsConstants.TEXTBOX_HEIGHT,
                width = WiindowsConstants.TEXTBOX_WIDTH,
                Name = WiindowsConstants.NAME,
                maxLength = WiindowsConstants.TEXTBOX_MAX_LENGTH
            };
        }
    }
}
