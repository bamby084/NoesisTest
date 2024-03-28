#if UNITY_5_3_OR_NEWER
    #define NOESIS
    using Noesis;
using System.Reflection;
#else
    using System.Windows;
    using System.Windows.Controls;
#endif

namespace Testing
{
#if NOESIS
    public partial class DashBoard: Noesis.UserControl
#else
    public partial class DashBoard: UserControl
#endif
    {
        public DashBoard()
        {
            InitializeComponent();
            this.DataContext = new DashBoardViewModel();
        }

#if NOESIS
      
        private void InitializeComponent()
        {
            NoesisUnity.LoadComponent(this);
        }
#endif

    };
}