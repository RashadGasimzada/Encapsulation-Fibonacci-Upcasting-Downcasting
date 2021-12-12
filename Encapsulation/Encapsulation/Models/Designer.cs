using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation.Models
{
    public class Designer:Person
    {
        private string PcModel;
        public string PcModelProp { get { return PcModel; } set
            {
                PcModel = value;
            } }
    }
}
