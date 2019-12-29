using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Functions.Events
{
    public class SelectedChangedEventArgs : EventArgs
    {
        public int Index { get; set; }
    }
}
