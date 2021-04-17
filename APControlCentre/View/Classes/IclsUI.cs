using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APControlCentre.View
{
    interface IClsMain
    {
        void SubscribeEvents();
        void UnSubscribeEvents();
        void SetDefaultValues();
    }
    interface IClsUI : IClsMain
    {        
        void ChangeIcon(ref object pbox, EnumNewOldIndicator indicator);
    }

    public enum EnumNewOldIndicator
    {
        New,
        Old
    }
}
