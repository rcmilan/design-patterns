using Domain.Models;
using Memento.Interfaces;
using Memento.Originators;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Memento.Caretakers
{
    public class Caretaker
    {
        private List<IMemento<Person, int>> _mementos = new();
        private readonly PersonOriginator _originator = null;

        public Caretaker(PersonOriginator originator)
        {
            this._originator = originator;
        }

        public void Backup()
        {
            _mementos.Add(_originator.Save());
        }

        public Person Undo()
        {
            if (_mementos.Count > 0)
            {
                var memento = _mementos.Last();
                _mementos.Remove(memento);

                try
                {
                    return _originator.Restore(memento);
                }
                catch (Exception)
                {
                    Undo();
                }
            }

            return null;
        }

        public List<string> GetHistory()
        {
            var result = new List<string>();

            foreach (var memento in this._mementos)
            {
                result.Add(memento.GetDescription());
            }

            return result;
        }
    }
}


/* It's just a burnin' memory... */