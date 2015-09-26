using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Data.Interfaces;

namespace Avicola.Office.Entities
{
    public partial class Standard : IEntity
    {
        public static readonly Guid FoodEntry = new Guid("1927EBF5-4E6F-479F-AE4B-6D2C8152167A");
        public static readonly Guid FoodConsumed = new Guid("42F12739-8F64-4E20-B08A-750B0D9B9E96");
        public static readonly Guid Death = new Guid("F814F03C-2655-4305-9D23-37E742ABF640");
        public static readonly Guid Remove = new Guid("E8FE57EB-F05B-48AE-92B7-EB39F5807589");
        public static readonly Guid EggWeight = new Guid("A755ACAB-4A3C-45FF-B90C-6B851E16A713");
        public static readonly Guid BirdWeight = new Guid("86D41158-364A-4801-8975-05C9B1CEBD3C");
        public static readonly Guid Water = new Guid("41C1FFEE-DE06-4FE4-9DE9-20423822CAC6");
        
    }
}
