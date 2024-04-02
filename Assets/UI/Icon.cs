#if UNITY_5_3_OR_NEWER
#define NOESIS
using Noesis;
#else
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
#endif

namespace Testing
{
    public class Icon: Control
    {
        static Icon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Icon), new FrameworkPropertyMetadata(typeof(Icon)));
        }

        public static readonly DependencyProperty SymbolProperty = DependencyProperty.Register(
                nameof(Symbol),
                typeof(IconType),
                typeof(Icon),
                new PropertyMetadata(IconType.Empty));

        public IconType Symbol
        {
            get => (IconType)GetValue(SymbolProperty);
            set => SetValue(SymbolProperty, value);
        }

        public static readonly DependencyProperty ColorProperty = DependencyProperty.Register(
            nameof(Color),
            typeof(SolidColorBrush),
            typeof(Icon),
            new PropertyMetadata(new SolidColorBrush(Colors.Black)));

        public SolidColorBrush Color
        {
            get => (SolidColorBrush)GetValue(ColorProperty);
            set => SetValue(ColorProperty, value);
        }

    }

    public enum IconType
    {
        Empty,
        DashBoard,
        Book,
        Resource,
        Brain,
        BookOpen,
        Medal,
        Setting,
        Bug,
        LogOut,
        Mic,
        Bell,
        MagnifyingGlass,
        Audio
    }
}
