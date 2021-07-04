using System;
using System.Collections.Generic;
using System.Text;

namespace OBO_Tools.Scripts.DealerRequest
{
    class RowOfTicketObject
    {
        public String numberOfRow;
        public String nameOfRow;
        public String valueOfRow;

        public RowOfTicketObject(String[] masWithInfoOfObject)
        {
            this.numberOfRow = masWithInfoOfObject[0].Trim();
            this.nameOfRow = masWithInfoOfObject[1].Trim();
            this.valueOfRow = masWithInfoOfObject[2].Trim();
        }
    }
}
