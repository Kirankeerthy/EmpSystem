namespace FirstApi.Models
{
    public class CarAccessories
    {
        private IAccessories _accessories;
        public CarAccessories(IAccessories c)
        {
            _accessories = c;


        }
    }

    public interface IAccessories { }


    public class StrearingWheel: IAccessories { }
    public class Gear : IAccessories { }

    public class Wheel : IAccessories { }
}
