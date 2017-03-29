using MVVMExcercise.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Controls;
using System.Windows;

namespace MVVMExcercise.ViewModels
{
    public class FilterItemsViewModel : ObservableCollection
    {
        
        public DelegateCommand FilterBtn { get; private set; }
        public DataTable DataGrid { get; private set; }

        public FilterItemsViewModel()
        {
            FilterBtn = new DelegateCommand(FilterGrid);
        }

        private void FilterGrid(object message)
        {
            MessageBox.Show("Debug:Update Gridview here");
        }

        
    }
}
