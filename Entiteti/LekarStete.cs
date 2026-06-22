using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiguranje.Entiteti
{
    public class LekarStete
    {
        public virtual LekarSteteId Id { get; set; }

        public LekarStete()
        {
            Id = new LekarSteteId();
        }
    }
}
