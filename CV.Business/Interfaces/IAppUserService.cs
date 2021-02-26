namespace CV.Business.Interfaces
{
    public interface IAppUserService
    {
        public bool Authenticate(string userName, string password);
    }
}