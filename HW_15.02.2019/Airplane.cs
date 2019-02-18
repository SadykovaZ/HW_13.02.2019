using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Курс: Платформа Microsoft .NET и язык программирования C#
//Тема: Введение в классы

namespace HW_13._02._2019
{
    public enum type { cargo, passenger, military }
    //1.	Разработать один из классов на ваше усмотрение 
    public partial class Airplane
    {
        //2.	Реализовать не менее пяти закрытых полей (различных типов), представляющих основные характеристики рассматриваемого класса
        private
        string model;
        string color;
        type plane_type;
        double speed;
        int capacity;
        //3.	Создать не менее трех методов управления классом и методы доступа к его закрытым полям.
        public string PlaneModel { get; set; }
        public string PlaneColor { get; set; }
        public type PlaneType { get; set; }
        public double PlaneSpeed { get; set; }
        public int PlaneCapacity { get; set; }
        //4.	Создать метод, в который передаются аргументы по ссылке
        public void getPlaneModel(ref string model)
        {
            model = this.model;
        }
        //5.	Создать не менее двух статических полей (различных типов), представляющих общие характеристики объектов данного класса
        public static int count = 0;
        public static double Price;
        //6.	Обязательным требованием является реализация нескольких перегруженных конструкторов, аргументы которых определяются студентом, исходя из специфики реализуемого класса, а также реализация конструктора по умолчанию
        public Airplane()
        {
            this.model = "Boeing";
            this.color = "White";
            this.plane_type = type.passenger;
            this.speed = 300.5;
            this.capacity = 50;
        }
        public Airplane(string model) 
        {
            this.model = model;
        }
        public Airplane( string model, string color)
        {
            this.model = model;
            this.color = color;
        }
        public Airplane(string model, string color, type pType)
        {
            this.model = model;
            this.color = color;
            this.plane_type = pType;

        }
        public Airplane(string model, string color, type pType, double speed)
        {
            this.model = model;
            this.color = color;
            this.plane_type = pType;
            this.speed = speed;
        }
        public Airplane(string model, string color, type pType, double speed, int capacity)
        {
            this.model = model;
            this.color = color;
            this.plane_type = pType;
            this.speed = speed;
            this.capacity = capacity;
        }
        //7.	Создать статический конструктор
        static Airplane()
        {
            Price = 500000;
        }
    }   
}
