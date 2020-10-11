using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceTool
{
    class MultDice:Dx
    {    
   


        bool useD4, useD6, useD8, useD10, useD12, useD20, useDx = new bool();

        public D4 d4 = new D4();
        public D6 d6 = new D6();
        public D8 d8 = new D8();
        public D10 d10 = new D10();
        public D12 d12 = new D12();
        public D20 d20 = new D20();
        public Dx dx = new Dx();

        List<int> multDiceList = new List<int>();

        public bool UseD4 { get => useD4; set => useD4 = value; }
        public bool UseD6 { get => useD6; set => useD6 = value; }
        public bool UseD8 { get => useD8; set => useD8 = value; }
        public bool UseD10 { get => useD10; set => useD10 = value; }
        public bool UseD12 { get => useD12; set => useD12 = value; }
        public bool UseD20 { get => useD20; set => useD20 = value; }
        public bool UseDx { get => useDx; set => useDx = value; }
        public List<int> MultDiceList { get => multDiceList; set => multDiceList = value; }

        public override void GetResult()
        {
            while(UseD4)
            {
                
                d4.GetResult();
                for(int i=0;i<d4.DiceResult.Length;i++)
                {
                    MultDiceList.Add(d4.DiceResult[i]);
                }

                UseD4 = false;
             
            }

            while (UseD8)
            {

                d8.GetResult();
                for (int i = 0; i < d8.DiceResult.Length; i++)
                {
                    MultDiceList.Add(d8.DiceResult[i]);
                }

                UseD8 = false;

            }

            while (UseD6)
            {

                d6.GetResult();
                for (int i = 0; i < d6.DiceResult.Length; i++)
                {
                    MultDiceList.Add(d6.DiceResult[i]);
                }

                UseD6 = false;

            }

            while (UseD10)
            {

                d10.GetResult();
                for (int i = 0; i < d10.DiceResult.Length; i++)
                {
                    MultDiceList.Add(d10.DiceResult[i]);
                }

                UseD10 = false;

            }

            while (UseD12)
            {

                d12.GetResult();
                for (int i = 0; i < d12.DiceResult.Length; i++)
                {
                    MultDiceList.Add(d12.DiceResult[i]);
                }

                UseD12 = false;

            }

            while (UseD20)
            {

                d20.GetResult();
                for (int i = 0; i < d20.DiceResult.Length; i++)
                {
                    MultDiceList.Add(d20.DiceResult[i]);
                }

                UseD20 = false;

            }

            while (UseDx)
            {

                dx.GetResult();
                for (int i = 0; i < dx.DiceResult.Length; i++)
                {
                    MultDiceList.Add(dx.DiceResult[i]);
                }

                UseDx = false;

            }

            DiceResult = new int[this.MultDiceList.Count];//定义长度为list长度的int数组List

            for (int i = 0; i < MultDiceList.Count; i++)
            {
                DiceResult[i] = (int)MultDiceList[i];
            }

        }
    }
}
