namespace Pizzeria
{
    public abstract class Pizza
    {
        protected Pizza() => Size = PizzaSize.Normal;

        public virtual string Description  => "Unknown Pizza";

        public PizzaSize Size { get; set; }

        public virtual double Cost => 0;
    }
}
