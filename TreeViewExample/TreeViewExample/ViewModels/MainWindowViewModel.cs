using System.Collections.ObjectModel;
using ProtoBase.Wpf;

namespace TreeViewExample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
    public ObservableCollection<TreeViewItemViewModel> Systems { get; } = new ObservableCollection<TreeViewItemViewModel>
    {
        new SystemTreeViewItemViewModel
        {
            Name= "System 1",
            Children = new ObservableCollection<TreeViewItemViewModel>
            {
                new TreeViewItemViewModel { Name = "SystemDetail1" },
                new TreeViewItemViewModel { Name = "SystemDetail1" },
                new TreeViewItemViewModel
                {
                    Name = "Windings",
                    Children = new ObservableCollection<TreeViewItemViewModel>
                    {
                        new WindingTreeViewItemViewModel
                        {
                            Name = "Winding A",
                            Children = new ObservableCollection<TreeViewItemViewModel>
                            {
                                new TreeViewItemViewModel { Name = "Detail1" },
                                new TreeViewItemViewModel { Name = "Detail2" },
                            }
                        },
                        new WindingTreeViewItemViewModel
                        {
                            Name = "Winding A",
                            Children = new ObservableCollection<TreeViewItemViewModel>
                            {
                                new TreeViewItemViewModel { Name = "Detail1" },
                                new TreeViewItemViewModel { Name = "Detail2" },
                            }
                        }
                    }
                }
            }
        },
        new SystemTreeViewItemViewModel
        {
            Name= "System 2"
        }
    };
    }
}
