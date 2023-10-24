using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseMaster.Models
{
    public class TotalInfo : ObservableObject
    {
        public int TotalSpent { get; set; }

        public int SavedMoney { get; set; }

    }
}
