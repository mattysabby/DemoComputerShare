using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoComputerShare
{
    public enum SelectionEnum
    {
        [Description("Get All Records")]
        GetAllRecords,
        [Description("Add new Record")]
        AddRecord,
        [Description("Delete Record")]
        DeleteRecord


    }
}
