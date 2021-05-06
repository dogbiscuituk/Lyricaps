namespace Lyricaps.Controllers
{
    internal abstract class Controller
    {
        protected Controller(Controller parent)
        {
            InitControllers(parent);
            InitEvents();
        }

        protected Controller Parent;

        protected virtual void InitControllers(Controller parent) => Parent = parent;

        protected virtual void InitEvents() { }
    }
}
