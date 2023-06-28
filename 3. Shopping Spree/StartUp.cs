using _3._Shopping_Spree.Models;

namespace _3._Shopping_Spree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            string[] products = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            int count = strings.Length;
            int currentint = 0;
            List<Person> personList = new List<Person>();
            List<Product> productsList = new List<Product>();
            while (true)
            {
                if (count == 0)
                {
                    break;
                }

                string[] current = strings[currentint].Split("=", StringSplitOptions.RemoveEmptyEntries);
                string name = current[0];
                decimal money = decimal.Parse(current[1]);

                try
                {
                    Person person = new Person(name, money);
                    personList.Add(person);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }

                string[] currentProduct = products[currentint].Split("=", StringSplitOptions.RemoveEmptyEntries);
                string productName = currentProduct[0];
                decimal productCost = decimal.Parse(currentProduct[1]);

                try
                {

                    Product product = new Product(productName, productCost);
                    productsList.Add(product);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }



                currentint++;
                count--;

            }

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] info = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string personName = info[0];
                string productName = info[1];

                if (personList.Any(x => x.Name == personName) && productsList.Any(x => x.Name == productName))
                {
                    Person person = personList.FirstOrDefault(x => x.Name == personName);
                    Product product = productsList.FirstOrDefault(x => x.Name == productName);
                    if (person.Money >= product.Cost)
                    {
                        person.Money -= product.Cost;
                        person.BagOfProducts.Add(product);
                        Console.WriteLine($"{person.Name} bought {product.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} can't afford {product.Name}");
                    }
                }

            }

            foreach (var item in personList)
            {

                if (item.BagOfProducts.Count == 0)
                {
                    Console.WriteLine($"{item.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{item.Name} - {string.Join(", ", item.BagOfProducts.Select(x => x.Name))}");
                }
            }
        }
    }
}