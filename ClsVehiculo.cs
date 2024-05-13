using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryBlaiottaEtapa5
{
    internal class ClsVehiculo
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public Image Imagen { get; set; }


        public void crearVehiculo(PictureBox pctVehiculo)
        {
            PictureBox vehiculo = new PictureBox();
            Random rnd = new Random();

            // Generar una posición aleatoria dentro del PictureBox sin excederse de los marcos 
            int posX = rnd.Next(0, vehiculo.Width + 600);
            int posY = rnd.Next(0, vehiculo.Height + 300);
            switch (rnd.Next(1, 4))
            {
                case 1:
                    Nombre = "Peugeot";
                    Tipo = "Auto";
                    Imagen = pryBlaiottaEtapa5.Properties.Resources.auto;
                    break;
                case 2:
                    Nombre = "Bayliner";
                    Tipo = "Barco";
                    Imagen = pryBlaiottaEtapa5.Properties.Resources.barco;
                    break;
                case 3:
                    Nombre = "Iberia";
                    Tipo = "Avion";
                    Imagen = pryBlaiottaEtapa5.Properties.Resources.avion;
                    break;
            }
            vehiculo.Image = Imagen;
            vehiculo.SizeMode = PictureBoxSizeMode.StretchImage;
            vehiculo.Location = new Point(posX, posY);
            vehiculo.Size = new Size(100, 100);

            pctVehiculo.Controls.Add(vehiculo);
            vehiculo.BringToFront();

        }
    }
}