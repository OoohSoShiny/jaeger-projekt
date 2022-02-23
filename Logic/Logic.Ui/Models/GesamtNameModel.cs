﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaegerMeister.MvvmSample.Logic.Ui.Models
{
    //Die Klasse fuer den Bau des Namens in der Abschussliste
    public class GesamtNameModel
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }

        public GesamtNameModel(string gegebenerVorname, string gegebenerNachname)
        {
            Vorname = gegebenerVorname;
            Nachname = gegebenerNachname;
        }        
    }
}