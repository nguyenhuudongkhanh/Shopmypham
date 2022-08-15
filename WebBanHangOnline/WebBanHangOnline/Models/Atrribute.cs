using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanHangOnline.Models
{
    public partial class Atrribute
    {
        public Atrribute()
        {
            AtrributesPrices = new HashSet<AtrributesPrice>();
        }

        public int AtrributeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AtrributesPrice> AtrributesPrices { get; set; }
    }
}
