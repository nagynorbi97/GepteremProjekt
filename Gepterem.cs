namespace GepteremProjekt {
    class Gepterem {
        private int[,] ertekeles;
        private int helyDb;
        private string nev;
        private int sorDb;
        public int[,] Ertekeles { get => ertekeles; }
        public int HelyDb { get => helyDb; }
        public string Nev { get => nev; }
        public int SorDb { get => sorDb; }
        public Gepterem(string nev, int sorDb, int helyDb, int[,] ertekeles) {
            this.nev = nev;
            this.sorDb = sorDb;
            this.helyDb = helyDb;
            this.ertekeles = ertekeles;
        }
        public double Atlag() {
            int osszeg = 0;
            int db = 0;
            for (int s = 0; s < sorDb; s++) {
                for (int h = 0; h < helyDb; h++) {
                    if (ertekeles[s, h] > 0) {
                        osszeg += ertekeles[s, h];
                        db++;
                    }
                }
            }
            return osszeg * 1.0 / db;
        }
    }
}
