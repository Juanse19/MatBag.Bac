using System;
using System.Collections.Generic;

namespace IoT.Entities.Models
{
    public partial class Settings
    {
        public int Id { get; set; }
        public string ThemeName { get; set; }

        public virtual Users IdNavigation { get; set; }
    }
}
