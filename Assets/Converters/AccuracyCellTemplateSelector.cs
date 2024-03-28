#if UNITY_5_3_OR_NEWER
#define NOESIS
#endif

#if NOESIS
using Noesis;
#else
using System.Windows;
using System.Windows.Controls;
#endif
namespace Testing
{
    public class AccuracyCellTemplateSelector: DataTemplateSelector
    {
        public DataTemplate HighTemplate { get; set; }
        public DataTemplate MediumTemplate { get; set; }
        public DataTemplate LowTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is PracticeData data)
            {
                if (data.Accuracy <= 20)
                    return LowTemplate;
                if (data.Accuracy <= 50)
                    return MediumTemplate;

                return HighTemplate;
            }

            return null;
        }
    }
}
