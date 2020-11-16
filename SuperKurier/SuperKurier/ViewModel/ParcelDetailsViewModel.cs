﻿using Caliburn.Micro;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperKurier.ViewModel
{
    public class ParcelDetailsViewModel : ParcelAddViewModel
    {
        public Parcel Parcel { get; set; }

        public ParcelDetailsViewModel(Parcel parcel)
        {
            Parcel = parcel;
        }
    }
}
