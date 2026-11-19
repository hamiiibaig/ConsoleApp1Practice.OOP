using ConsoleAppCSHARP.methods;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace ConsoleAppCSHARP.methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // OOP coding practice: class and object

            //Mobile m1 = new Mobile();

            //Console.WriteLine(m1.brand);
            //Console.WriteLine(m1.price);
            //Student s1 = new Student();
            //s1.name = "hamna";
            //Console.WriteLine(s1.name);
            //Student s1 = new Student();
            //Console.WriteLine(s1.name);
            //Console.WriteLine(s1.age);
            //mobile m1= new mobile();
            //m1.name = "iphone";
            //Console.WriteLine(m1.name);
            //Console.WriteLine(m1.price);
            //Mobile  m1 = new Mobile();
            //Console.WriteLine("enter the brand name");
            //m1.brand = (Console.ReadLine()!);
            //Console.WriteLine("enter the price");
            //m1.price = int.Parse(Console.ReadLine()!);
            //Console.WriteLine("enter the color");
            //m1.color=(Console.ReadLine()!);
            //Console.WriteLine("enter the size");
            //m1.size=(Console.ReadLine()!);
            //Console.WriteLine(" ");
            //Console.WriteLine(m1.brand);
            //Console.WriteLine(m1.price);
            //Console.WriteLine(m1.color);
            //Console.WriteLine(m1.size);
            //Car c1=new Car();
            //c1.ShowBrand();
            //c1.showprice();
            //Mobile m1 = new Mobile();
            //Console.WriteLine("enter brand name");
            //m1.brand = (Console.ReadLine()!);
            //Console.WriteLine("enter the price");

            //m1.price = int.Parse(Console.ReadLine()!);
            //Console.WriteLine(" ");
            //    Console.WriteLine(m1.brand);
            //Console.WriteLine(m1.price);
            //Car c1= new Car();
            //Console.WriteLine("enter brand name");
            //c1.brand = (Console.ReadLine()!);
            //Console.WriteLine("enter the price");
            //c1.price=int. Parse(Console.ReadLine()!);
            //Console.WriteLine(" ");
            //c1.ShowDetails();
            //Student s1=new Student ();
            //s1.ShowName();
            //student s1=new student();
            //s1.name = "malaika";
            //s1.ShowName();
            ////Car c1=new Car();
            ////c1.brand = "honda city";
            ////Car c2=new Car();
            ////c1.ShowBrand();
            ////c2.ShowBrand();
            /// practice
            //Car c1= new Car();
            //c1.brand = "honda city";
            //Car c2 = new Car();
            //c1.ShowDetails();
            //    c2.ShowDetails();
            //// practice of student input
            //Student s1 = new Student();
            //s1.name = "nabeeha";
            // s1.ShowName();
            //Student s1=new Student();
            //s1.name = ("hamna");
            //Console.WriteLine(s1.name);
            //student output
            //Student s1= new Student();
            //Console.WriteLine(s1.name);
            // car output
            //Car c1=new Car();
            //Console.WriteLine(c1.name);
            //// mobile code
            //Mobile m1 = new Mobile();
            //Mobile m2 = new Mobile();
            //Mobile m3= new Mobile();
            //m2.name = "vivo";
            //m3.name = "iphone";
            //Console.WriteLine(m1.name);
            //Console.WriteLine(m2.name);
            //Console.WriteLine(m3.name);
            // Student Constructor
            //Student s1= new Student();
            //Student s2= new Student();
            //s2.name = "maham";
            //Console.WriteLine(s1.name);
            //Console.WriteLine(s2.name);
            //PRIVATE CLASS
            //Mobile m1= new Mobile();
            //m1.ShowBrand();
            //PARAMETERS OF CONSTRUCTOR
            //Mobile m1 = new Mobile( "Sumsung" , "blue");
            //Mobile m2 = new Mobile( "vivo" ,   "white");
            //m1.ShowDetails();
            //m2.ShowDetails();
            // Private CLASS car
            //Car c1= new Car();
            //c1.ShowModel();
            // stUDENT PRIVATE CLASS
            //Student s1 = new Student();
            //s1.ShowName();
            // Employee PRIVATE CLASS
            //Employee e1 = new Employee();
            //e1.ShowName();
            // BOOK NAME CLASS
            //Book b1=new Book();
            //b1.ShowName();
            // animal CLASS
            //Animal a1= new Animal();
            //a1.ShowDetails();
            // 2 protected code

            //Dog d1 = new Dog();
            //d1.ShowName();
            // INTERNAL CODE
            //Employee e1 = new Employee();
            //e1.ShowSalary();
            //practice at home 
            //Employee e1=new Employee("hamna", 70000);
            //e1.ShowName();
            //Student class code Constructor
            //Student s1 = new Student("Hamna Ayaz", 600);
            //s1.ShowDetails();
            //SOUND CLASS PROTECTED
            //dog d1 = new dog();
            //d1.ShowSound();
            //CAT SOUND CLASS
            //Cat c1 = new Cat();
            //c1.ShowSound();
            //INTERNAL CLASS CODE
            //Company c1 = new Company();
            //c1.ShowSalary();
            //INTERNAL BANK CLASS CODE
            //Bank b1 = new Bank();
            //b1.ShowSalary();
            //internal school code
            //Student s1 = new Student();
            // s1.ShowDetails();
            //Combine class
            //Employee e1= new Employee();
            //e1.name = "Hamna";
            //Console.WriteLine("EmployeeName :" + e1.name);
            //e1.ShowSalary();
            //Manager m1 = new Manager();
            //m1.ShowDepartment();

            //Office O1 = new Office();
            //O1.ShowCompany();
            //Combine MOBILE CODE
            //Mobile m1 = new Mobile();
            //m1.model = "IPhone";
            //Console.WriteLine("Mobile model :" + m1.model);

            //m1.ShowPrice();

            //Phone p1 = new Phone();
            //p1.ShowBrand();

            //Shop s1 = new Shop();
            //s1.ShowShopName();
            // PROPERTIES CLASS CODE
            //Student s1 = new Student();
            //s1.name = "Hamna Baig";
            //s1.ShowName();
            //PROPERTIES of Mobile CLass
            //Mobile m1 = new Mobile();
            //m1.model = "Sumsung";
            //m1.price = 88000;
            //m1.color = "Blue";
            //m1.ram= 8;
            //m1.storage = 256;
            //m1.ShowDetails();
            // PRACTICE OF PROPERTIES
            //Student s1= new Student();
            //s1.Name = "Hamna Baig";
            //s1.marks = 90;
            //s1.ShowDetails();
            //PROPERTIES OF mobile practice
            //Mobile m1= new Mobile();
            //m1.brand = "iphone";
            //Console.WriteLine(m1.brand);
            //PROPERTIES OF CAR CLASS CODE
            //Car c1= new Car();
            //Console.WriteLine("Car Color :" + c1.Color);
            //c1.Color = "black";
            //Console.WriteLine("New Car Color:" + c1.Color);
            //PROPERTIES OF BOOK CLASS
            //Book b1= new Book();
            //Console.WriteLine( "Hamna's Book: "+b1.Title);
            //b1.Title = "biology";
            //Console.WriteLine("Hiba's Book : "+ b1.Title);
            //Laptop l1=new Laptop();
            //Console.WriteLine("Old brand :" + l1.Brand);
            //    l1.Brand = "hp";
            //Console.WriteLine("New brand :" + l1.Brand);
            //l1.price = 59000;
            //Console.WriteLine("Old Price :"+ l1.price);
            //l1.price = 75000;
            //Console.WriteLine("New Price:" + l1.price);
            //l1.color = "silver";
            //Console.WriteLine("New Color :" + l1.color);
            // PRACTICE OF CODE OF PROPERTIES
            //Product p1 = new Product();
            //p1.ShowDetails();
            //p1.Name = "Pen";
            //p1.Price = 50;
            //Console.WriteLine("Updated Details:");

            //p1.ShowDetails();
            // PROPERTIES OF EMPLOYEE ENCAPSULATION AND AUTOMATIC
            //Employee e1 = new Employee();
            //Console.WriteLine("Old Details");
            //e1.ShowDetails();
            //e1.Name = "Malaika";
            //e1.Salary = 80000;
            //Console.WriteLine("New Details :");
            //e1.ShowDetails();
            // PROPERTIES ENCAPSULATION AND AUTOMATIC
            //Student s1= new Student();
            //Console.WriteLine("Old details");
            //s1.ShowDetails();
            //    s1.Name = "hiba";
            //s1.Marks = 50;
            //Console.WriteLine("New Details");
            //s1.ShowDetails();

































        }

        //class Mobile
        //{
        //    public string brand = "Samsung";
        //    public int price = 50000;
        //}
        //class Student
        //{
        //    public string name = "hanzala";
        //}
        //class Student
        //{
        //    public string name = "ali";
        //    public int age = 21;
        //}
        //class mobile
        //{
        //    public string name = "sumsung";
        //    public int price = 57000;
        //}
        //dynamic program 
        //class Mobile
        //{
        //    public string brand;
        //    public int price;
        //    public string color;
        //    public string size;
        //}
        //class Car
        //{
        //    public string Brand = "honda city";
        //    public int price = 550000;
        //    public void ShowBrand()
        //    {
        //        Console.WriteLine(Brand);
        //    }
        //    public void showprice()
        //    {
        //        Console.WriteLine(price);
        //    }
        //class Mobile
        //{
        //    public string brand;
        //    public int price;
        //    public void ShowBrand()
        //    {
        //        Console.WriteLine(brand);
        //        Console.WriteLine(price);
        //class Car
        //{
        //    public string brand;
        //    public int price;
        //    public void ShowDetails()
        //    {
        //        Console.WriteLine(brand);
        //        Console.WriteLine(price);
        //        }
    }
    //class Student
    //{
    //    public string name = "hamna";
    //    public void ShowName()
    //    {
    //        Console.WriteLine(name);
    //    }
    //class student
    //{
    //    public string name = "hamna";
    //    public void ShowName()
    //    {
    //        Console.WriteLine(name);
    //    }
    //    class Car
    //{
    //    public string brand = "Tayota";
    //    public void ShowBrand()
    //    {
    //        Console.WriteLine(brand);
    //    }
    //practice home

    //class Car
    //{
    //    public string brand = "wagnor";
    //    public void ShowDetails()
    //    {
    //        Console.WriteLine(brand);
    //    }
    //class Student
    //{
    //    public string name = "hamna";
    //    public void ShowName()
    //    {
    //        Console.WriteLine(name);
    //    }
    // student class
    //class Student
    //{
    //    public string name;
    //    public void ShowName()
    //    {
    //        Console.WriteLine(name);
    //    }
    // constructor code
    //class Student
    //{
    //    public string name;
    //    public Student()
    //    {
    //        name = "hamna";
    //    }
    //CLASS CAR
    //class Car
    //{
    //    public string name;
    //    public Car()
    //    {
    //        name = "honda city";
    //    }
    // Mobile phone 
    //class Mobile
    //{
    //    public string name;
    //    public Mobile()
    //    {
    //        name = "Sumsung";
    //    }
    // srudent constructor
    //class Student
    //{
    //    public string name;
    //    public Student()
    //    {
    //        name = "zainab";
    //    }
    // Private class
    //class Mobile
    //{
    //    private string brand = "vivo";
    //    public void ShowBrand()
    //    {
    //        Console.WriteLine(brand);
    //    }
    //Parameters in Constructor
    //class Mobile
    //{
    //    public string name;
    //    public string color;

    //    public Mobile(string MobileName, string colorName)
    //    {
    //        name = MobileName;
    //        color = colorName;
    //    }
    //    public void ShowDetails()
    //    {
    //        Console.WriteLine( "Name:   "   +  name);
    //        Console.WriteLine( "color:  "   +  color);
    //    }
    //private CAR 
    //class Car
    //{
    //    private string model = "Honda City";
    //    private string color = "white";
    //    private int price = 560000;

    //    public void ShowModel()


    //    {
    //        Console.WriteLine(model);
    //        Console.WriteLine(color);
    //        Console.WriteLine(price);
    //    }
    //private STudent COde
    //class Student
    //{
    //    private string name = "Hamna Baig";
    //    public int age = 22;
    //    private string city = "Lahore"; 
    //       public void ShowName()
    //    {
    //        Console.WriteLine(name);
    //        Console.WriteLine(age);
    //        Console.WriteLine(city);
    //    }
    // employee private class
    //class Employee
    //{
    //    private String employee = "ali";
    //    private string department = "IT";
    //    private int Salary = 45600;



    //    public void ShowName()
    //    {
    //        Console.WriteLine("Employee:    " + employee);
    //        Console.WriteLine("Department:  " + department);
    //        Console.WriteLine("Salary:      " + Salary);
    //    }
    //PRIVATE BOOK CLASS
    //class Book
    //{
    //    private string book = "Atomic book";
    //    private int price = 1200;
    //    public void ShowName()
    //    {
    //        Console.WriteLine("book: " + book);
    //        Console.WriteLine("price :"+ price);
    //    }
    //PROTECTED CLASS 
    //class Animal
    //{
    //    protected string name = "Dog";

    //    public string Color = "white";
    //    public void ShowDetails()
    // {
    //    Console.WriteLine("name: " + name);
    //        Console.WriteLine("Color: " + Color);
    //        }
    //2 class of protected
    //    class Animal
    //{
    //    protected string name = "dog";
    //    }
    //class Dog : Animal
    //{
    //    public void ShowName()
    //    {
    //        Console.WriteLine(name);
    //    }
    //}
    // internal CLASS CODE
    //class Company
    //{
    //    internal int Salary = 60000;
    //}
    //class Employee : Company
    //{
    //    public void ShowSalary()
    //    {
    //        Console.WriteLine("Employee Salary: " + Salary);
    //    }
    //}
    // practice at home public and private
    //class Employee
    //{
    //    private string name;
    //    private int salary;
    //    public Employee(string emloyeeName, int employeeSalary)
    //    {

    //        name = emloyeeName;
    //        salary = employeeSalary;
    //    }

    //    public void ShowName()
    //    {
    //        Console.WriteLine(" EmployeeName    " + name);
    //        Console.WriteLine(" EmployeeSalary  " + salary);
    //    }
    //}
    //STUDENT CONSTRUCTOR CLASS
    //class Student
    //{
    //    private string name;
    //    private int marks;
    //    public Student(string studentName, int studentMarks)

    //    {
    //        name = studentName;
    //        marks = studentMarks;
    //    }
    //    public void ShowDetails()
    //    {
    //        Console.WriteLine(" StudentName  :" + name);
    //        Console.WriteLine(" StudentMarks :" + marks);
    //    }
    //}
    //PROTECTED SOUND CLASS
    //class Animal
    //{
    //    protected string sound = ("woof woof");
    //}
    //class dog : Animal
    //{
    //    public void ShowSound()
    //    {
    //        Console.WriteLine(" Dog Sound : " + sound);
    //    }
    //}
    //class Animal
    //{
    //    protected string sound = ("meoww");

    //}
    //class Cat : Animal
    //{
    //    public void ShowSound()

    //    {
    //        Console.WriteLine(" Cat Sound : " + sound);
    //    }
    //}
    //INTERNAL CLASS CODE 
    //    class Company
    //    {
    //        internal int Salary = (70000);



    //        class Employee : Company;
    //        public void ShowSalary()
    //        {
    //            Console.WriteLine("Employee Salary :" + Salary);
    //        }
    //    }
    //}
    // 2ND PRACTICE OF INTERNAL
    //class Bank
    //{
    //    internal int balance = (78000);

    //    class Customer { }




    //    public void ShowSalary()

    //    {
    //        Bank b1 = new Bank();
    //        Console.WriteLine("Account Balance :" + b1.balance);
    //    }
    //}


}
//internal teacher class code
//        class Student
//{
//    internal int totalstudents = 120;
//    internal string schoolname = ("The Trust School");
//    internal int studentfees = 5000;
//    internal string principalname = ("Sir Hanzala");

