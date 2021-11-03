using MusicViewer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace MusicViewer.ViewModels
{
    public class HistoryViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<History> Histories { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        /**
         * Constructeur qui instancie la liste 
         * **/
        public HistoryViewModel()
        {
            Histories = new ObservableCollection<History>();
        }

        /**
         * Récupére l'historique de jeux en fonction de l'utilisateur
         * **/
        public List<History> getHistories(User user)
        {
            List<History> myTest = new List<History>();
            foreach (History history in Histories)
            {
                if (user.ProfilsPseudo == history.User.ProfilsPseudo)
                {
                    myTest.Add(history);
                }
            }
            return myTest;
        }

        /**
         * Ajoute un jeux avec son user et son jeu
         * **/
        public void AddGame(User user, Game game)
        {
            Histories.Add(new History
            {
                User = user,
                Game = game,
                EtatJeu = EtatJeu.JeuxEnAttente
            });
        }

        /**
         * Set JeuxEnCours le jeu
         * **/
        public void SetJeuxEnCours(History history)
        {
            int i = Histories.IndexOf(history);
            Histories[i].EtatJeu = EtatJeu.JeuxEnCours;
        }

        /**
         * Set JeuxTermine le jeu
         * **/
        public void SetJeuxTermine(History history)
        {
            int i = Histories.IndexOf(history);
            Histories[i].EtatJeu = EtatJeu.JeuxTermine;
        }

        /**
         * Set JeuxEnAttente le jeu
         * **/
        public void SetJeuxEnAttente(History history)
        {
            int i = Histories.IndexOf(history);
            Histories[i].EtatJeu = EtatJeu.JeuxEnAttente;
        }

        /**
         * Update les jeux lier à l'utilisateur quand une modification arrive
         * **/
        public void UpdateGameAll(Game SelectedGame, Game UpdatedGame)
        {
            int i = 0;
            foreach (History history in Histories)
            {
                if (history.Game.JeuxNom == SelectedGame.JeuxNom)
                {
                    Histories[i].Game = UpdatedGame;
                }
                i++;
            }
        }


    }

}