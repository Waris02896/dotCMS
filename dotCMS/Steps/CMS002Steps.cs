using dotCMS.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotCMS.Steps
{
    public class CMS002Steps
    {
        CMS002Actions action = new CMS002Actions();

        public void ClickContectButton()
        {
            action.OpenMenu();
            action.ContentForm();
        }

        public void ChangeTypeToPersona()
        {
            action.InputInPersonaFilter();
        }
    }
}
