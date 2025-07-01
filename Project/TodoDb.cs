using Microsoft.EntityFrameworkCore;

class TodoDb : DbContext
{

  // :base(options) is used to call the contructor of the base class and passing the options to it
  public TodoDb(DbContextOptions<TodoDb> options) : base(options)
  {
  }


  // It means:

  // 👉 “I am declaring a public property called Todos
  // that is of type DbSet<Todo>
  // and whenever you access it, it will run the method Set<Todo>() and return the result.”

  // ✅ So this is not a variable (like int x = 5;),
  // and it’s not a normal field.
  // It’s a computed property.
  // Set<T>() is a method you inherit from DbContext.
  public DbSet<Todo> Todos => Set<Todo>();

 public string[] sampleString = { "hello", "yellow" }; 
  public string[] Samples => sampleString;
}