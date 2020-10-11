using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceTool
{
    class Dx:Dice//不同实体骰子的父类。
    {
        private int diceNumber = 1;//默认骰子数量为1

        private int diceType=1;//骰子有几面

        public int DiceType { get => diceType; set => diceType = value; }

        private int[] diceResult;//反映骰子结果的数组

        public int DiceNumber { get => diceNumber; set => diceNumber = value <= 1 ? 1 : diceNumber = value; }
        //骰子数属性。备忘：要在前台文本框中限定输入0-9，此处实质仅规定骰子数不能为0

        private int Sum(int[] result)//一个求骰子和的函数
        {
            int sum = 0;
            foreach (int temp in result)
            {
                sum += temp;
            }
            return sum;
        }

        public int DiceSum { get =>Sum(DiceResult); }//只读的骰子和属性
        public int[] DiceResult { get => diceResult; set => diceResult = value; }
        

        //骰子结果属性。

        public virtual void GetResult()//定义虚方法
        {
            DiceResult = Roll(DiceNumber, DiceType);
        }


    }

    class D4: Dx//四面骰，继承Dx类
    {
        public D4()//构造方法
        {
        DiceType = 4;
        }

        public override void GetResult()//获得骰子结果的方法。
        {
            DiceResult = Roll(DiceNumber, 4);
 
        }
    }

    class D6 : Dx//六面骰，继承Dx类
    {
        public D6()
        {
            DiceType = 6;
        }

        public override void GetResult()
        {
            DiceResult = Roll(DiceNumber, 6);
            
        }
    }

    class D8 : Dx //八面骰，继承Dx类
    {
        public D8()
        {
            DiceType = 8;
        }

        public override void GetResult()
        {
            DiceResult = Roll(DiceNumber, 8);
            
        }
    }

    class D10 : Dx //十面骰，继承Dx类
    {
        public D10()
        {
            DiceType = 10;
        }

        public override void GetResult()
        {
            DiceResult = Roll(DiceNumber, 10);

        }
    }

    class D12 : Dx //十二面骰，继承Dx类
    {
        public D12()
        {
            DiceType = 12;
        }

        public override void GetResult()
        {
            DiceResult = Roll(DiceNumber, 12);
 
        }
    }

    class D20 : Dx //二十面骰，继承Dx类
    {
        public D20()
        {
            DiceType = 20;
        }

        public override void GetResult()
        {
            DiceResult = Roll(DiceNumber, 20);          

        }
    }

    

}
