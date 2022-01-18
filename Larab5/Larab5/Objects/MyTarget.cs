using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Larab5.Objects
{
    class MyTarget : BaseObject
    {
        //конструктор
        public MyTarget(float x, float y, float angle) : base(x, y, angle)
        {
        }

        public override void Render(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Crimson), -15, -15, 30, 30); //заливка
            g.DrawEllipse(new Pen(Color.Black, 1), -15, -15, 30, 30); //рамка
        }
    }
}
