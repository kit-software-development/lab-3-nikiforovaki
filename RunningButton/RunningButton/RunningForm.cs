using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningButton
{
    public partial class RunningForm : Form
    {
        public RunningForm()
        {
            InitializeComponent();
        }

        private void Runbutton_MouseMove(object sender, MouseEventArgs e)
        {
            int k;//Коэффициент перемещения по оси x и у. Имеет бинарные состояния: вперед и назад по оси
            if ((e.X - RunButton.Width / 2) < 0)
                k = 2;
            else
                k = 1;
            if (RunButton.Location.X <= 23)
                k = 2;
            else if (ClientSize.Width < RunButton.Location.X + 105)
                k = 1;
            int coordX = Convert.ToInt32(RunButton.Location.X + 50 * ((Math.Pow(-1, k))));
            if ((e.Y - RunButton.Height / 2) < 0)
                k = 2;
            else
                k = 1;
            if (RunButton.Location.Y <= 20)
                k = 2;
            else if (ClientSize.Height < RunButton.Location.Y + 50)
                k = 1;
            int coordY = Convert.ToInt32(RunButton.Location.Y + 50 * (Math.Pow(-1, k)));
            RunButton.Location = new System.Drawing.Point(coordX, coordY);
        }

        private void OnButton_Click(object sender, EventArgs e) //при нажатии на кнопку 
        {
            MessageBox.Show("\"Поздравляем! Вы смогли нажать на кнопку!\"");
        }

        //private void FormChanged(object sender, EventArgs e)
        //{
        //    int coordX = RunButton.Location.X;
        //    int coordY = RunButton.Location.Y;
        //    if ((RunButton.Location.X > ClientSize.Width - RunButton.Width) || (RunButton.Location.X <= 0))
        //        coordX = Convert.ToInt32(ClientSize.Width / 2);
        //    if ((RunButton.Location.Y > ClientSize.Height - RunButton.Height) || (RunButton.Location.Y <= 0))
        //        coordY = Convert.ToInt32(ClientSize.Height / 2);
        //    RunButton.Location = new System.Drawing.Point(coordX, coordY);
        //}
    }
}