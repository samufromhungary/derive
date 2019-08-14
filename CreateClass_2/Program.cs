using System;

namespace CreateClass_2
{
    class Program
    {
        public class Person
        {
            public string name;
            public DateTime birthDate;
            public enum Gender { Male, Female };
            public Gender gender;

            public Person(string name, DateTime birthDate, Gender gender)
            {
                this.name = name;
                this.birthDate = birthDate;
                this.gender = gender;
            }

            public override string ToString()
            {
                return "Name: " + name + " | Birth: " + birthDate + " | Gender: " + gender + " |";
            }
        }

        public class Room
        {
            public int roomNumber;

            public Room(int roomNumber)
            {
                this.roomNumber = roomNumber;
            }

            public override string ToString()
            {
                return roomNumber.ToString();
            }
        }

        public class Employee : Person
        {
            public int Salary;
            public string Profession;
            public Room Room;

            public Employee(string name, DateTime birthDate, Gender gender, int Salary, string Profession, Room room) : base(name, birthDate, gender)
            {
                this.Salary = Salary;
                this.Profession = Profession;
                Room = room;
            }

            public override string ToString()
            {
                return "Name: " + name + " | Birth: " + birthDate + " | Gender: " + gender + " | Salary: " + Salary + " | Profession: " + Profession + " | In Room: " + Room + " |";
            }
        }
        static void Main(string[] args)
        {
            Person person1 = new Employee("Yuri Tarded", new DateTime(1111, 1, 11), Person.Gender.Female, 1000, "Hr Assistant", new Room(1));
            Person person2 = new Employee("Moe Lester", new DateTime(2222, 2, 22), Person.Gender.Male, 500, "R1", new Room(2));

            Console.WriteLine(person1);
            Console.WriteLine(person2);
            Console.ReadKey(true);
        }
    }
}

