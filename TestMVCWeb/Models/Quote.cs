using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMVCWeb.Models
{
    public class Quote
    {
        private static Random randomizer = new Random();

        private static List<Quote> Quotes = new List<Quote>
        {
            new Quote { Author = "J.레이놀즈", Contents = "큰 재주를 가졌다면 근면은 그 재주를 더 낫게 해줄 것이며," +
                "보통의 능력밖에 없다면 근면은 부족함을 보충해 줄 것이다."},
            new Quote { Author = "B.프랭클린", Contents = "백권의 책에 쓰인 말보다 한 가지 성실한 마음이 더 크게 사람을 움직인다."}
        };
        public string Author { get; private set; }
        public string Contents { get; private set; }

        public static Quote ChooseRandomQuote()
        {
            int randomIndex = randomizer.Next(Quotes.Count);
            return Quotes[randomIndex];
        }
    }
}
