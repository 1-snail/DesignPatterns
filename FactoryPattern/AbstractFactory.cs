using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class AbstractFactory
    {
        public void Excute()
        {
            // 依赖注入
            // 高层不依赖与具体
            TomatoFood tomatoFood = new TomatoFood();
            FoodSimpleFactory foodSimple = new FoodSimpleFactory(tomatoFood);
            foodSimple.CreateFood();


            //工厂模式
            Console.WriteLine("===============================");
            Creator creator = new TomatoScrambledEggsFactory();
            Food tomato = creator.CreateFoodFactory();
            tomato.Print();
        }
    }

    // 食品--抽象类
    public abstract class Food
    {
        public abstract void Print();
    }

    // 食品--西红柿
    public class TomatoFood : Food
    {
        public override void Print()
        {
            Console.WriteLine("西红柿");
        }
    }

    // 食品--土豆肉丝
    public class ShreddedPorkWithPotatoes : Food
    {
        public override void Print()
        {
            Console.WriteLine("土豆肉丝");
        }
    }

    // 食品抽象工厂
    public class FoodSimpleFactory
    {
        Food _food;

        public FoodSimpleFactory(Food food)
        {
            _food = food;
        }


        public void CreateFood()
        {
            _food.Print();
        }
    }


    // 抽象工厂
    public abstract class Creator
    {
        public abstract Food CreateFoodFactory();
    }


    //具体工厂--西红柿工厂
    public class TomatoScrambledEggsFactory : Creator
    {
        public override Food CreateFoodFactory()
        {
            return new TomatoFood();
        }
    }

    //具体工厂--土豆肉丝工厂
    public class ShreddedPorkWithPotatoesFactory : Creator
    {
        public override Food CreateFoodFactory()
        {
            return new ShreddedPorkWithPotatoes();
        }
    }

}
