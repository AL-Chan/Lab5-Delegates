using Larab5.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Larab5
{
    public partial class Form1 : Form
    {
        //MyTarget myEnemy;// поле для вражин
        List<BaseObject> objects = new List<BaseObject>();
        Player player;// поле для игрока
        Marker marker;
        float X, Y;

        public Form1()
        {
            InitializeComponent();
            player = new Player(Mainframe.Width / 2, Mainframe.Height / 2);
            //реакция на пересечение
            player.onOverlap += (p, obj) =>
            {
                textlog.Text = $"[{DateTime.Now:HH:mm:ss:ff}] Игрок пересекся с {obj}\n" + textlog.Text;
            };
            //реакция на пересечение с маркером
            player.onMarkerOverlap += (m) =>
            {
                objects.Remove(m);
                marker = null;
            };
            marker = new Marker(Mainframe.Width / 2+40, Mainframe.Height / 2+40);

            objects.Add(marker);
            objects.Add(player);
            objects.Add(new MyTarget(50, 50));
            objects.Add(new MyTarget(100, 100));
        }

        private void Mainframe_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics; 
            g.Clear(Color.White);

            updPlayer(); //вывод отдельного метода под движение
            //пересчет
            foreach (var obj in objects.ToList())
            {
                //проверка на пересечение
                if (obj != player && player.Overlaps(obj, g))
                {
                    player.Overlap(obj); // игрок пересекся с объектом
                    obj.Overlap(player); // объект пересекся с игроком
                }
            }
            //обработка объектов
            foreach (var obj in objects)
            {
                g.Transform = obj.GetTransform();
                obj.Render(g);
            }
        }

        private void updPlayer()
        {
            if (marker != null)
            {
                //вектор между игроком и прицелом
                float dx = marker.X - player.X;
                float dy = marker.Y - player.Y;
                //находим длину вектора
                float dlina = (float)Math.Sqrt(dx * dx + dy * dy);
                dx /= dlina;
                dy /= dlina;
                player.X += dx * 2;
                player.Y += dy * 2;

                player.vX += dx * 0.45f;
                player.vY += dy * 0.45f;

                //поворот игрока 
                //player.Angle = (float)(90 - Math.Atan2(player.vX, player.vY) * 180 / Math.PI);
            }

            // тормозящий момент,постепенное замедление
            player.vX += -player.vX * 0.12f;
            player.vY += -player.vY * 0.12f;

            // пересчет позиция игрока с помощью вектора скорости
            player.X += player.vX;
            player.Y += player.vY;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Mainframe.Invalidate();
        }

        private void Mainframe_MouseClick(object sender, MouseEventArgs e)
        {
            if (marker == null)
            {
                marker = new Marker(0, 0);
                objects.Add(marker);
            }

            marker.X = e.X;
            marker.Y = e.Y;
        }
    }
}
