using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class LekarSteteId
    {
        public virtual Steta Steta { get; set; }
        public virtual AngazovanaOsoba Lekar { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(LekarSteteId))
                return false;

            LekarSteteId receivedObject = (LekarSteteId)obj;

            if ((Steta.Id == receivedObject.Steta.Id) &&
                (Lekar.Id == receivedObject.Lekar.Id))
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
