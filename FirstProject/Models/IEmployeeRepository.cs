namespace FirstProject.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
         void Save();

    }
}