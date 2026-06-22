using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class ProcenaId
    {
        public virtual Steta Steta { get; set; }
        public virtual AngazovanaOsoba AngazovanaOsoba { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(ProcenaId))
                return false;

            ProcenaId receivedObject = (ProcenaId)obj;

            if ((Steta.Id == receivedObject.Steta.Id) &&
                (AngazovanaOsoba.Id == receivedObject.AngazovanaOsoba.Id))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
