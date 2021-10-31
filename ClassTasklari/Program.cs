using System;

namespace ClassTasklari
{
    class Program
    {
        static void Main(string[] args)
        {
            //6-ci taskin davami
            Employee em1 = new Employee("Qemer","Suleymanova", "telebe", 5);
            em1.CalculateMonthlySalary(5);
        }
    }

    #region Task1
    //Car class yaradin,icinde brand,model,color,fuelCapacity,
    //doorCount propertileri olsun
    class Car : Vehicle
    {
        //public string brand { get; set; }
        //public string model { get; set; }
        //public string color { get; set; }
        public byte fuelCapacity { get; set; }
        public byte doorCount { get; set; }

        #endregion

    #region Task2
        //Car clasina metod elave edin,bu metod car-in brand ve modelini
        //cap etmelidir
        //public string Chap(string brandi,string modeli)
        //{
        //    this.brand = brandi;
        //    this.model = modeli;
        //    return $"The car's brand is {brand} and model is {model}";
        //}
        #endregion

    #region Task3
        //Car clasina consumption propertisi ve ikinci metodu elave edin
        //Bu metod car-in polnu bakla nece km yol gede bileceyini hesablasin
        //ve return etsin
        public byte consumption { get; set; }
        public int IkinciMetod(byte yol, byte fuelCapacity)
        {
            return yol / fuelCapacity;
        }
        #endregion
    }
    #region Task4
    //Bicyrcle class yaradin,icinde brand,model,color,whellSize propertileri
    //ve brand ve modeli return eden metod olsun
    class Bycircle : Vehicle
    {
        //public string brand { get; set; }
        //public string model { get; set; }
        //public string color { get; set; }
        public byte wheelSize { get; set; }
        //public string OurMetod(string brandi, string modeli)
        //{
        //    this.brand = brandi;
        //    this.model = modeli;
        //    return $"The bike's brand is {brand} and model is {model}";
        //}
    }
    #endregion

    #region Task5
    //Car ve Bicyrcle classlarinda ortaq olan metod ve propertileri
    //bu classlardan silerek Vehicle clasina elave edin ve bu her
    //iki class ucun Vehicle classindan miras(inheritance) alsin
    class Vehicle
    {
        public string brand { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        public string Chap(string brandi, string modeli)
        {
            this.brand = brandi;
            this.model = modeli;
            return $"The brand is {brand} and model is {model}";
        }
    }
    #endregion

    #region Task6
    //Employee classi yaradin, icinde name,surname,position,dailySalary
    //propertileri olsun ve ayliq maasi(monthlySalary) hesablayib 
    //return eden metod olsun.
    //Bu classdan instance alaraq propertilere deyer menimsedin ve ayliq maasi cap edin(bu qism en yuxardadi)
    class Employee
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string position { get; set; }
        public short dailySalary { get; set; }
        public Employee(string name, string surname, string position, short dailySalary)
        {
            this.name = name;
            this.surname = surname;
            this.position = position;
            this.dailySalary = dailySalary;
        }
        public int CalculateMonthlySalary(short dailySalary) {
            this.dailySalary = dailySalary;
            return dailySalary * 30;
        }
        
    }
    #endregion
}
