using System.Collections.ObjectModel;
using ProtoBase.Wpf;

namespace TreeViewExample.ViewModels
{
    public class TreeViewItemViewModel : ViewModelBase
    {
        #region Properties

        public string Name { get; set; }

        public ObservableCollection<TreeViewItemViewModel> Children { get; set; }

        #endregion
    }
}
