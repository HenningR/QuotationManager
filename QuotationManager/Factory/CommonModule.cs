using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotationManager.Factory
{
    public class CommonModule
    {
        public enum InfoType
        {
            Warning = 1
            , Error = 2
            , Success = 3
        }

        public enum windowState
        {
            AddMain
            , AddSub
            , Edit
            , Remove
            , None
        }
    }
}
