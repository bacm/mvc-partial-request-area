namespace mvc_partial_areas.Widgets
{
    internal class WidgetNull : IWidget
    {
        public string Name
        {
            get { return "Null"; }
        }

        public bool HasJavaScript
        {
            get { return false; }
        }

        public string ViewName
        {
            get { return "Null"; }
        }
    }
}