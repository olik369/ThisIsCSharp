using System;
using static System.Console;

namespace chp12.SealedMethod
{
    class Base
    {
        public virtual void SealMe()
        {

        }
    }

    class Derived : Base
    {
        public sealed override void SealMe()
        {
            base.SealMe();
        }
    }

    /*
    class WantToOverride : Derived
    {
        public override void SealMe()   //Derived의 SealMe메소드가 sealed되있어서 오버라이드 
                                        //할수가 없음!
        {

        }
    }
     */
    class MainApp
    {
        static void Main(string[] args)
        {

        }
    }
}
