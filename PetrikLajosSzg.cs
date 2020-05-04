using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
namespace GepteremProjekt {
    class PetrikLajosSzg {
        private List<Gepterem> geptermek;
        public List<Gepterem> Geptermek { get => geptermek; }
        public PetrikLajosSzg(string filenev) {
            int dotI = filenev.LastIndexOf('.');
            string bak = "";
            if (dotI > -1) {
                bak = filenev.Substring(0, dotI) + ".bak";
            } else {
                bak = filenev + ".bak";
            }
            if (!File.Exists(filenev) && File.Exists(bak)) {
                File.Copy(bak, filenev, true);
                MessageBox.Show("A forrásfájl nem található, ezést a biztonsági mentésből helyreállítottuk.");
            }
            geptermek = new List<Gepterem>();
            try {
                StreamReader sr = new StreamReader(filenev);
                string sor = sr.ReadLine();
                while (!sr.EndOfStream) {
                    if (sor != "") {
                        string nev = sor;
                        string darabSzam = sr.ReadLine();
                        int sorDb = int.Parse(darabSzam.Split(';')[0]);
                        int helyDb = int.Parse(darabSzam.Split(';')[1]);
                        int[,] ertekeles = new int[sorDb, helyDb];
                        for (int s = 0; s < sorDb; s++) {
                            string gepSor = sr.ReadLine();
                            string[] helyek = gepSor.Split(';');
                            for (int h = 0; h < helyek.Length; h++) {
                                ertekeles[s, h] = int.Parse(helyek[h]);
                            }
                        }
                        geptermek.Add(new Gepterem(nev, sorDb, helyDb, ertekeles));
                    }
                    sor = sr.ReadLine();
                }
                sr.Close();
            } catch(Exception e) {
                MessageBox.Show("Hiba történt a fájl beolvasása során.");
                Environment.Exit(0);
            }
        }
        public void Mentes(string filenev) {
            int dotI = filenev.LastIndexOf('.');
            string bak = "";
            if (dotI > -1) {
                bak = filenev.Substring(0, dotI) + ".bak";
            } else {
                bak = filenev + ".bak";
            }
            if (File.Exists(filenev)) {
                File.Copy(filenev, bak, true);
            }
            try {
                StreamWriter sw = new StreamWriter(filenev);
                foreach(Gepterem gepterem in geptermek) {
                    sw.WriteLine(gepterem.Nev);
                    sw.WriteLine(gepterem.SorDb+";"+ gepterem.HelyDb);
                    for(int s = 0; s < gepterem.SorDb; s++) {
                        string[] ertekelesek = new string[gepterem.HelyDb];
                        for (int h = 0; h < gepterem.HelyDb; h++) {
                            ertekelesek[h] = gepterem.Ertekeles[s, h]+"";
                        }
                        sw.WriteLine(String.Join<string>(";", ertekelesek));
                    }
                    sw.WriteLine();
                }
                sw.Close();
                MessageBox.Show("Sikeres mentés");
            } catch (Exception e) {
                MessageBox.Show("Sikertelen mentés");
            }
        }
    }
}
