// See https://aka.ms/new-console-template for more information

using System.Collections;

ArrayList list = new ArrayList();
list.Add(1);
list.Add(2);
list.Add("three");
list.Add(true);
list.Add(null);


ArrayList list2 = new ArrayList()
{
    5, 7, "three", false, null
};


int [] arr = new int[] { 1, 2, 3, 4, 5 };

list2.AddRange(arr);

foreach (var item in list2)
{
    Console.WriteLine(item);
}

//insert

list2.Insert(1, "Hande");//This will insert "Hande" to index 1
list2.InsertRange(2, list);//This will insert list to index 2

foreach (var item in list2)
{
    Console.WriteLine(item);
}

//remove
list2.Remove(null);//This will remove the first null
//output: 5, Hande, 1, 2, three, False, 1, 2, three, False, null
list2.RemoveAt(2);//This will remove the element at index 2
//output: 5, Hande, 2, three, False, 1, 2, three, False, null
list2.RemoveRange(3, 2);//This will remove 2 elements starting from index 3
//output: 5, Hande, 2, 1, 2, three, False, null


//contains
Console.WriteLine(list2.Contains("Hande"));//True

//indexof
Console.WriteLine(list2.IndexOf("Hande"));//1



//Generic Collections
List<int> list3 = new List<int>();
list3.Add(1);
list3.Add(2);
list3.Add(3);
list3.Add(4);
list3.Add(5);
list3.AddRange(new int[] { 6, 7, 8, 9, 10 });


foreach (var item in list3)
{
    Console.WriteLine(item);
}


List<string> list4 = new List<string>() { "Hande", "Kerem", "Berkay" };

foreach (var item in list4)
{
    Console.WriteLine(item);
}


List<Product> products = new List<Product>();
products.Add(new Product { Id = 1, Name = "Laptop", Price = 5000 });
products.Add(new Product { Id = 2, Name = "Mouse", Price = 50 });


//insert
products.Insert(products.Count, new Product { Id = 3, Name = "Keyboard", Price = 100 });
products.Remove(products[0]);//This will remove the first product

foreach (var product in products)
{
    Console.WriteLine(product.Name + " " + product.Price);
}




class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}




