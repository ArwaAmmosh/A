using System;
namespace ObjectOriented;
public  class person{
    public string Name;
    public int Age;
    public person (string name, int age){
        Name =name;
        Age =age;
    }
   public virtual void print(){
    Console.WriteLine($"My name is {Name},my age is {Age}");
   }
    
}
public class Student :person {
    public int Year;
    public float Gpa;
    public Student (string name,int age ,int year,float gpa) :base(name,age){
        Year =year;
        Gpa=gpa;
    }
    public override void print(){
        Console.WriteLine($"My name is {Name},my age is {Age},and gpa is {Gpa}");
            }

}
public class Staff :person {
    public double Salary;
    public int Joinyear;
    public Staff (string name,int age ,double salary,int joinyear) :base(name,age){
        Salary=salary;
        Joinyear=joinyear;
    }
    public override void print(){
        Console.WriteLine($"My name is {Name},my age is {Age},and salary is {Salary}");
            }

}
public class Database{
    private int index;
    public person[] people=new person[50];
    public void addstudent(Student student){
       people[index]=student;
         index++;
    } 
     public void addstaff(Staff staff){
       people[index]=staff;
         index++;
    } 
     public void addperson(person per){
       people[index]=per;
         index++;
    } 
    
    public  void print(){
        for(int i=0;i<=index;i++){

           people[i].print();
        }
    }  
   
}
public class program {
    public static void Main (){
        Database data=new Database();
        while (true)
        {Console.WriteLine("Enter \n1 to add a student\n2 to add a staff \n3 to add person\n4 to print out all people stored");
        var n=Convert.ToInt32(Console.ReadLine());
        if(n==1)
        {   Console.WriteLine("Name :");
            var name=Console.ReadLine();
            Console.WriteLine("Age :");
            var age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Year :");
            var year=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gpa :");
            var gpa=Convert.ToSingle(Console.ReadLine());
            var student=new Student(name,age,year,gpa);
            data.addstudent(student);
            Console.WriteLine("Stored successfully");

        }
        else if(n==2)
        {   Console.WriteLine("Name :");
            var name=Console.ReadLine();
            Console.WriteLine("Age :");
            var age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Salary :");
            var salary=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Join Year :");
            var joinyear=Convert.ToInt32(Console.ReadLine());
            var staff=new Staff(name,age,salary,joinyear);
            data.addstaff(staff);
           Console.WriteLine("Stored successfully");


        } 
        else if(n==3){
            Console.WriteLine("Name :");
            var name=Console.ReadLine();
            Console.WriteLine("Age :");
            var age=Convert.ToInt32(Console.ReadLine());
            var per=new person(name,age);
             data.addperson(per);
           Console.WriteLine("Stored successfully");


        }
         else if (n==4){
         data.print();
    
         }}
       
    }
    }
    }
    }
