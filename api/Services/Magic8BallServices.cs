
namespace api.Services
{
    public class Magic8BallServices : IMagic8BallServices
    {
        public string UniqueResponses()
        {
            Random rnd = new Random();
            int responseNum = rnd.Next(1, 9);

            switch (responseNum)
            {
                case 1:
                    return "Without a doubt";
                case 2:
                    return "Outlook looks good";
                case 3:
                    return "Signs point to yes";
                case 4:
                    return "Ask again later";
                case 5:
                    return "Better not tell you now";
                case 6:
                    return "Concentrate and ask again";
                case 7:
                    return "My sources say no";
                case 8:
                    return "Don't count on it";
                default:
                    return "Try again";
            }
        }
    }
}