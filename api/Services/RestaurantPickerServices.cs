using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public class RestaurantPickerServices : IRestaurantPickerServices
    {
        public string PickRestaurant(int category)
        {
            Random rnd = new Random();
            int restaurantNum = rnd.Next(1, 11);

            switch (category)
            {
                //fast food
                case 1:
                    switch (restaurantNum)
                    {
                        case 1:
                            return "McDonald's";
                        case 2:
                            return "Burger King";
                        case 3:
                            return "Chick fil A";
                        case 4:
                            return "Taco Bell";
                        case 5:
                            return "Chipotle";
                        case 6:
                            return "Wendy's";
                        case 7:
                            return "Culver's";
                        case 8:
                            return "In n Out";
                        case 9:
                            return "Raising Cane's";
                        case 10:
                            return "Popeye's";
                        default:
                            return "KFC";
                    }
                //sit down
                case 2:
                    switch (restaurantNum)
                    {
                        case 1:
                            return "Sizzler";
                        case 2:
                            return "Chubby Cattle";
                        case 3:
                            return "Mensho Ramen";
                        case 4:
                            return "State Bird Provisions";
                        case 5:
                            return "iHop";
                        case 6:
                            return "Texas Roadhouse";
                        case 7:
                            return "Chili's";
                        case 8:
                            return "Applebee's";
                        case 9:
                            return "Boiling Crab";
                        case 10:
                            return "Fogo De Chao";
                        default:
                            return "M Sushi & Bistro";
                    }
                //coffee and boba
                case 3:
                    switch (restaurantNum)
                    {
                        case 1:
                            return "Starbucks";
                        case 2:
                            return "Dunkin";
                        case 3:
                            return "Peet's Coffee";
                        case 4:
                            return "Twigs Coffee";
                        case 5:
                            return "Tram Coffee";
                        case 6:
                            return "Rose Tea Lounge";
                        case 7:
                            return "T4";
                        case 8:
                            return "T% Coffee & Tea";
                        case 9:
                            return "mOo mOo Tea House";
                        case 10:
                            return "Happy Lemon";
                        default:
                            return "ARTEASG";
                    }

                default:
                    return "Please select a number 1 - 3.";
            }
        }

    }
}