using exercises_7;

Person person = new Person("tsds", 25);
Person person1 = new Person();
Console.WriteLine(person.Name + person.Age);
Console.WriteLine(person1.Name + person1.Age);

BankAccount bankAccount = new BankAccount("GEL", "GB", 34463220252525M);
Console.WriteLine(bankAccount.Iban);
Console.WriteLine(bankAccount.Currency);
Console.WriteLine(bankAccount.Amount);

Student student = new Student("nukri", "tsaava", 5.0);
Console.WriteLine($"{student.Name} {student.LastName} {student.GPA}");

