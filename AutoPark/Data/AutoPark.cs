namespace AutoPark2.Data
{
    public class AutoPark
    {
        public List<User> Users { get; set; }
        public List<Brand> Brands { get; set; }
        public List<Model> Models { get; set; }
        public List<Car> Cars { get; set; }

        public AutoPark()
        {
            Users = new List<User>();
            Brands = new List<Brand>();
            Models = new List<Model>();
            Cars = new List<Car>();
        }
    }
}
