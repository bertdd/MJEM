using MJEM;

Console.WriteLine("Het winkelen begint");

var students = new[] 
{ 
  new Student("Ensar"),
  new Student("Julie")
  {
    HasCard = true,
  },
  new Student("Mustafa")
  {
    HasCard = true,
  },
  new Student("Zakaria"),
  new Student("Lenny")
};

var breadList = new Bread[]
{
  new HealthyBread("Volkoren"),
  new UnhealthyBread("Chocolade broodje"),
  new UnhealthyBread("Croissant"),
  new UnhealthyBread("Koffiebroodje") { Price = 2.0M},
  new HealthyBread("Broodje kaas")
};

var bag = new Bag();
bag.Add(breadList[2]);

void PrintStudents()
{
  foreach (var student in students)
  {
    Console.WriteLine($"{student.Name}, {student.HasCard}, {student.Points}");
  }
}

PrintStudents();
