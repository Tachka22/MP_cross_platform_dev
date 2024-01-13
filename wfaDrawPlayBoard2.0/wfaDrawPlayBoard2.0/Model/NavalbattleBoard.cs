using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaDrawPlayBoard
{
    internal class NavalbattleBoard : BaseBoard
    {
        private int itemsize = 50;
        public override string Name => "Морской бой";

        public override Color Color1 { get => Color.FromArgb(255, 255, 255); set => throw new NotImplementedException(); }
        public override Color Color2 { get => Color.FromArgb(255, 255, 255); set => throw new NotImplementedException(); }
        public override int ItemSize { get => itemsize; set => itemsize = value; }
        public override int BoardSize { get => 10; }
        public override Color BackgrounColor { get => Color.FromArgb(30, 144, 255); set => throw new NotImplementedException(); }
    }
}
