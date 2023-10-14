using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Json;

namespace MauiDevExpress
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = this;
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(2000);
            LoadData();
        }

        private void LoadData()
        {
            var monkeys = new List<Monkey>
            {
                new Monkey
                {
                    Name = "Chimpanzee",
                    Location = "Africa",
                    Details = "Chimpanzees are intelligent primates known for their problem-solving abilities.",
                    Image = "chimpanzee.jpg",
                    Population = 150000,
                    Latitude = -1.2921f,
                    Longitude = 36.8219f,
                    BirthDate = new DateTime(2000, 1, 15),
                    AccessLevel = AccessLevel.Admin
                },
                new Monkey
                {
                    Name = "Orangutan",
                    Location = "Borneo",
                    Details = "Orangutans are great apes native to the rainforests of Borneo and Sumatra.",
                    Image = "orangutan.jpg",
                    Population = 70000,
                    Latitude = 1.3521f,
                    Longitude = 110.4647f,
                    BirthDate = new DateTime(2005, 3, 20),
                    AccessLevel = AccessLevel.User
                },
                new Monkey
                {
                    Name = "Gorilla",
                    Location = "Africa",
                    Details = "Gorillas are the largest primates and share about 98.3% of their DNA with humans.",
                    Image = "gorilla.jpg",
                    Population = 100000,
                    Latitude = -0.2280f,
                    Longitude = 15.8277f,
                    BirthDate = new DateTime(1998, 7, 10),
                    AccessLevel = AccessLevel.Admin
                },
                // Add more monkey instances with BirthDate and AccessLevel properties
                new Monkey
                {
                    Name = "Howler Monkey",
                    Location = "South America",
                    Details = "Howler monkeys are known for their loud vocalizations that can be heard up to 3 miles away.",
                    Image = "howler_monkey.jpg",
                    Population = 50000,
                    Latitude = -14.2350f,
                    Longitude = -51.9253f,
                    BirthDate = new DateTime(2002, 5, 3),
                    AccessLevel = AccessLevel.User
                },
                new Monkey
                {
                    Name = "Capuchin Monkey",
                    Location = "Central and South America",
                    Details = "Capuchin monkeys are highly intelligent and are often used in scientific research.",
                    Image = "capuchin_monkey.jpg",
                    Population = 30000,
                    Latitude = 4.7100f,
                    Longitude = -74.0721f,
                    BirthDate = new DateTime(2007, 9, 18),
                    AccessLevel = AccessLevel.Admin
                },
                new Monkey
                {
                    Name = "Spider Monkey",
                    Location = "Central and South America",
                    Details = "Spider monkeys are known for their long limbs and prehensile tail, which they use to swing through trees.",
                    Image = "spider_monkey.jpg",
                    Population = 25000,
                    Latitude = 14.634915f,
                    Longitude = -90.506882f,
                    BirthDate = new DateTime(1999, 11, 7),
                    AccessLevel = AccessLevel.User
                },
                new Monkey
                {
                    Name = "Mandrill",
                    Location = "Africa",
                    Details = "Mandrills are colorful monkeys found in the rainforests of Central Africa.",
                    Image = "mandrill.jpg",
                    Population = 10000,
                    Latitude = 0.2280f,
                    Longitude = 14.8277f,
                    BirthDate = new DateTime(2004, 2, 14),
                    AccessLevel = AccessLevel.Admin
                },
                new Monkey
                {
                    Name = "Tarsier",
                    Location = "Southeast Asia",
                    Details = "Tarsiers are small primates known for their big eyes and unique hunting skills.",
                    Image = "tarsier.jpg",
                    Population = 5000,
                    Latitude = 9.3275f,
                    Longitude = 123.3076f,
                    BirthDate = new DateTime(2001, 8, 22),
                    AccessLevel = AccessLevel.User
                },
                new Monkey
                {
                    Name = "Golden Lion Tamarin",
                    Location = "Brazil",
                    Details = "Golden lion tamarins are endangered primates with striking orange fur and manes.",
                    Image = "golden_lion_tamarin.jpg",
                    Population = 1500,
                    Latitude = -22.9068f,
                    Longitude = -43.1729f,
                    BirthDate = new DateTime(2006, 12, 5),
                    AccessLevel = AccessLevel.Admin
                },
                new Monkey
                {
                    Name = "Proboscis Monkey",
                    Location = "Borneo",
                    Details = "Proboscis monkeys have large noses and are excellent swimmers.",
                    Image = "proboscis_monkey.jpg",
                    Population = 700,
                    Latitude = 2.4604f,
                    Longitude = 115.3502f,
                    BirthDate = new DateTime(2003, 4, 30),
                    AccessLevel = AccessLevel.User
                },
                // Add more monkey instances as needed
                // ...
            };

            dxg.ItemsSource = new ObservableCollection<Monkey>(monkeys);
        }


        public class Monkey
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public string Details { get; set; }
            public string Image { get; set; }
            public int Population { get; set; }
            public float Latitude { get; set; }
            public float Longitude { get; set; }
            public AccessLevel AccessLevel { get; set; }
            public DateTime BirthDate { get; set; }
        }
        public enum AccessLevel
        {
            Admin,
            User
        }
    }

}
