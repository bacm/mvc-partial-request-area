namespace mvc_partial_areas.Widgets
{
    public interface IWidget
    {
        string Name { get; }

        bool HasJavaScript { get; }

        string ViewName { get; }
    }
}