namespace KMorcinek.YetAnotherTodo
{
    using Nancy;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters =>
            {
                var text = new Model().GetData();
                return View["index", text];
            };
        }
    }
}