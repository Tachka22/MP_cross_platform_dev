using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaDrawPlayBoard
{
    internal class Chessboard : BaseBoard
    {
        private int itemsize = 80;
        public override string Name => "Шахматная доска";
        public override Color Color1 { get => Color.FromArgb(240, 217, 181); set => throw new NotImplementedException(); }
        public override Color Color2 { get => Color.FromArgb(181, 136, 99); set => throw new NotImplementedException(); }
        public override int ItemSize { get => itemsize; set => itemsize = value; }
        public override int BoardSize { get => 8;  }
        public override Color BackgrounColor { get => Color.FromArgb(139, 69, 19); set => throw new NotImplementedException(); }

    }
}
