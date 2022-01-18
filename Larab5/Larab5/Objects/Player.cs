using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Larab5.Objects
{
    class Player : BaseObject
    {
        public Action<Marker> onMarkerOverlap;
        //конструктор
        public Player (float x, float y, float angle) : base(x, y, angle)
        {
        }
        public override void Render(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.DeepSkyBlue), -15, -15, 30, 30);//заливка
            g.DrawEllipse(new Pen(Color.Black, 2), -15, -15, 30, 30);//рамка
            g.DrawLine(new Pen(Color.Black, 2), 0, 0, 25, 0);//указатель направления
        }
        public override GraphicsPath GetGraphicsPath()
        {
            var path = base.GetGraphicsPath();
            path.AddEllipse(-15, -15, 30, 30);
            return path;
        }
        public override void Overlap(BaseObject obj)
        {
            base.Overlap(obj);

            if (obj is Marker)
            {
                onMarkerOverlap(obj as Marker);
            }
        }
    }
}
