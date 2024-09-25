using GameLibraryRemastered.Controller.Model;

namespace GameLibraryRemastered.Wrapper.Model
{
    public class WrapperBase : IControllerWrapper
    {
        public IController Controller => controller;
        protected IController controller;

        internal WrapperBase(IController _controller)
        {
            controller = _controller;
        }
    }
}