using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_05_23_Kutyak_programozasi_feladat
{
    internal class Kutya
    {
        int id;
        int fajta_id;
        int nev_id;
        int eletkor;
        DateTime utolso_ellenorzes;

        public Kutya(int id, int fajta_id, int nev_id, int eletkor, DateTime utolso_ellenorzes)
        {
            this.id = id;
            this.fajta_id = fajta_id;
            this.nev_id = nev_id;
            this.eletkor = eletkor;
            this.utolso_ellenorzes = utolso_ellenorzes;
        }

        public int Id { get => id; set => id = value; }
        public int Fajta_id { get => fajta_id; set => fajta_id = value; }
        public int Nev_id { get => nev_id; set => nev_id = value; }
        public int Eletkor { get => eletkor; set => eletkor = value; }
        public DateTime Utolso_ellenorzes { get => utolso_ellenorzes; set => utolso_ellenorzes = value; }
    }
}
