
using System;
using System.Collections.Generic;
using System.Text;

namespace pz_01
{
    /*
     21 вариант
Создать класс Atom описывающий характеристики химического вещества как сущность в 
приложении
Член класса название особенности
поле name Имя хим элемента
поле countElectrons Количество электроном
поле mass Масса атома
поле valence валентность
метод GetInfo() выводит описание текущего объекта
     */
    class Atom
    {
        string name;
        int countElectrons;
        double mass;
        int valence;

        public Atom(string a, int b, double c, int d)
        {
            name = a;
            countElectrons = b;
            mass = c;
            valence = d;
        }

        public void GetInfo()
        {
            Console.WriteLine("{0}", name);
            Console.WriteLine("{0}", countElectrons);
            Console.WriteLine("{0}", mass);
            Console.WriteLine("{0}", valence);
        }
    }
}
