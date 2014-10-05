namespace mvc_partial_areas.Widgets
{
    public class WidgetOne : IWidget
    {
        public string Name
        {
            get { return "One"; }
        }

        public bool HasJavaScript
        {
            get { return true; }
        }

        public string ViewName
        {
            get { return "One"; }
        }
    }
}