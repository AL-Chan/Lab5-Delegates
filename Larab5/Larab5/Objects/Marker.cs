using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace Larab5.Objects
{
    class Marker : BaseObject
    {
        //конструктор
        public Marker (float x, float y, float angle) : base(x, y, angle)
        {

        }

        public override void Render(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Red), -3, -3, 6, 6);//точка прицела
            g.DrawEllipse(new Pen(Color.Red, 2), -6, -6, 12, 12);//первый круг
            g.DrawEllipse(new Pen(Color.Red, 2), -12, -12, 24, 24);//второй
        }
        public override GraphicsPath GetGraphicsPath()
        {
            var path = base.GetGraphicsPath();
            path.AddEllipse(-3, -3, 6, 6);
            return path;
        }
    }
}
