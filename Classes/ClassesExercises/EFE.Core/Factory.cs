namespace EFE.Core
{
    public class Factory<T> where T: class
    {
        public string User { get; set; }
        public string Password { get; set; }

        public Factory()
        {
            User = "sa";
            Password = "Control123*";
        }

        public Repository<T> Get()
        {
            return new Repository<T>(GetContext());
        }

        private AbstractContext GetContext()
        {
            return new BaseContext(User, Password);
        }
    }
}
