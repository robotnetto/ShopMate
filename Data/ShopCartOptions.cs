using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMate.Data
{
    public enum Options
    {
        [Description("Setting")]
        Setting,

        [Description("New Recipe")]
        New,

        [Description("Edit")]
        Edit


    }
    public enum ObjectType
    {
        Recipe,
        CartList,
        Items
    }
}
