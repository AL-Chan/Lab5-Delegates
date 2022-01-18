using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Larab5.Objects
{
    class BaseObject
    {
        // точки расположения в виде координат X и Y и угол поворота
        public float X, Y;
        public float Angle;

        public Action<BaseObject, BaseObject> onOverlap; //реакция на события

        public BaseObject(float x, float y, float angle)
        {
            X = x;
            Y = y;
            Angle = angle;
        }

        //сдвигание с помощью матрицы трансформаций
        public Matrix GetTransform()
        {
            var matrix = new Matrix();
            matrix.Translate(X, Y);

            return matrix;
        }

        public virtual void Render(Graphics g)
        {}

        public virtual GraphicsPath GetGraphicsPath()
        {
            return new GraphicsPath();
        }

        public virtual bool Overlaps(BaseObject obj, Graphics g)
        {
            // берем информацию о форме
            var path1 = this.GetGraphicsPath();
            var path2 = obj.GetGraphicsPath();

            // применяем к объектам матрицы трансформации
            path1.Transform(this.GetTransform());
            path2.Transform(obj.GetTransform());
            //пересечение формы
            var region = new Region(path1);
            region.Intersect(path2);
            return !region.IsEmpty(g);
        }
        public virtual void Overlap(BaseObject obj)
        {
            if (this.onOverlap != null)
            {
                this.onOverlap(this, obj);
            }
        }
    }
}
