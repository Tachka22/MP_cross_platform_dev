using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfaDrawPlayBoard;

namespace wfaDrawPlayBoard2._0.Model
{
    internal class GoBoard : BaseBoard
    {
        private int itemSize = 40;

        public override string Name => "Го";

        public override Color Color1 { get => Color.FromArgb(205, 133, 63); set => throw new NotImplementedException(); }
        public override Color Color2 { get => Color.FromArgb(205, 133, 63); set => throw new NotImplementedException(); }
        public override int ItemSize
        {
            get => itemSize; set
            {
                itemSize= value;
            }
        }
        public override int BoardSize { get => 18; }
        public override Color BackgrounColor { get =>Color.FromArgb(255, 248, 220); set => throw new NotImplementedException(); }
    }
}
