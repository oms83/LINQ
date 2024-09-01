using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Converting_Data_Type
{
    public abstract class Shipping
    {
        protected Shipping(string uniqueID, string sender, DateTime shippingDate)
        {
            this.UniqueID = uniqueID;
            this.Sender = sender;
            this.ShippingDate = shippingDate;
        }

        public string UniqueID { get; set; }
        public string Sender { get; set; }
        public DateTime ShippingDate { get; private set; }

        public abstract string Description { get; }

        public virtual void Start()
        {
            Console.WriteLine(
                $"\n\tCode: {UniqueID}" +
                $"\n\tCode: {Description}" +
                $"\n\tCode: {Sender}" +
                $"\n\tCode: {ShippingDate.ToShortDateString()}"
                );
        }
    }

    public class AirShipping : Shipping
    {
        public override string Description => "Air Shipping";

        public AirShipping(string uniqueID, string sender, DateTime shippingDate) : base(uniqueID, sender, shippingDate)
        {

        }
    }

    public class GroundShipping : Shipping
    {
        public override string Description => "Ground Shipping";

        public GroundShipping(string uniqueID, string sender, DateTime shippingDate) : base(uniqueID, sender, shippingDate)
        {

        }
    }

    public class OceanShipping : Shipping
    {
        public override string Description => "Ocean Shipping";

        public OceanShipping(string uniqueID, string sender, DateTime shippingDate) : base(uniqueID, sender, shippingDate)
        {

        }
    }
    public class RailShipping : Shipping
    {
        public override string Description => "Rail Shipping";

        public RailShipping(string uniqueID, string sender, DateTime shippingDate) : base(uniqueID, sender, shippingDate)
        {

        }
    }
}
