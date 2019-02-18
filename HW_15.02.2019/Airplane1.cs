using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_13._02._2019
{
    public partial class Airplane
    {
        //9.	Создать дополнительный метод для данного класса в другом файла, используя ключевое слово partial. 
        void print()
        {
            Console.WriteLine("Самолет:\n Модель: {0}\nЦвет: {1}\nВид: {2}\nСкорость: {3}\nВместимость: {4}", this.model, this.color, this.plane_type.ToString(), this.speed, this.capacity);


        }
    }
}
