// SOLID
// 

//// Single responsibility principle
//// Violation

// interface IUserManager
// {
// 	void AddUser(User user);
// 	void RemoveUser(User user);
// 	void AddDrandulet(Drandulet drandulet);
// 	
// 	bool IsUserValid();
//
// 	void PrintUsers();
// }
//
//
// class Drandulet;
// class User;


//// Workaround

// interface IUserManager
// {
// 	void AddUser(User user);
// 	void RemoveUser(User user);
// }
//
// interface IUserValidator
// {
// 	bool Validate(User user);
// }
//
// interface IPrintable<T>
// {
// 	void Print(IEnumerable<T> collection);
// }
//
// class User;

//// Open close principle
//// Violation

// interface IUserManager
// {
// 	void AddUser(User user);
// 	User GetUser();
// }
//
// class UserManager : IUserManager
// {
// 	public List<User> _users = new List<User>() { new User() };
// 	
// 	public void AddUser(User user)
// 	{
// 		// Adding user...
// 	}
//
// 	public User GetUser()
// 	{
// 		return _users.First();
// 	}
//
// 	public List<User> GetAll()
// 	{
// 		return [];
// 	}
// }
//
// class User;

//// Workaround
//
// interface IUserManager
// {
// 	void AddUser(User user);
// 	User GetUser();
// }
//
// class UserManager : IUserManager
// {
// 	private List<User> _users = new List<User>() { new User() };
// 	
// 	public void AddUser(User user)
// 	{
// 		// Adding user...
// 	}
//
// 	public User GetUser()
// 	{
// 		return _users.First();
// 	}
// }
//
// class User;


//// Barbara Liskov principle

// using SOLID;
//
// var studentService = new StudentService(new FileLogger());
//
// var garage = new Garage();
//
// garage.Add(new Drandulet());

//Vehicle vehicle = new Drandulet();

// abstract class Vehicle
// {
// 	public int Speed { get; set; }
// 	public string Model { get; set; }
// 	
// 	public abstract void Drive();
// }
//
//
// class Motorcycle : Vehicle
// {
// 	public override void Drive()
// 	{
// 		Console.WriteLine("Motorcycle::Drive");
// 	}
// }
//
// class Drandulet : Vehicle
// {
// 	public override void Drive()
// 	{
// 		Console.WriteLine("Drandulet::Drive");
// 	}
// }
//
// class Garage
// {
// 	public void Add(Vehicle vehicle)
// 	{
// 		
// 	}
// }

//// Interface segregation principle
//// Violation

// interface IValidationService
// {
// 	bool IsValid(User user);
// 	bool IsValid(Student student);
// 	bool IsValid(Teacher teacher);
// }
//
// class User;
//
// class Student;
//
// class Teacher;

//// Workaround

// class User;
// class Student;
// class Teacher;
//
// interface IUserValidator
// {
// 	bool IsValid(User user);
// }
//
// interface IStudentValidator
// {
// 	bool IsValid(Student student);
// }
//
// interface ITeacherValidator
// {
// 	bool IsValid(Teacher teacher);
// }

//// Dependency inversion principle
//// Violation

// interface IStudentService
// {
// 	void Add(Student student);
// 	bool RemoveById(int studentId);
// 	Student GetById(int studentId);
// 	List<Student> GetAll();
// }
//
// class Student;

//// Workaround
// interface IStudentService
// {
// 	void Add(Student student);
// 	bool RemoveById(int studentId);
// 	Student GetById(int studentId);
// 	IEnumerable<Student> GetAll();
// }
//
// class Student;


var user = new User();

Statics.Foo(user);
Statics.Bar(user);

interface IA
{
	
}

interface IB
{
	
}
class User : IA, IB;

class Statics
{
	public static void Foo(IA user) {}
	public static void Bar(IB user) {}
}