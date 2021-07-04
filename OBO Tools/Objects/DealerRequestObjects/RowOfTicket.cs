using System;
using System.Collections.Generic;
using System.Text;

namespace OBO_Tools.Scripts.DealerRequest
{
    class RowOfTicket
    {
        public String numberOfRow;
        public String nameOfRow;
        public String valueOfRow;

        public RowOfTicket(String[] masWithInfoOfObject)
        {
            this.numberOfRow = masWithInfoOfObject[0].Trim();
            this.nameOfRow = masWithInfoOfObject[1].Trim();
            this.valueOfRow = masWithInfoOfObject[2].Trim();
        }
    }
}