//    class Teacher { }
//    public void ShowDetails()
//    {
//        Student s1 = new Student();
//        Console.WriteLine(" Total students : " + s1.totalstudents);
//        Console.WriteLine(" SchoolName     : " + s1.schoolname);
//        Console.WriteLine(" StudentFees    :" + s1.studentfees);
//        Console.WriteLine(" PrincipalName  :" + s1.principalname);
//    }
//}


// combine class 
//    class Employee
//    {
//        public string name;
//        private int salary = 87000;
//        protected string department = "IT";
//        internal string company = "HCC";


//    public void ShowSalary()
//        {
//            Console.WriteLine("Salary   :  " + salary);
//        }
//    }
//}
//class Manager: Employee
//{
//    public void ShowDepartment()
//    {
//        Console.WriteLine("Department : " + department);
//    }
//}
//class Office
//{
//    public void ShowCompany()
//    {
//        Employee e1=new Employee();
//        Console.WriteLine("Company  : " + e1.company);
//    }
//}
// combine mobile class code
//class Mobile
//{
//    public string model;
//    private int price = 88000;
//    protected string brand = "Sumsung";
//    internal string shopname = "Mobile house";
//    public void ShowPrice()
//    {
//        Console.WriteLine("MobilePrice : " + price);
//    }
//}
//class Phone: Mobile
//{
//    public void ShowBrand()
//    {
//        Console.WriteLine("MobileBrand :" + brand);
//    }

