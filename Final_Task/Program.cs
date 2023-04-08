using System;


namespace Final_Task
{
    // Доставка
    class Delivery : Persona
    {
        Persona Persona = new Persona();

        public void TypeDelivery(string type)
        {
            if (type == "home")
            {
                HomeDelivery homeDelivery = new HomeDelivery();
                homeDelivery.Delivery("Сергей Сергеев", Persona.phone);
            }
            else if (type == "pick")
            {
                PickPointDelivery pickPointDelivery = new PickPointDelivery();
                pickPointDelivery.Delivery(Persona.phone);
            }
            else
            {
                ShopDelivery shopDelivery = new ShopDelivery();
                shopDelivery.Delivery(Persona.phone);
            }
        }

    }

    // Доставка на дом
    class HomeDelivery : Delivery
    {
        public void Delivery(string nameCourier, long phone)
        {
            Console.WriteLine("Доставка курьером");
            Console.WriteLine($"Ваш заказ доставит: {nameCourier}");
            Console.WriteLine($"Вам позвонят по номеру телефона: {phone}");
        }
    }

    // Доставка в пункт выдачи
    class PickPointDelivery : Delivery
    {
        private string _address = "Москва, ул ... дм ...";
        public  void Delivery(long phone)
        {
            Console.WriteLine($"Доставка в пункт выдачи по адресу {_address}");
            Console.WriteLine($"Вам позвонят по номеру телефона: {phone}");
        }
    }

    // Доставка в магазин
    class ShopDelivery : Delivery
    {
        private string _address = "Москва, ул ... дм ...";

        public void Delivery(long phone)
        {          
            Console.WriteLine($"Доставка в магазин по адресу {_address}");
            Console.WriteLine($"Вам позвонят по номеру телефона: {phone}");
        }
    }

    // Заказ
    class Order : Delivery
    {
        public string description = "Описание";

        public virtual void Description()
        {
            Console.WriteLine($"Информация о товаре: ");
        }

        public virtual void Product1()
        {
            Console.WriteLine($"Ваш заказ: ");
        }
    }

    // Заказчик
    class Persona
    {
        public string name = "Роман";
        public string lastName = "Романов";
        public long phone = 800112233;

        public void Name()
        {
            Console.WriteLine($"Доставка на имя: {lastName} {name}");
        }
    }

    // Продукт
    class Product : Order
    {
        private string decription = " .... ";
        private string nameProduct = " .... ";

        public override void Description()
        {
            Console.WriteLine($"Описание: {decription}");
        }
        public override void Product1()
        {            
            Console.WriteLine($"Ваш заказ: {nameProduct}");
        }
    }

    // Ид
    class Identifier<Tid>
    {
        public Tid id;

        public void ID(Tid id)
        {
            Console.WriteLine($"Номер вашего заказа: {id}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Identifier<string> id = new Identifier<string>();
            id.id = "XXX-777";
            string num = id.id;

            Identifier<string> ID = new Identifier<string>();
            ID.ID(num);

            Order order = new Order();
            Product product = new Product();
            Delivery delivery = new Delivery();
            Persona persona = new Persona();

            persona.Name();
            Console.Write("Тип доставки:  ");
            delivery.TypeDelivery("home");
            order.Description();
            product.Product1();
            product.Description();


        }
    }
}
