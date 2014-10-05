namespace mvc_partial_areas.Widgets
{
    public class WidgetTwo : IWidget
    {
        public string Name
        {
            get { return "Two"; }
        }

        public bool HasJavaScript
        {
            get { return true; }
        }

        public string ViewName
        {
            get { return "Two"; }
        }
    }
}