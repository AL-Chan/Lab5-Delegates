using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Larab5.Objects
{
    class MyTarget : BaseObject
    {
        //конструктор
        public MyTarget(float x, float y) : base(x, y)
        {
        }

        public override void Render(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.LawnGreen), -15, -15, 30, 30); //заливка
            g.DrawEllipse(new Pen(Color.Black, 1), -15, -15, 30, 30); //рамка
            g.DrawString(
            "Текст",
            new Font("Verdana", 8), // шрифт и размер
            new SolidBrush(Color.Green), // цвет шрифта
            10, 10 // точка в которой нарисовать текст
        );
        }
        //
        public override GraphicsPath GetGraphicsPath()
        {
            GraphicsPath path = base.GetGraphicsPath();
            path.AddEllipse(-15, -15, 30, 30);
            return path;
        }
    }
}