//}
//class Shop
//{
//    public void ShowShopName()
//    {
//        Mobile m2= new Mobile();
//        Console.WriteLine("ShopName :" + m2.shopname);
//    }
//}
//PROPERTIES CLASS CODE AUTOMATIC
//class Student
//{
//    public string name { get; set; }
//    public void ShowName()
//    {
//        Console.WriteLine("Student Name: " + name);
//    }
//}
//PROPERTIES OF MOBILE CLASS AUTOMATIC
//class Mobile
//{
//    public string model { get; set; }
//    public int price {  get; set; }
//    public string color {  get; set; }
//    public int ram {  get; set; }
//    public int storage {  get; set; }
//    public void ShowDetails()
//    {
//        Console.WriteLine("Mobile Model :"+  model);
//        Console.WriteLine("Mobile Price :"+ price);
//        Console.WriteLine("Mobile Color :" + color);
//        Console.WriteLine("Mobile Ram   :" + ram);
//        Console.WriteLine("Mobile Storage : " + storage + "GB");
//    }

//}
//PRACTICE OF PROPERTIES  BASIC 
//    class Student
//{
//    public string Name { get; set; }
//    public int marks {  get; set; }
//    public void ShowDetails()
//    {
//        Console.WriteLine("StudentName :" + Name);
//        Console.WriteLine("StudentMarks :"+  marks);
//    }
//}
//PRACTICE OF TASK OF PROPERTIES BASIC
//class Mobile
//{
//    private string _brand = "Samsung";
//    public string brand
//    {
//        get { return _brand; }
//        set { _brand = value; }
//    }
//}
//PROPERTIES CODE OF CARCLASS BASIC
//class Car
//{
//    private string _color;
//    public string Color
//    {
//        get { return _color; }
//        set { _color = value; }
//    }
//}
//PROPERTIES OF CLASS OF BOOK BASIC
//class Book
//{
//    private string _title = "English";
//    public string Title
//    {
//        get { return _title; }
//        set { _title = value; }
//    }
//}
// PROPERTY OF CLASS CODE OF LAPTOP BASIC
//class Laptop
//{
//    private  string brand = "dell";
//    public int price;
//    public string color;
//    public string Brand
//    {
//        get { return brand; }
//        set { brand = value; }
//    }

//}
//practice of code OF PROPERTIES
//class Product
//{
//    private string _name = "NoteBook";
//    public string Name
//    {
//        get { return _name; }
//        set { _name = value; }
//    }
//        public int Price { get; set; } = 100;
//        public void ShowDetails()
//    {

//            Console.WriteLine("Product Name:"+ Name);
//        Console.WriteLine("Product Price: " + Price);
//        }
//    }
// PROPERTIES OF ENCAPSULATION AND AUTOMATIC MEGTHOD
//class Employee
//{
//    private string _name = "Hamna";
//    public string Name
//    {
//        get { return _name; }
//        set { _name = value; }
//    }
//        public int Salary { get; set; } = 50000;
//        public void ShowDetails()
//    {
//        Console.WriteLine("Employee Name :" + Name);
//        Console.WriteLine("Employee Salary :" + Salary);
//    }
//    }
// PROPERTIES ENCAPSULATION AND AUTOMATIC PROPERTY CODE
//class Student
//{
//    private string name = "hamna";
//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }
//        public int Marks { get; set; } = 70;
//    public void ShowDetails()
//    {
//        Console.WriteLine("Student Name :" + Name);
//        Console.WriteLine("Student Marks :" + Marks);
//    }

//    }


    















































































