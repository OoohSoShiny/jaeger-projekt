﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JaegerMeister.MvvmSample.Logic.Ui
{
    public class Logic_Registrierung : ViewModelBase, INotifyPropertyChanged
    {
        private ICommand _btn_abbrechen;

        public ICommand Btn_abbrechen
        {
            get
            {
                if (_btn_abbrechen == null)
                {
                    _btn_abbrechen = new RelayCommand(() =>
                    {

                        Logic_Registrierung logic = new Logic_Registrierung();

                    });
                }
                return _btn_abbrechen;
            }
        }
        private ICommand _btn_bestaetigen;

        public ICommand Btn_bestaetigen
        {
            get
            {
                if (_btn_bestaetigen == null)
                {
                    _btn_bestaetigen = new RelayCommand(() =>
                    {

                        Logic_Registrierung logic = new Logic_Registrierung();

                    });
                }
                return _btn_bestaetigen;
            }
        }

        private string _tb_vorname;

        public string Tb_vorname
        {
            get
            {
                return _tb_vorname;
            }
            set
            {
                //Datenbankbindung benötigt
            }
        }

        private string _tb_nachname;

        public string Tb_nachname
        {
            get
            {
                return _tb_nachname;
            }
            set
            {
                //Datenbankbindung benötigt
            }
        }

        private string _tb_benutzername;

        public string Tb_benutzername
        {
            get
            {
                return _tb_benutzername;
            }
            set
            {
                //Datenbankbindung benötigt
            }
        }

        private string _tb_passwort;

        public string Tb_passwort
        {
            get
            {
                return _tb_passwort;
            }
            set
            {
                //Datenbankbindung benötigt
            }
        }

        private string _tb_sicherheitsfrage_antwort;

        public string Tb_sicherheitsfrage_antwort
        {
            get
            {
                return _tb_sicherheitsfrage_antwort;
            }
            set
            {
                //Datenbankbindung benötigt
            }
        }

        private string _cb_sicherheitsfrage;

        public string Cb_sicherheitsfrage
        {
            get
            {
                return _cb_sicherheitsfrage;
            }
            set
            {
                //Datenbankbindung benötigt
            }
        }
    }
}