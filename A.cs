using System;
namespace oops;
public abstract class person{
public string Name;
public int Age;
public person (string name,int age)
{
Name=name;
Age=age;
}
public class student: person { public int Year;
public float Gpa;
public override void print (){
Console.WriteLine("My name is {Name}, my age is {Age},and Gpa is{Gpa}");

}
Public class database {
Public int index;
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
}
}
