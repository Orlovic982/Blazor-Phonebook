namespace BlazorProject1.ViewModels
{
    public interface IPersonEditModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string PersonId { get; set; }
        public void Save();
        public void Close();
    }
}