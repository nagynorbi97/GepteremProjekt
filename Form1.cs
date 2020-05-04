using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace GepteremProjekt {
    public partial class GepteremProjekt : Form {
        static List<Gepterem> geptermek;
        public GepteremProjekt() {
            InitializeComponent();
            elozo.BackgroundImage = Image.FromFile("kepek/bal.jpg");
            kovetkezo.BackgroundImage = Image.FromFile("kepek/jobb.jpg");
            mentes.BackgroundImage = Image.FromFile("kepek/ment.jpg");
            PetrikLajosSzg petrikLajosSzg = new PetrikLajosSzg("petrikgepek.txt");
            geptermek = petrikLajosSzg.Geptermek;
            if (geptermek.Count > 0) {
                int gepteremSorszam = 1;
                gepterem(gepteremSorszam);
                elozo.MouseDown += (se, ev) => {
                    if (--gepteremSorszam < 1) {
                        gepteremSorszam = 4;
                    }
                    gepterem(gepteremSorszam);
                };
                kovetkezo.MouseDown += (se, ev) => {
                    gepteremSorszam = gepteremSorszam % geptermek.Count + 1;
                    gepterem(gepteremSorszam);
                };
                mentes.Click += (se, ev) => {
                    petrikLajosSzg.Mentes("petrikgepek.txt");
                };
            } else {
                MessageBox.Show("Nem található gépterem");
            }
        }
        private void gepterem(int gepteremSorszam) {
            Gepterem gepterem = geptermek[gepteremSorszam-1];
            this.Text = string.Format("{0} ({1})", gepterem.Nev, Math.Round(gepterem.Atlag(),2));
            kep.BackgroundImage = Image.FromFile("kepek/"+gepterem.Nev.Split(' ')[0]+".jpg");
            gombok.Controls.Clear();
            for (int s = 0; s < gepterem.SorDb; s++) {
                for (int h = 0; h < gepterem.HelyDb; h++) {
                    PictureBox gomb = new PictureBox();
                    gomb.Location = new Point(h * 40 + h*2, s * 40 + s*2);
                    gomb.Size = new Size(40, 40);
                    int ertekeles = gepterem.Ertekeles[s, h];
                    gomb.BackgroundImage = Image.FromFile("kepek/Pont" + (ertekeles) + ".jpg");
                    gomb.BackgroundImageLayout = ImageLayout.Zoom;
                    int[] eI = { s, h };
                    gomb.MouseDown += (se, ev) => {
                        if (ertekeles > 0) {
                            ertekeles = ertekeles % 3 + 1;
                            gomb.BackgroundImage = Image.FromFile("kepek/Pont" + (ertekeles) + ".jpg");
                            gepterem.Ertekeles[eI[0], eI[1]] = ertekeles;
                            this.Text = string.Format("{0} ({1})", gepterem.Nev, Math.Round(gepterem.Atlag(), 2));
                        } else {
                            MessageBox.Show("Ezen a helyen nem ült senki.");
                        }
                    };
                    gombok.Controls.Add(gomb);
                }
            }
        }
    }
}
