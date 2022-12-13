using System;
namespace oops;
public abstract class person{
public string Name;
public int Age;
public int Year;
public float Gpa;
public person (string name,int age,int Year,int gpa,)
{
Name=name;
Age=age;
Year=year;
Gpa=gpa;
}
public class student: person { 
public override void print (){
Console.WriteLine("My name is {Name}, my age is {Age},and Gpa is{Gpa}");

}
Public class database {
private int index;
public person[] people =new person[50];
public void add(Student student){
people [index]=student;
index++;
}
}


}
}
public class program {
public static void Main(){
var data=new database();
var name=Console.ReadLine();
var age =Convert.ToInt32(Console.ReadLine());
var year =Convert.ToInt32(Console.ReadLine());
var gpa=Convert.ToSingle(Console.ReadLine());
var student=new Student (name,age,year,Gpa);
data.add(student);
}
}
