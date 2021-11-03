using System;

namespace GameTime.Models
{

    public enum EtatJeu
    {
        JeuxEnAttente, // 0
        JeuxEnCours,   // 1
        JeuxTermine    // 2
    }

    public class History
    {
        public EtatJeu EtatJeu { get; set; }
        public User User { get; set; }
        public Game Game { get; set; }



        public History(EtatJeu etatJeu, User user, Game game)
        {
            EtatJeu = etatJeu;
            User = user;
            Game = game;
        }


        public History()
        {
        }


    }
}