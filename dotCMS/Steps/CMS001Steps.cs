using dotCMS.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotCMS.Steps
{
    public class CMS001Steps
    {
        CMS001Actions action = new CMS001Actions();

        public void ClickContectButton()
        {
            action.OpenMenu();
            action.ContentForm();
        }

        public void ChangeTypeToPersona()
        {
            action.InputInPersonaFilter();
        }

        public void ClickPlusIconButton()
        {
            action.ClickPlusButton();
            action.OpenNewPersonaForm();
        }

        public void FillForm()
        {
            action.fillForm();
        }

        public void SavePersona()
        {
            action.save();
        }

        public void publishPersona()
        {
            action.publish();
        }
    }
}
