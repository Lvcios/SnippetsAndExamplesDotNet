﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarateTrainingObserverExample
{
    public interface ISubject
    {
        void Register(IObserver o);
        void Remove(IObserver o);
        void Notify();
    }
}
