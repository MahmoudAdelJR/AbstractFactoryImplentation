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
    internal class MacUserInterfaceFactory : UserInterfaceFactory
    {
        public Button GetButton()
        {
            return new MacButton
            {
                color = MacConstants.BUTTON_COLOR,
                height = MacConstants.BUTTON_HEIGHT,
                width = MacConstants.BUTTON_WIDTH,
                Name = MacConstants.NAME
            };
        }

        public TextBox GetTextBox()
        {
            return new MacTextBox
            {
                height = MacConstants.TEXTBOX_HEIGHT,
                width = MacConstants.TEXTBOX_WIDTH,
                Name = MacConstants.NAME,
                maxLength = MacConstants.TEXTBOX_MAX_LENGTH
            };
        }
    }
}
