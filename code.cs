public class NewYearGift {
	public string Name;
	public string name {
		get { return Name; }
		set { Name = value; }
	}
	
	public string Weight;
	public string weight {
		get { return Weight; }
		set { Weight = value; }
	}
	
	public double GetWeight() {
		
		return GetWeight = GetWeightOf100g; 
	}

}

public class SugarProducts {
	private string 	_name;
	private double 	_weight;
	public 	double 	GetWeightOf100g;
	
	public 	string 	Name {
		get { return _name; }
		set { _name = value; }
	}
	
	public double Weight {
		get { return _weight; }

		set { _weight = value; }


	}
	public double GetWeightOf100g() {
		return GetWeightCaramel + GetWeightMarmalade + GetWeightCadies + GetWeightChocolate;
	}
}

public class Caramel {
	private string _name;
	private double _weight;
	
	public  string Name {
		get { return _name; }
		set { _name = value; }
	}
	public  double Weight {
		get { return _weight; }

		set { _weight = value; }
	}
	
	public double getWeightCaramel() {
		return _weight;
	}
}

public class Marmalade {
	private string _name;
	private double _weight;
	
	public  string Name {
		get { return _name; }
		set { _name = value; }
	}
	public  double Weight {
		get { return _weight; }

		set { _weight = value; }
	}
	
	public double getWeightMarmalade() {
		return _weight;
	}
}

public class Candies {
	private string _name;
	private double _weight;
	
	public  string Name {
		get { return _name; }
		set { _name = value; }
	}
	public  double Weight {
		get { return _weight; }

		set { _weight = value; }
	}
	
	public double getWeightCandies() {
		return _weight;
	}
}

public class Chocolate {
	private string _name;
	private double _weight;
	
	public  string Name {
		get { return _name; }
		set { _name = value; }
	}
	public  double Weight {
		get { return _weight; }

		set { _weight = value; }
	}
	
	public double getWeightChocolate() {
		return _weight;
	}
}



class Program {
    static void Main(string[] args) {
        Console.WriteLine("?????????????? ?????? ????????????????");

        string s = Console.ReadLine();

        int a = Convert.ToInt32(s);
        Caramel caramel = new Caramel {
            Name = "????????????????", weight = a
        };
        caramel.Print();
        caramel.GetWeightCaramel();

        Console.WriteLine("?????????????? ?????? ??????????????????");
        string h = Console.ReadLine();

        int b = Convert.ToInt32(h);

        Marmalade marmalade = new Marmalade {
            Name = "????????????", weight = b
        };
        marmalade.Print();
        marmalade.GetWeightMarmalade();
		
        Console.WriteLine("?????????????? ?????? ????????????");

        string o = Console.ReadLine();

        int c = Convert.ToInt32(o);
        Candies candies = new Candies {
            Name = "??????", weight = c
        };
        candies.Print();
        candies.GetWeightCandies();
		
        Console.WriteLine("?????????????? ?????? ????????????????");

        string o = Console.ReadLine();

        int c = Convert.ToInt32(o);
        Chocolate chocolate = new Chocolate {
            Name = "??????", weight = c
        };
        chocolate.Print();
        chocolate.GetWeightCandies();



        SugarProducts sugarproducts = new SugarProducts();
        double f = a + b + c;
        sugarproducts.GetWeightOf100g();
        // Console.WriteLine("??????: " + f);

        NewYearGift newyeargift = new NewYearGift();
        newyeargift.GetWeight();
        Console.WriteLine("?????? ?????????????????????? ??????????????: " + f);
    }
}