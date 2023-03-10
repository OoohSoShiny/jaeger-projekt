using GalaSoft.MvvmLight;
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
    public class Logic_Kalender: ViewModelBase, INotifyPropertyChanged
    {
        private ICommand _btn_TerminHinzufuegen;
        public ICommand Btn_TerminHinzufuegen
        {
            get
            {
                if (_btn_TerminHinzufuegen == null)
                {
                    _btn_TerminHinzufuegen = new RelayCommand(() =>
                    {
                        Logic_Kalender logic = new Logic_Kalender();
                    });
                }
                return _btn_TerminHinzufuegen;
            }
        
        }
        private ICommand _dg_TermineKalender;
        public ICommand Dg_TermineKalender
        {
            get
            {
                if (_dg_TermineKalender == null)
                {
                    _dg_TermineKalender = new RelayCommand(() =>
                    {
                        Logic_Kalender logic = new Logic_Kalender();
                    });
                }
                return _dg_TermineKalender;
            }
        }
        private ICommand _dg_KalenderAnzeige;
        public ICommand Dg_KalenderAnzeige
        {
            get
            {
                if (_dg_KalenderAnzeige == null)
                {
                    _dg_KalenderAnzeige = new RelayCommand(() =>
                    {
                        Logic_Kalender logic = new Logic_Kalender();
                    });
                }
                return _dg_KalenderAnzeige;
            }
        }

    }
}
