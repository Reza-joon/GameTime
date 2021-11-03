
using System;

namespace GameTime.Models
{

    public class User
    {
        // User Variables
        private string profilsPseudo;
        private string profilsNom;
        private string profilsPrenom;
        private string profilsDateNaissance;
        private string profilsEmail;
        private string profilsMotPasse;



        // User Properties

        public string ProfilsPseudo
        {
            get { return profilsPseudo; }
            set
            {
                if (profilsPseudo != value)
                {
                    profilsPseudo = value;
                }
            }
        }

        public string ProfilsNom
        {
            get { return profilsNom; }
            set
            {
                if (profilsNom != value)
                {
                    profilsNom = value;
                }
            }
        }

        public string ProfilsPrenom
        {
            get { return profilsPrenom; }
            set
            {
                if (profilsPrenom != value)
                {
                    profilsPrenom = value;
                }
            }
        }

        public string ProfilsDateNaissance
        {
            get { return profilsDateNaissance; }
            set
            {
                if (profilsDateNaissance != value)
                {
                    profilsDateNaissance = value;
                }
            }
        }

        public string ProfilsEmail
        {
            get { return profilsEmail; }
            set
            {
                if (profilsEmail != value)
                {
                    profilsEmail = value;
                }
            }
        }

        public string ProfilsMotPasse
        {
            get { return profilsMotPasse; }
            set
            {
                if (profilsMotPasse != value)
                {
                    profilsMotPasse = value;
                }
            }
        }


        // User Constructor
        public User(string profilsPseudo, string profilsNom, string profilsPrenom, string profilsDateNaissance, string profilsEmail, string profilsMotPasse)
        {
            this.profilsPseudo = profilsPseudo;
            this.profilsNom = profilsNom;
            this.profilsPrenom = profilsPrenom;
            this.profilsDateNaissance = profilsDateNaissance;
            this.profilsEmail = profilsEmail;
            this.profilsMotPasse = profilsMotPasse;
        }

        public User()
        {
        }
    }
}
