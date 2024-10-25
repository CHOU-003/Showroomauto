using ShowroomAUTO.Model;


namespace ShowroomAUTO.Controller
{
    internal interface IController
    {
        List<IModel> Items { get; }
        public bool Create(IModel model);
        public bool Update(IModel model);
        public bool Delete(IModel id);
        public IModel Read(Object id);
        public bool Load();
        public bool Load(Object id);
        public bool IsExist(Object model);
    }
}
