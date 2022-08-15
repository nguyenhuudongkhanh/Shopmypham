﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanHangOnline.Models
{
    public partial class News
    {
        public int PostId { get; set; }
        public string Tiltle { get; set; }
        public string Scontents { get; set; }
        public string Contents { get; set; }
        public string Thumb { get; set; }
        public bool? Published { get; set; }
        public string Alias { get; set; }
        public DateTime? CreteDate { get; set; }
        public string Author { get; set; }
        public int? AccountId { get; set; }
        public string Tags { get; set; }
        public int? CatId { get; set; }
        public bool? IsHot { get; set; }
        public bool? IsNewfedd { get; set; }
        public string MetaKey { get; set; }
        public string MetaDesc { get; set; }
        public int? Views { get; set; }

        public virtual Account Account { get; set; }
        public virtual Category Cat { get; set; }
    }
}
