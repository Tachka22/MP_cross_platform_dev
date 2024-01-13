using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaDrawPlayBoard
{
    public abstract class BaseBoard
    {
        public abstract string Name { get; }
        public abstract Color Color1 { get; set; }
        public abstract Color Color2 { set; get; }
        public abstract int ItemSize { get; set ; }
        public abstract int BoardSize { get;}
        public abstract Color BackgrounColor { get; set; }

    }
}
