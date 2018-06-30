using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Product classina aid olan queryler

            //1.1.Stock sayi cut olan ve qiymeti 5 manatdan yuxari olan mallari ekrana cixarin

            //1.2.En bahali pen(qelem)-in stock sayini ekrana cixarin

            //1.3.Adinda "ok" herf birlesmesi kecen productlarin qiymetlerinin 2 qatini ekrana cixarin

            //1.4.Productlarin adini elifba sirasiyla duzub hem boyuk hem kicik herflerle yazilmis formada ekrana cixarin


            //1.5.En uzun ada sahib olan productun stock sayinin 3e bolunmesinden alinan qaligi tapin


            //1.6.En bahali productun adinin tersine yazilmis formasini ekrana cixarin


            string[] names = { "Narmin", "Sekine", "Elvin", "Emin", "Naib", "Zohrali", "Fazil Abi", "Suleyman","Zamin","Nurlan" };

            int[] numbers = { 5, 7, 2, 6, 12, 25, 17, 9, 26, 33,41 };
            //2.Arraylere aid olan queryler

            //2.1 Eyni herfle baslayan adlari qruplasdirib hansi herfle basladigini qeyd ederek ekrana cixardin
            //Meselen N herfi ile baslayan adlar:
            //Narmin,Nurlan,Naib...

       
            //2.2.Numbers arrayi icerisinde 5e bolunende eyni qaligi alinan ededleri qruplasdirib qaligini qeyd ederek ekrana cixardin
            //Meselen 5e bolunerken qaligi 1 olan ededler 6,26,41

            //2.3.Numbers arrayi icersinde cut ededlerden en kiciyinin 3 qatini ekrana cixardin

      

            int[] nums = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] str = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //2.4.nums arrayindeki ededleri strdeki adlarina uygun ekrana yazdirin
            //meselen birinci 5 verilib five ciarsin sonra four one ve s....

     

            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            //2.5 numbersA arrayindeki reqemlerin numbersB arrayindeki ededlerle muqayisesinden kicik olanlari ekrana cixarin
            //Ekrana cixmalidir :
            //0 kicikdir 1-den
            //0 kicikdir 3-den
            //0 kicikdir 5-den
            //0 kicikdir 7-den
            //0 kicikdir 8-den
            //2 kicikdir 3-den .....

  



        }
    }
}
