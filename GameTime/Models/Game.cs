using System;


  namespace GameTime.Models
    {
        public class Game
        {
            #region Game Variables
            private string jeuxNom;
            private string jeuxDescription;
            private string jeuxImage;
            private string jeuxDate;
            private string jeuxGenre;
            private string jeuxPEGI;
            private string jeuxPlatforme;
            private string jeuxVersion;

            #endregion

            #region Game Properties

            public string JeuxNom
            {
                get { return jeuxNom; }
                set
                {
                    if (jeuxNom != value)
                    {
                        jeuxNom = value;
                    }
                }
            }

            public string JeuxDescription
            {
                get { return jeuxDescription; }
                set
                {
                    if (jeuxDescription != value)
                    {
                        jeuxDescription = value;
                    }
                }
            }

            public string JeuxImage
            {
                get { return jeuxImage; }
                set
                {
                    if (jeuxImage != value)
                    {
                        jeuxImage = value;
                    }
                }
            }

            public string JeuxDate
            {
                get { return jeuxDate; }
                set
                {
                    if (jeuxDate != value)
                    {
                        jeuxDate = value;
                    }
                }
            }

            public string JeuxGenre
            {
                get { return jeuxGenre; }
                set
                {
                    if (jeuxGenre != value)
                    {
                        jeuxGenre = value;
                    }
                }
            }

            public string JeuxPEGI
            {
                get { return jeuxPEGI; }
                set
                {
                    if (jeuxPEGI != value)
                    {
                        jeuxPEGI = value;
                    }
                }
            }

            public string JeuxPlatforme
            {
                get { return jeuxPlatforme; }
                set
                {
                    if (jeuxPlatforme != value)
                    {
                        jeuxPlatforme = value;
                    }
                }
            }

            public string JeuxVersion
            {
                get { return jeuxVersion; }
                set
                {
                    if (jeuxVersion != value)
                    {
                        jeuxVersion = value;
                    }
                }
            }
            #endregion

            #region Game Constructor
 
            public Game(string jeuxNom, string jeuxDescription, string jeuxImage, string jeuxGenre, string jeuxDate, string jeuxPEGI, string jeuxPlatforme, string jeuxVersion)
            {
                this.jeuxNom = jeuxNom;
                this.jeuxDescription = jeuxDescription;
                this.jeuxImage = jeuxImage;
                this.jeuxDate = jeuxDate;
                this.jeuxGenre = jeuxGenre;
                this.jeuxPEGI = jeuxPEGI;
                this.jeuxPlatforme = jeuxPlatforme;
                this.jeuxVersion = jeuxVersion;
            }

            public Game()
            {

            }
            #endregion
        }
    }
