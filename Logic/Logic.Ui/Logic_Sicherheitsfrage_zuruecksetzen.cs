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
    public class Logic_Sicherheitsfrage_zuruecksetzen : ViewModelBase, INotifyPropertyChanged
    {
        private ICommand _btn_bestaetigen;

        public ICommand Btn_bestaetigen
        {
            get
            {
                if(_btn_bestaetigen==null)
                {
                    _btn_bestaetigen = new RelayCommand(() =>
                    {
                        Logic_Sicherheitsfrage_zuruecksetzen logic = new Logic_Sicherheitsfrage_zuruecksetzen();
                    });
                }
                return _btn_bestaetigen;
            }
        }
        private ICommand _btn_abbrechen;

        public ICommand Btn_abbrechen
        {
            get
            {
                if (_btn_abbrechen == null)
                {
                    _btn_abbrechen = new RelayCommand(() =>
                    {
                        Logic_Sicherheitsfrage_zuruecksetzen logic = new Logic_Sicherheitsfrage_zuruecksetzen();
                    });
                }
                return _btn_abbrechen;
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
                _cb_sicherheitsfrage = value;
                RaisePropertyChanged("");
            }
        }

        private string _tb_antwort;

        public string Tb_antwort
        {
            get
            {
                return _tb_antwort;
            }
            set
            {
                _tb_antwort = value;
                RaisePropertyChanged("");
            }
        }
    }
}