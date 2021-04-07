using System;
using static System.Console;

namespace chp09.TypeCasting
{
    class Mammal    //부모클래스(포유류)
    {
        public void Nurse()
        {
            WriteLine("Nurse()");
        }
    }

    class Dog : Mammal  //자식클래스(개), 포유류의 특징들을 상속받음
    {
        public void Bark()
        {
            WriteLine("Bark()");
        }
    }

    class Cat : Mammal  //자식클래스(고양이), 포유류의 특징들을 상속받음
    {
        public void Meow()
        {
            WriteLine("Meow()");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Dog();
            Dog dog;
            
            //is는 객체가 해당 형식에 해당하는지 검사하고 bool값을 반환함
            if(mammal is Dog)   //mammal은 Dog형식이다 => ("true"/false)
            {
                dog = (Dog)mammal;
                dog.Bark();
            }

            Mammal mammal2 = new Cat();

            //as는 형식 변환 연산자와 같은 역할을 함
            //대신 형식변환 연산자의 경우 반환에 실패할때 예외를 던지지만
            //as는 객체 참조를 null로 만듬
            Cat cat = mammal2 as Cat;
            if(cat != null)
            {
                cat.Meow();
            }

            Cat cat2 = mammal as Cat;   //개는 고양이가 될수 없음?? 이렇게 이해하는게 맞나?
            if(cat2 != null)
            {
                cat2.Meow();
            }
            else
            {
                WriteLine("cat2 is not a Cat");
            }
        }
    }
}
