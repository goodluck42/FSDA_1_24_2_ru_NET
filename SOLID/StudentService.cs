namespace SOLID;

public class StudentService : IStudentService
{
	private readonly List<Student> _students = new ();
	private readonly ILogger _logger;
	
	// Composition
	public StudentService()
	{
		_logger = new FileLogger();
	}
	
	// Aggregation && Barbara Liskov principle
	public StudentService(ILogger logger)
	{
		_logger = logger;
	}
	
	public void Add(Student student)
	{
		_students.Add(student);
		
		_logger.Log($"Student added: {student.Id}");
	}

	public bool RemoveById(int studentId)
	{
		var target = _students.FirstOrDefault(s => s.Id == studentId);

		return target is not null && _students.Remove(target);
	}

	public Student GetById(int studentId)
	{
		return _students.First(s => s.Id == studentId);
	}

	public IEnumerable<Student> GetAll()
	{
		return _students;
	}
}