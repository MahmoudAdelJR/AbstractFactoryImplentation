using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIColors_AbstractFactoryImplentation.Interfaces
{
    internal interface UserInterfaceFactory
    {
        public Button GetButton();
        public TextBox GetTextBox();
    }
}
