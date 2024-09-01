using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Converting_Data_Type
{
    public class ShippingRepository
    {
        public static List<Shipping> AllAsList => new List<Shipping>()
        {
            new GroundShipping("ABC001", "Omer MEMES", DateTime.Today.AddDays(-1)),
            new AirShipping("ABC002", "Muhammed MEMES", DateTime.Today.AddDays(1)),
            new OceanShipping("ABC003", "Mahmut MEMES", DateTime.Today.AddDays(-1)),
            new AirShipping("ABC004", "Abdullrahaman", DateTime.Today.AddDays(1)),
            new GroundShipping("ABC005", "Ali MEMES", DateTime.Today.AddDays(1)),
            new AirShipping("ABC006", "Yusuf Bozkurt", DateTime.Today.AddDays(-1)),
            new OceanShipping("ABC007", "Musa Aktay", DateTime.Today.AddDays(1)),
            new AirShipping("ABC008", "Mustafa Sultan", DateTime.Today.AddDays(-1)),
            new GroundShipping("ABC009", "Salih Ozdemir", DateTime.Today.AddDays(-1)),
            new AirShipping("ABC010", "Murat Dogar", DateTime.Today.AddDays(1)),
            new OceanShipping("ABC011", "Omer Ozalp", DateTime.Today.AddDays(-1)),
            new AirShipping("ABC012", "Ali MEMEs", DateTime.Today.AddDays(1)),
        };

        public static ShippingList<Shipping> AllAsShippingList => new ShippingList<Shipping>()
        {
            new GroundShipping("ABC001", "Omer MEMES", DateTime.Today.AddDays(-1)),
            new AirShipping("ABC002", "Muhammed MEMES", DateTime.Today.AddDays(1)),
            new OceanShipping("ABC003", "Mahmut MEMES", DateTime.Today.AddDays(-1)),
            new AirShipping("ABC004", "Abdullrahaman", DateTime.Today.AddDays(1)),
            new GroundShipping("ABC005", "Ali MEMES", DateTime.Today.AddDays(1)),
            new AirShipping("ABC006", "Yusuf Bozkurt", DateTime.Today.AddDays(-1)),
            new OceanShipping("ABC007", "Musa Aktay", DateTime.Today.AddDays(1)),
            new AirShipping("ABC008", "Mustafa Sultan", DateTime.Today.AddDays(-1)),
            new GroundShipping("ABC009", "Salih Ozdemir", DateTime.Today.AddDays(-1)),
            new AirShipping("ABC010", "Murat Dogar", DateTime.Today.AddDays(1)),
            new OceanShipping("ABC011", "Omer Ozalp", DateTime.Today.AddDays(-1)),
            new AirShipping("ABC012", "Ali MEMEs", DateTime.Today.AddDays(1)),
        };
    }
}
