using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfaDrawPlayBoard;

namespace wfaDrawPlayBoard2._0.Model
{
    internal class BlackWhiteChessBoard : BaseBoard
    {
        private int itemsize = 80;
        public override string Name => "Чёрно-белая шахматная доска";

        public override Color Color1 { get => Color.White; set => throw new NotImplementedException(); }
        public override Color Color2 { get => Color.Black; set => throw new NotImplementedException(); }
        public override int ItemSize { get => itemsize; set => itemsize = value; }
        public override int BoardSize { get => 8; }
        public override Color BackgrounColor { get => Color.LightGray; set => throw new NotImplementedException(); }
    }
}
