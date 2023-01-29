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
    internal class LinuxUserInterfaceFactory:UserInterfaceFactory
    {
        public Button GetButton()
        {
            return new LinuxButton
            {
                color = LinuxConstants.BUTTON_COLOR,
                height = LinuxConstants.BUTTON_HEIGHT,
                width = LinuxConstants.BUTTON_WIDTH,
                Name = LinuxConstants.NAME
            };
        }

        public TextBox GetTextBox()
        {
            return new LinuxTextBox
            {
                height = LinuxConstants.TEXTBOX_HEIGHT,
                width = LinuxConstants.TEXTBOX_WIDTH,
                Name = LinuxConstants.NAME,
                maxLength = LinuxConstants.TEXTBOX_MAX_LENGTH
            };
        }
    }
}
