namespace SOLID;

public interface IStudentService
{
	void Add(Student student);
	// void Remove(Student student);
	bool RemoveById(int studentId);
	Student GetById(int studentId);
	//void Update(int studentId, Student student);
	IEnumerable<Student> GetAll();
}