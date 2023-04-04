using ConsoleApp1.Models;
using ConsoleApp1.Services;
using System.Reflection;

#region Reflection
//Assembly assembly = Assembly.GetExecutingAssembly();
//Console.WriteLine(assembly);
//Type type = assembly.GetType("ConsoleApp1.Models.Student");
//Console.WriteLine(type);

//foreach (var prop in type.GetProperties())
//{
//    Console.WriteLine(prop.Name);
//}

//foreach (var method in type.GetMethods())
//{
//    Console.WriteLine(method.Name);
//}

//foreach (var item in type.GetFields())
//{
//    Console.WriteLine(item);
//}

//foreach (var type in assembly.GetTypes())
//{
//    Console.WriteLine(type);
//}

//var type = typeof(ConsoleApp1.Models.Student);
//Console.WriteLine(type);
//Student student = new Student();
//Console.WriteLine(student.GetType());

//Student student1 = new Student();
//student1.Name = "Asda";
//Console.WriteLine(student1.Name);

//var student = (Student)Activator.CreateInstance(typeof(Student));
//var type = student.GetType();

//var id = type.GetProperty("Id", BindingFlags.NonPublic | BindingFlags.Instance);
//id.SetValue(student, 1);
//Console.WriteLine(id.GetValue(student));
//student.Name = "Terlan";
//Console.WriteLine(student.Name);
#endregion

#region DI
//PaymentService paymentService = new PaymentService();
//paymentService.Payment(new PaypalPayment());
//paymentService.Payment(new CreditCardPayment());
#endregion